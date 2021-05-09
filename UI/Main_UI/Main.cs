using MDbM.Clases;
using MDbM.Properties;
using MDbM.UI.Clases;
using MDbM.UI.LoginUI;
using MDbM.UI.MongoDB;
using MongoDB.Bson;
using PeliculaCtrl;
using RepartoCtrl;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MDbM.UI.MainUI
{
    public partial class Main : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        internal Mongo db = new Mongo();

        internal Login LoginForm = null;
        internal Usuario Usuario = null;

        internal bool IsInicio = true;
        internal bool IsMiLista = false;
        internal bool IsMiListaEstado = false;

        internal string EstadoOrigen;

        private Pelicula PeliculaPulsada;

        public Main(Login Login, Usuario Usuario)
        {
            InitializeComponent();
            this.db.GetConexion();
            this.LoginForm = Login;
            this.Usuario = Usuario;
            Init();
        }

        private void Init()
        {
            ImgPerfil.Image = Image.FromFile(Path.GetUserPPPath() + this.Usuario.imagenPerfil + ".jpg");
            LblNombreUsuario.Text = this.Usuario.nombre;
            ComboBoxOrdenKey.SelectedIndex = 0;
            ComboBoxOrden.SelectedIndex = 0;
            CargarInicio(this.db.GetListaPeliculasOrdenadas(ComboBoxOrdenKey.SelectedItem.ToString().ToLower(), ComboBoxOrden.SelectedIndex));
        }

        private void CargarInicio(List<Pelicula> lista)
        {
            List<Pelicula> peliculas = lista;
            PanelLista.Controls.Clear();
            foreach (Pelicula p in peliculas)
            {
                PeliculaControl Control = new PeliculaControl();
                Control.SetEstado(this.db.GetEstadoPelicula(this.Usuario, p));
                Control.SetPortada(p.portada);
                Control.SetObjectId(p._id);
                Control.EntrarDetallePelicula += new EventHandler(EntrarPeliculaDetalle);
                PanelLista.Controls.Add(Control);
            }
        }

        private bool CargarMiLista(List<Pelicula> lista)
        {
            List<Pelicula> peliculas = lista;
            PanelLista.Controls.Clear();
            foreach (Pelicula p in peliculas)
            {
                PeliculaControl Control = new PeliculaControl();
                Control.EntrarDetallePelicula += new EventHandler(EntrarPeliculaDetalle);
                Control.SetEstado(this.db.GetEstadoPelicula(this.Usuario, p));
                Control.SetPortada(p.portada);
                Control.SetObjectId(p._id);
                if (Control.EstadosPelicula == Enums.EstadosPelicula.NO_AGREGADA)
                {
                    continue;
                }
                PanelLista.Controls.Add(Control);
            }
            return true;
        }

        private bool CargarMiListaEstados(Enums.EstadosPelicula estadosPelicula, List<Pelicula> lista)
        {
            List<Pelicula> peliculas = lista;
            PanelLista.Controls.Clear();
            foreach (Pelicula p in peliculas)
            {
                PeliculaControl Control = new PeliculaControl();
                Control.EntrarDetallePelicula += new EventHandler(EntrarPeliculaDetalle);
                Control.SetEstado(this.db.GetEstadoPelicula(this.Usuario, p));
                Control.SetPortada(p.portada);
                Control.SetObjectId(p._id);
                if (Control.EstadosPelicula == estadosPelicula)
                {
                    PanelLista.Controls.Add(Control);
                }

            }
            return true;
        }

        private void EntrarPeliculaDetalle(object sender, EventArgs e)
        {
            this.OrdenYBusqueda(false);
            Control b = (Control)sender;
            PeliculaControl pc = (PeliculaControl)b.Parent;
            this.PeliculaPulsada = this.db.GetPelicula(pc.id);
            ComboBoxEstado.SelectedIndex = (int) pc.EstadosPelicula;
            StringBuilder sb = new StringBuilder();
            PanelListaReparto.Controls.Clear();

            PicBoxPortada.Image = Image.FromFile(Path.GetFilmCoversPath() + this.PeliculaPulsada.portada + ".jpg");
            LblValoracion.Text = this.PeliculaPulsada.valoracion.ToString();
            LblNombre.Text = this.PeliculaPulsada.titulo.ToUpper() + " (" + this.PeliculaPulsada.año + ")";
            foreach (string i in this.PeliculaPulsada.generos)
            {
                sb.Append('|');
                sb.Append(i.ToUpper());
                sb.Append('|');
            }
            LblGenros.Text = sb.ToString();
            TxtBoxDescripcion.Text = this.PeliculaPulsada.descripcion;

            //Director
            RepartoControl rc = new RepartoControl();
            rc.CambiarImagen(this.db.GetReparto(this.PeliculaPulsada.director[0]).imagenPerfil);
            rc.CambiarNombre(this.db.GetReparto(this.PeliculaPulsada.director[0]).nombre);
            rc.EntrarDetalleReparto += new EventHandler(EntrarRepartoDetalleVoid);
            PanelListaReparto.Controls.Add(rc);

            // Null
            PanelListaReparto.Controls.Add(null);

            // Reparto
            foreach (ObjectId r in this.PeliculaPulsada.reparto)
            {
                rc = new RepartoControl();
                rc.CambiarImagen(this.db.GetReparto(r).imagenPerfil);
                rc.CambiarNombre(this.db.GetReparto(r).nombre);
                rc.EntrarDetalleReparto += new EventHandler(EntrarRepartoDetalleVoid);
                PanelListaReparto.Controls.Add(rc);
            }

            


            PanelDetalle.BringToFront();
        }

        private void EntrarRepartoDetalleVoid(object sender, EventArgs e) { }


        private void OrdenYBusqueda(bool block)
        {
            ComboBoxOrdenKey.Enabled =
            ComboBoxOrden.Enabled =
            TxtBoxBarraBusqueda.Enabled = block;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void LblMinimize_MouseEnter(object sender, EventArgs e)
        {
            LblMinimize.BackColor = Color.DarkGray;
        }

        private void LblMinimize_MouseLeave(object sender, EventArgs e)
        {
            LblMinimize.BackColor = Color.FromArgb(48, 47, 49);
        }

        private void LblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelControlVentana_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {

            this.LoginForm.LimpiarInput();
            this.LoginForm.Show();
            Hide();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LblCerrarPanelDetalle_Click(object sender, EventArgs e)
        {
            BtnInicio_Click(sender, e);
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            PanelDetalle.SendToBack();
            this.OrdenYBusqueda(true);
            CargarInicio(this.db.GetListaPeliculasOrdenadas(ComboBoxOrdenKey.SelectedItem.ToString().ToLower(), ComboBoxOrden.SelectedIndex));
        }

        private void BtnMiLista_Click(object sender, EventArgs e)
        {
            PanelDetalle.SendToBack();
            this.OrdenYBusqueda(false);
            CargarMiLista(this.db.GetListaPeliculasOrdenadas(ComboBoxOrdenKey.SelectedItem.ToString().ToLower(), ComboBoxOrden.SelectedIndex));
        }

        private void BtnViendo_Click(object sender, EventArgs e)
        {
            PanelDetalle.SendToBack();
            this.OrdenYBusqueda(false);
            CargarMiListaEstados(Enums.EstadosPelicula.VIENDO, this.db.GetListaPeliculasOrdenadas(ComboBoxOrdenKey.SelectedItem.ToString().ToLower(), ComboBoxOrden.SelectedIndex));
        }

        private void BtnCompletada_Click(object sender, EventArgs e)
        {
            PanelDetalle.SendToBack();
            this.OrdenYBusqueda(false);
            CargarMiListaEstados(Enums.EstadosPelicula.TERMINADA, this.db.GetListaPeliculasOrdenadas(ComboBoxOrdenKey.SelectedItem.ToString().ToLower(), ComboBoxOrden.SelectedIndex));
        }

        private void BtnAbandonada_Click(object sender, EventArgs e)
        {
            PanelDetalle.SendToBack();
            this.OrdenYBusqueda(false);
            CargarMiListaEstados(Enums.EstadosPelicula.ABANDONADA, this.db.GetListaPeliculasOrdenadas(ComboBoxOrdenKey.SelectedItem.ToString().ToLower(), ComboBoxOrden.SelectedIndex));
        }

        private void BtnPlaneada_Click(object sender, EventArgs e)
        {
            PanelDetalle.SendToBack();
            this.OrdenYBusqueda(false);
            CargarMiListaEstados(Enums.EstadosPelicula.PLANEADA, this.db.GetListaPeliculasOrdenadas(ComboBoxOrdenKey.SelectedItem.ToString().ToLower(), ComboBoxOrden.SelectedIndex));
        }

        private void BtnNoAgregada_Click(object sender, EventArgs e)
        {
            PanelDetalle.SendToBack();
            this.OrdenYBusqueda(false);
            CargarMiListaEstados(Enums.EstadosPelicula.NO_AGREGADA, this.db.GetListaPeliculasOrdenadas(ComboBoxOrdenKey.SelectedItem.ToString().ToLower(), ComboBoxOrden.SelectedIndex));
        }

        private void TxtBoxBarraBusqueda_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).SelectAll();
        }

        private void TxtBoxBarraBusqueda_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtBoxBarraBusqueda.Text))
            {
                TxtBoxBarraBusqueda.Text = "BUSCAR PELICULA...";
                CargarInicio(this.db.GetListaPeliculasOrdenadas(ComboBoxOrdenKey.SelectedItem.ToString().ToLower(), ComboBoxOrden.SelectedIndex));
            }
        }

        private void TxtBoxBarraBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtBoxBarraBusqueda.Text))
            {
                CargarInicio(this.db.GetListaPeliculas(TxtBoxBarraBusqueda.Text.Trim()));
            }
            else if (string.IsNullOrWhiteSpace(TxtBoxBarraBusqueda.Text))
            {
                CargarInicio(this.db.GetListaPeliculasOrdenadas(ComboBoxOrdenKey.SelectedItem.ToString().ToLower(), ComboBoxOrden.SelectedIndex));
            }
            else
            {
                CargarInicio(this.db.GetListaPeliculasOrdenadas(ComboBoxOrdenKey.SelectedItem.ToString().ToLower(), ComboBoxOrden.SelectedIndex));
            }
        }

        private void ComboBoxOrden_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarInicio(this.db.GetListaPeliculasOrdenadas(ComboBoxOrdenKey.SelectedItem.ToString().ToLower(), ComboBoxOrden.SelectedIndex));
        }

        private void ComboBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.db.ActualizarEstadoPelicula(this.Usuario, this.PeliculaPulsada, this.EstadoOrigen, ComboBoxEstado.Text.ToLower());
        }

        private void ComboBoxEstado_DropDown(object sender, EventArgs e)
        {
            this.EstadoOrigen = ComboBoxEstado.Text.ToLower();
        }

        
    }
}

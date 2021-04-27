using MDbM.Clases;
using MDbM.Properties;
using MDbM.UI.Clases;
using MDbM.UI.LoginUI;
using MDbM.UI.MongoDB;
using PeliculaCtrl;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
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
                PanelLista.Controls.Add(Control);
            }
        }

        private bool CargarMiLista()
        {
            List<Pelicula> peliculas = this.db.GetListaPeliculas();
            PanelLista.Controls.Clear();
            foreach (Pelicula p in peliculas)
            {
                PeliculaControl Control = new PeliculaControl();
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

        private bool CargarMiListaEstados(Enums.EstadosPelicula estadosPelicula)
        {
            List<Pelicula> peliculas = this.db.GetListaPeliculas();
            PanelLista.Controls.Clear();
            foreach (Pelicula p in peliculas)
            {
                PeliculaControl Control = new PeliculaControl();
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
            PanelDetalle.BringToFront();
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
            PanelDetalle.SendToBack();
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            CargarInicio(this.db.GetListaPeliculasOrdenadas(ComboBoxOrdenKey.SelectedItem.ToString().ToLower(), ComboBoxOrden.SelectedIndex));
        }

        private void BtnMiLista_Click(object sender, EventArgs e)
        {
            CargarMiLista();
        }

        private void BtnViendo_Click(object sender, EventArgs e)
        {
            CargarMiListaEstados(Enums.EstadosPelicula.VIENDO);
        }

        private void BtnCompletada_Click(object sender, EventArgs e)
        {
            CargarMiListaEstados(Enums.EstadosPelicula.TERMINADA);
        }

        private void BtnAbandonada_Click(object sender, EventArgs e)
        {
            CargarMiListaEstados(Enums.EstadosPelicula.ABANDONADA);
        }

        private void BtnPlaneada_Click(object sender, EventArgs e)
        {
            CargarMiListaEstados(Enums.EstadosPelicula.PLANEADA);
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
    }
}

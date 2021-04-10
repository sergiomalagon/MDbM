using MDbM.Clases;
using MDbM.UI.Clases;
using MDbM.UI.MongoDB;
using MongoDB.Bson;
using PeliculaCtrl;
using RepartoCtrl;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Path = MDbM.Clases.Path;

namespace MDbM.UI.AdminUI
{
    public partial class Admin : Form
    {
        private readonly Mongo db = new Mongo();

        private Pelicula PeliculaPulsada;
        private Reparto RepartoPulsado;
        private bool IsCrearPelicula;
        private bool IsCrearReparto;

        private ServiceController ServiceController;


        public Admin()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            this.ServiceController = new ServiceController();
            this.ServiceController.ServiceName = "MongoDB";

            ComprobarEstadoServicio();

        }

        private void ComprobarEstadoServicio()
        {
            if (this.ServiceController.Status == ServiceControllerStatus.Running)
            {
                LblEstadoServicio.Text = "RUNNING";
                LblEstadoServicio.ForeColor = Color.GreenYellow;
                BtnIniciarServicio.Enabled = false;
                BtnPararServicio.Enabled = true;
                verPeliculas.Enabled =
                crearPeliculas.Enabled =
                verReparto.Enabled =
                crearReparto.Enabled = true;
            }
            else
            {
                LblEstadoServicio.Text = "STOPPED";
                LblEstadoServicio.ForeColor = Color.Red;
                BtnIniciarServicio.Enabled = true;
                BtnPararServicio.Enabled = false;
                verPeliculas.Enabled = 
                crearPeliculas.Enabled = 
                verReparto.Enabled = 
                crearReparto.Enabled = false;
            }
        }

        private void IniciarServicio()
        {
            try
            {
                this.ServiceController.Start();
                this.ServiceController.WaitForStatus(ServiceControllerStatus.Running);
                ComprobarEstadoServicio();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Could not start the service.");
                Console.WriteLine(e.Message);
            }
        }

        private void PararServicio()
        {
            try
            {
                this.ServiceController.Stop();
                this.ServiceController.WaitForStatus(ServiceControllerStatus.Stopped);
                ComprobarEstadoServicio();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Could not stop the service.");
                Console.WriteLine(e.Message);
            }
        }

        private void BtnPararServicio_Click(object sender, EventArgs e)
        {
            PararServicio();
        }

        private void BtnIniciarServicio_Click(object sender, EventArgs e)
        {
            IniciarServicio();
            this.db.GetConexion();
        }


        private void Inicio_Click(object sender, EventArgs e)
        {
            adminPanel.BringToFront();
        }


        private void CargarEditorPeliculas()
        {
            if (!this.IsCrearPelicula)
            {
                try
                {
                    PicBoxPortada.Image = Image.FromFile(Path.GetFilmCoversPath() + this.PeliculaPulsada.portada + ".jpg");
                }
                catch (FileNotFoundException)
                {
                    PicBoxPortada.Image = null;
                }
                TxtBoxValoracion.Text = this.PeliculaPulsada.valoracion.ToString();
                TxtBoxTitulo.Text = this.PeliculaPulsada.titulo;
                TxtBoxDescripcion.Text = this.PeliculaPulsada.descripcion;
                TxtBoxAño.Text = this.PeliculaPulsada.año.ToString();

                foreach (Reparto r in this.db.GetListaReparto())
                {
                    CBoxDirector.Items.Add(r.nombre);
                    CBoxReparto1.Items.Add(r.nombre);
                    CBoxReparto2.Items.Add(r.nombre);
                    CBoxReparto3.Items.Add(r.nombre);
                }

                try
                {
                    CBoxDirector.Text = this.db.GetReparto(this.PeliculaPulsada.director[0]).nombre;
                    PicBoxDirector.Image = Image.FromFile(Path.GetPeoplePath() + this.db.GetReparto(this.PeliculaPulsada.director[0]).imagenPerfil + ".jpg");
                }
                catch (Exception)
                {
                    CBoxDirector.Text = "";
                    PicBoxDirector.Image = null;
                }
                try
                {
                    CBoxReparto1.Text = this.db.GetReparto(this.PeliculaPulsada.reparto[0]).nombre;
                    PicBoxReparto1.Image = Image.FromFile(Path.GetPeoplePath() + this.db.GetReparto(this.PeliculaPulsada.reparto[0]).imagenPerfil + ".jpg");
                }
                catch (Exception)
                {
                    CBoxReparto1.Text = "";
                    PicBoxReparto1.Image = null;
                }

                try
                {
                    CBoxReparto2.Text = this.db.GetReparto(this.PeliculaPulsada.reparto[1]).nombre;
                    PicBoxReparto2.Image = Image.FromFile(Path.GetPeoplePath() + this.db.GetReparto(this.PeliculaPulsada.reparto[1]).imagenPerfil + ".jpg");
                }
                catch (Exception)
                {
                    CBoxReparto2.Text = "";
                    PicBoxReparto2.Image = null;
                }

                try
                {
                    CBoxReparto3.Text = this.db.GetReparto(this.PeliculaPulsada.reparto[2]).nombre;
                    PicBoxReparto3.Image = Image.FromFile(Path.GetPeoplePath() + this.db.GetReparto(this.PeliculaPulsada.reparto[2]).imagenPerfil + ".jpg");
                }
                catch (Exception)
                {
                    CBoxReparto3.Text = "";
                    PicBoxReparto3.Image = null;
                }

                ListBoxGenerosSeleccionados.Items.Clear();
                foreach (string genero in this.PeliculaPulsada.generos)
                {
                    ListBoxGenerosSeleccionados.Items.Add(genero.ToUpper());
                }
                BtnEliminarPelicula.Visible = true;

                editarPelicula.BringToFront();
            }
            else
            {
                TxtBoxValoracion.Text = "";
                TxtBoxTitulo.Text = "";
                TxtBoxDescripcion.Text = "";
                TxtBoxAño.Text = "";

                PicBoxPortada.Image = null;
                PicBoxDirector.Image = null;
                PicBoxReparto1.Image = null;
                PicBoxReparto2.Image = null;
                PicBoxReparto3.Image = null;

                CBoxDirector.Items.Clear();
                CBoxReparto1.Items.Clear();
                CBoxReparto2.Items.Clear();
                CBoxReparto3.Items.Clear();

                foreach (Reparto r in this.db.GetListaReparto())
                {
                    CBoxDirector.Items.Add(r.nombre);
                    CBoxReparto1.Items.Add(r.nombre);
                    CBoxReparto2.Items.Add(r.nombre);
                    CBoxReparto3.Items.Add(r.nombre);
                }
                ListBoxGenerosSeleccionados.Items.Clear();

                BtnEliminarPelicula.Visible = false;
                editarPelicula.BringToFront();
            }

        }


        private bool CargarEditorReparto()
        {
            if (!this.IsCrearReparto)
            {
                PicBoxPortadaRetrato.Image = Image.FromFile(Path.GetPeoplePath() + this.RepartoPulsado.imagenPerfil + ".jpg");
                TxtBoxNombreReparto.Text = this.RepartoPulsado.nombre;
                BtnEliminarReparto.Visible = true;

                editarReparto.BringToFront();
                return true;
            }

            PicBoxPortadaRetrato.Image = null;
            TxtBoxNombreReparto.Text = "";
            BtnEliminarReparto.Visible = false;

            editarReparto.BringToFront();

            return true;
        }


        private void VerPeliculas_Click(object sender, EventArgs e)
        {

            flowLayoutPanel.Controls.Clear();
            List<Pelicula> peliculas = this.db.GetListaPeliculas();
            foreach (Pelicula p in peliculas)
            {
                PeliculaControl control = new PeliculaControl();
                control.EntrarDetallePelicula += new EventHandler(EntrarDetallePelicula);
                control.SetEstado(Enums.EstadosPelicula.NO_AGREGADA);
                control.SetPortada(p.portada);
                control.SetObjectId(p._id);
                flowLayoutPanel.Controls.Add(control);
            }
            flowLayoutPanel.BringToFront();
        }

        private void CrearPeliculas_Click(object sender, EventArgs e)
        {
            this.IsCrearPelicula = true;
            CargarEditorPeliculas();
        }

        private void EntrarDetallePelicula(object sender, EventArgs e)
        {
            this.IsCrearPelicula = false;
            Control b = (Control)sender;
            PeliculaControl pc = (PeliculaControl)b.Parent;
            this.PeliculaPulsada = this.db.GetPelicula(pc.id);
            CargarEditorPeliculas();
        }

        private void VerReparto_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            List<Reparto> reparto = this.db.GetListaReparto();
            foreach (Reparto r in reparto)
            {
                RepartoControl control = new RepartoControl();
                control.EntrarDetalleReparto += new EventHandler(EntrarDetalleReparto);
                control.CambiarImagen(r.imagenPerfil);
                control.CambiarNombre(r.nombre);
                control.SetObjectId(r._id);
                flowLayoutPanel.Controls.Add(control);
            }
            flowLayoutPanel.BringToFront();
        }

        private void EntrarDetalleReparto(object sender, EventArgs e)
        {
            this.IsCrearReparto = false;
            Control b = (Control)sender;
            RepartoControl rc = (RepartoControl)b.Parent;
            this.RepartoPulsado = this.db.GetReparto(rc.id);
            CargarEditorReparto();
        }


        private void BtnCambiarPortada_Click(object sender, EventArgs e)
        {
            Image File;
            OpenFileDialog f = new OpenFileDialog
            {
                Filter = "Image files (*.jpg, *.png) | *.jpg; *.png"
            };

            if (f.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(f.FileName);
                if (PicBoxPortada.Image != null)
                {
                    PicBoxPortada.Image.Dispose();
                    PicBoxPortada.Image = null;
                }
                PicBoxPortada.Image = File;
            }
        }

        private void ListBoxTodosGeneros_DoubleClick(object sender, EventArgs e)
        {
            var GeneroSeleccionado = ListBoxTodosGeneros.SelectedItem;
            if (!ListBoxGenerosSeleccionados.Items.Contains(GeneroSeleccionado))
            {
                ListBoxGenerosSeleccionados.Items.Add(GeneroSeleccionado);
            }
        }

        private void ListBoxGenerosSeleccionados_DoubleClick(object sender, EventArgs e)
        {
            var GeneroSeleccionado = ListBoxGenerosSeleccionados.SelectedItem;
            ListBoxGenerosSeleccionados.Items.Remove(GeneroSeleccionado);
        }

        private void CBoxDirector_SelectedIndexChanged(object sender, EventArgs e)
        {
            Image imagen = Image.FromFile(Path.GetPeoplePath() + this.db.GetReparto(CBoxDirector.SelectedItem.ToString()).imagenPerfil + ".jpg");
            PicBoxDirector.Image = imagen;
        }

        private void CBoxReparto1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Image imagen = Image.FromFile(Path.GetPeoplePath() + this.db.GetReparto(CBoxReparto1.SelectedItem.ToString()).imagenPerfil + ".jpg");
            PicBoxReparto1.Image = imagen;
        }

        private void CBoxReparto2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Image imagen = Image.FromFile(Path.GetPeoplePath() + this.db.GetReparto(CBoxReparto2.SelectedItem.ToString()).imagenPerfil + ".jpg");
            PicBoxReparto2.Image = imagen;
        }

        private void CBoxReparto3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Image imagen = Image.FromFile(Path.GetPeoplePath() + this.db.GetReparto(CBoxReparto3.SelectedItem.ToString()).imagenPerfil + ".jpg");
            PicBoxReparto3.Image = imagen;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {

            List<ObjectId> lista = new List<ObjectId>();
            List<string> listaGeneros = new List<string>();
            Pelicula pelicula = new Pelicula
            {
                valoracion = double.Parse(TxtBoxValoracion.Text),
                año = Int32.Parse(TxtBoxAño.Text),
                descripcion = TxtBoxDescripcion.Text,
                titulo = TxtBoxTitulo.Text,
                portada = Path.GenerarUrlImagen(Path.GetCover(), TxtBoxTitulo.Text.Trim()),
            };

            lista.Add(this.db.GetReparto(CBoxDirector.SelectedItem.ToString())._id);
            pelicula.director = lista.ToArray();
            lista.Clear();


            lista.Add(this.db.GetReparto(CBoxReparto1.SelectedItem.ToString())._id);
            lista.Add(this.db.GetReparto(CBoxReparto2.SelectedItem.ToString())._id);
            lista.Add(this.db.GetReparto(CBoxReparto3.SelectedItem.ToString())._id);
            pelicula.reparto = lista.ToArray();
            lista.Clear();


            foreach (string item in ListBoxGenerosSeleccionados.Items)
            {
                listaGeneros.Add(item.ToLower());
            }

            pelicula.generos = listaGeneros.ToArray();
            listaGeneros.Clear();

            try
            {
                PicBoxPortada.Image.Save(Path.GetFilmCoversPath() + Path.GenerarUrlImagen(Path.GetCover(), TxtBoxTitulo.Text.Trim()) + ".jpg");
            }
            catch (Exception) { }


            if (!this.IsCrearPelicula)
            {
                pelicula._id = this.PeliculaPulsada._id;
                this.db.ActualizarPelicula(pelicula);
                Console.WriteLine("Pelicula actualizada");
            }
            else
            {
                this.db.CrearPelicula(pelicula);
                Console.WriteLine("Pelicula creada");
            }

            VerPeliculas_Click(sender, e);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            VerPeliculas_Click(sender, e);
        }

        private void CrearReparto_Click(object sender, EventArgs e)
        {
            this.IsCrearReparto = true;
            CargarEditorReparto();
        }

        private void BtnCambiarImagenReparto_Click(object sender, EventArgs e)
        {
            Image File;
            OpenFileDialog f = new OpenFileDialog
            {
                Filter = "Image files (*.jpg, *.png) | *.jpg; *.png"
            };

            if (f.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(f.FileName);
                if (PicBoxPortadaRetrato.Image != null)
                {
                    PicBoxPortadaRetrato.Image.Dispose();
                    PicBoxPortadaRetrato.Image = null;
                }
                PicBoxPortadaRetrato.Image = File;
            }
        }

        private void BtnAceptarReparto_Click(object sender, EventArgs e)
        {
            Reparto Reparto = new Reparto
            {
                imagenPerfil = Path.GenerarUrlImagen(Path.GetPeople(), TxtBoxNombreReparto.Text.Trim()),
                nombre = TxtBoxNombreReparto.Text.Trim()
            };

            try
            {
                PicBoxPortadaRetrato.Image.Save(Path.GetPeoplePath() + Reparto.imagenPerfil + ".jpg");
            }
            catch (Exception) { }

            if (!this.IsCrearReparto)
            {
                Reparto._id = this.RepartoPulsado._id;
                this.db.ActualizarReparto(Reparto);
            }
            else
            {
                this.db.CrearReparto(Reparto);
            }
            VerReparto_Click(sender, e);

        }

        private void BtnCancelarReparto_Click(object sender, EventArgs e)
        {
            VerReparto_Click(sender, e);
        }

        private void BtnEliminarReparto_Click(object sender, EventArgs e)
        {
            this.db.EliminarReparto(this.RepartoPulsado);
            VerReparto_Click(sender, e);
        }

        private void BtnEliminarPelicula_Click(object sender, EventArgs e)
        {
            this.db.EliminarPelicula(this.PeliculaPulsada);
            VerPeliculas_Click(sender, e);
        }


    }
}

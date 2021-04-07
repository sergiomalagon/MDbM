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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Path = MDbM.Clases.Path;

namespace MDbM.UI.AdminUI
{
    public partial class Admin : Form
    {
        internal Mongo db = new Mongo();

        internal Peliculas PeliculaPulsada;
        internal Reparto RepartoPulsado;
        internal bool IsCrearPelicula;
        internal bool IsPortadaNueva;

        public Admin()
        {
            InitializeComponent();
            this.db.GetConexion();
        }

        private void Init()
        {

        }

        private void CargarEditorPeliculas()
        {
            if (!this.IsCrearPelicula)
            {
                try
                {
                    picBoxPortada.Image = Image.FromFile(Path.GetFilmCoversPath() + this.PeliculaPulsada.portada + ".jpg");
                }
                catch (FileNotFoundException)
                {
                    picBoxPortada.Image = null;
                }
                txtBoxValoracion.Text = this.PeliculaPulsada.valoracion.ToString();
                txtBoxTitulo.Text = this.PeliculaPulsada.titulo;
                txtBoxDescripcion.Text = this.PeliculaPulsada.descripcion;
                txtBoxAño.Text = this.PeliculaPulsada.año.ToString();

                foreach (Reparto r in this.db.GetListaReparto())
                {
                    cBoxDirector.Items.Add(r.nombre);
                    cBoxReparto1.Items.Add(r.nombre);
                    cBoxReparto2.Items.Add(r.nombre);
                    cBoxReparto3.Items.Add(r.nombre);
                }

                cBoxDirector.Text = this.db.GetReparto(this.PeliculaPulsada.director[0]).nombre;
                picBoxDirector.Image = Image.FromFile(Path.GetPeoplePath() + this.db.GetReparto(this.PeliculaPulsada.director[0]).imagenPerfil + ".jpg");

                cBoxReparto1.Text = this.db.GetReparto(this.PeliculaPulsada.reparto[0]).nombre;
                picBoxReparto1.Image = Image.FromFile(Path.GetPeoplePath() + this.db.GetReparto(this.PeliculaPulsada.reparto[0]).imagenPerfil + ".jpg");

                cBoxReparto2.Text = this.db.GetReparto(this.PeliculaPulsada.reparto[1]).nombre;
                picBoxReparto2.Image = Image.FromFile(Path.GetPeoplePath() + this.db.GetReparto(this.PeliculaPulsada.reparto[1]).imagenPerfil + ".jpg");

                cBoxReparto3.Text = this.db.GetReparto(this.PeliculaPulsada.reparto[2]).nombre;
                picBoxReparto3.Image = Image.FromFile(Path.GetPeoplePath() + this.db.GetReparto(this.PeliculaPulsada.reparto[2]).imagenPerfil + ".jpg");

                listBoxGenerosSeleccionados.Items.Clear();
                foreach (string genero in this.PeliculaPulsada.generos)
                {
                    listBoxGenerosSeleccionados.Items.Add(genero.ToUpper());
                }

                editarPelicula.BringToFront();
            }
            else
            {
                txtBoxValoracion.Text = "";
                txtBoxTitulo.Text = "";
                txtBoxDescripcion.Text = "";
                txtBoxAño.Text = "";

                picBoxPortada.Image = null;
                picBoxDirector.Image = null;
                picBoxReparto1.Image = null;
                picBoxReparto2.Image = null;
                picBoxReparto3.Image = null;

                cBoxDirector.Items.Clear();
                cBoxReparto1.Items.Clear();
                cBoxReparto2.Items.Clear();
                cBoxReparto3.Items.Clear();

                foreach (Reparto r in this.db.GetListaReparto())
                {
                    cBoxDirector.Items.Add(r.nombre);
                    cBoxReparto1.Items.Add(r.nombre);
                    cBoxReparto2.Items.Add(r.nombre);
                    cBoxReparto3.Items.Add(r.nombre);
                }
                listBoxGenerosSeleccionados.Items.Clear();

                editarPelicula.BringToFront();
            }

        }

        private string GenerarUrlPortada(string nombre)
        {
            string[] aux = nombre.Split(' ');
            StringBuilder sb = new StringBuilder();
            sb.Append("cover");
            foreach (string a in aux)
            {
                sb.Append("_");
                sb.Append(a.ToLower());
            }
            return sb.ToString();

        }


        private void verPeliculas_Click(object sender, EventArgs e)
        {

            flowLayoutPanel.Controls.Clear();
            List<Peliculas> peliculas = this.db.GetListaPeliculas();
            foreach (Peliculas p in peliculas)
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

        private void crearPeliculas_Click(object sender, EventArgs e)
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

        private void verReparto_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            List<Reparto> reparto = this.db.GetListaReparto();
            foreach (Reparto r in reparto)
            {
                RepartoControl control = new RepartoControl();
                control.CambiarImagen(r.imagenPerfil);
                control.CambiarNombre(r.nombre);
                flowLayoutPanel.Controls.Add(control);
            }
            flowLayoutPanel.BringToFront();
        }

        private void inicio_Click(object sender, EventArgs e)
        {
            adminPanel.BringToFront();
        }

        private void btnCambiarPortada_Click(object sender, EventArgs e)
        {
            Image File;
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Image files (*.jpg, *.png) | *.jpg; *.png";

            if (f.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(f.FileName);
                if (picBoxPortada.Image != null)
                {
                    picBoxPortada.Image.Dispose();
                    picBoxPortada.Image = null;
                }
                picBoxPortada.Image = File;
                this.IsPortadaNueva = true;
            }
        }

        private void listBoxTodosGeneros_DoubleClick(object sender, EventArgs e)
        {
            var GeneroSeleccionado = listBoxTodosGeneros.SelectedItem;
            if (!listBoxGenerosSeleccionados.Items.Contains(GeneroSeleccionado))
            {
                listBoxGenerosSeleccionados.Items.Add(GeneroSeleccionado);
            }
        }

        private void listBoxGenerosSeleccionados_DoubleClick(object sender, EventArgs e)
        {
            var GeneroSeleccionado = listBoxGenerosSeleccionados.SelectedItem;
            listBoxGenerosSeleccionados.Items.Remove(GeneroSeleccionado);
        }

        private void cBoxDirector_SelectedIndexChanged(object sender, EventArgs e)
        {
            Image imagen = Image.FromFile(Path.GetPeoplePath() + this.db.GetReparto(cBoxDirector.SelectedItem.ToString()).imagenPerfil + ".jpg");
            picBoxDirector.Image = imagen;
        }

        private void cBoxReparto1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Image imagen = Image.FromFile(Path.GetPeoplePath() + this.db.GetReparto(cBoxReparto1.SelectedItem.ToString()).imagenPerfil + ".jpg");
            picBoxReparto1.Image = imagen;
        }

        private void cBoxReparto2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Image imagen = Image.FromFile(Path.GetPeoplePath() + this.db.GetReparto(cBoxReparto2.SelectedItem.ToString()).imagenPerfil + ".jpg");
            picBoxReparto2.Image = imagen;
        }

        private void cBoxReparto3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Image imagen = Image.FromFile(Path.GetPeoplePath() + this.db.GetReparto(cBoxReparto3.SelectedItem.ToString()).imagenPerfil + ".jpg");
            picBoxReparto3.Image = imagen;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
                List<ObjectId> lista = new List<ObjectId>();
                List<string> listaGeneros = new List<string>();
                Peliculas pelicula = new Peliculas();

                pelicula.valoracion = double.Parse(txtBoxValoracion.Text);
                pelicula.año = Int32.Parse(txtBoxAño.Text);
                lista.Add(this.db.GetReparto(cBoxDirector.SelectedItem.ToString())._id);
                pelicula.director = lista.ToArray();
                lista.Clear();

                pelicula.portada = GenerarUrlPortada(txtBoxTitulo.Text.Trim());

                lista.Add(this.db.GetReparto(cBoxReparto1.SelectedItem.ToString())._id);
                lista.Add(this.db.GetReparto(cBoxReparto2.SelectedItem.ToString())._id);
                lista.Add(this.db.GetReparto(cBoxReparto3.SelectedItem.ToString())._id);

                pelicula.reparto = lista.ToArray();
                lista.Clear();
                pelicula.descripcion = txtBoxDescripcion.Text;
                pelicula.titulo = txtBoxTitulo.Text;

                foreach (string item in listBoxGenerosSeleccionados.Items)
                {
                    listaGeneros.Add(item.ToLower());
                }
                pelicula.generos = listaGeneros.ToArray();
                listaGeneros.Clear();

            try
            {
                picBoxPortada.Image.Save(Path.GetFilmCoversPath() + GenerarUrlPortada(txtBoxTitulo.Text.Trim()) + ".jpg");
            }
            catch (Exception){}
            

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

            

            verPeliculas_Click(sender, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            verPeliculas_Click(sender, e);
        }


    }
}

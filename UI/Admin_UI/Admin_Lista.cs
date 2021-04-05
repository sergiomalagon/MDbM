using MDbM.Clases;
using MDbM.UI.Clases;
using MDbM.UI.MongoDB;
using PeliculaCtrl;
using RepartoCtrl;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDbM.UI.AdminUI
{
    public partial class Admin : Form
    {
        internal Mongo db = new Mongo();

        internal Peliculas PeliculaPulsada;
        internal Reparto RepartoPulsado;


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
            picBoxPortada.Image = Image.FromFile(Path.GetFilmCoversPath() + this.PeliculaPulsada.portada + ".jpg");
            txtBoxValoracion.Text = this.PeliculaPulsada.valoracion.ToString();
            txtBoxTitulo.Text = this.PeliculaPulsada.titulo;
            txtBoxDescripcion.Text = this.PeliculaPulsada.descripcion;

            foreach(Reparto r in this.db.GetListaReparto())
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



            editarPelicula.BringToFront();
        }

        private void verPeliculas_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            List<Peliculas> peliculas = this.db.GetListaPeliculas();
            foreach(Peliculas p in peliculas)
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

        private void EntrarDetallePelicula(object sender, EventArgs e)
        {
            Control b = (Control)sender;
            PeliculaControl pc =(PeliculaControl) b.Parent;
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
                picBoxDirector.Image = File;
            }
        }
    }
}

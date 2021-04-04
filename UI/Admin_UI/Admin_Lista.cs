using MDbM.UI.Clases;
using MDbM.UI.MongoDB;
using PeliculaCtrl;
using RepartoCtrl;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDbM.UI.AdminUI
{
    public partial class Admin : Form
    {
        Mongo db = new Mongo();
        public Admin()
        {
            this.db.GetConexion();
            InitializeComponent();
        }

        private void verPeliculas_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            List<Peliculas> peliculas = this.db.GetListaPeliculas();
            foreach(Peliculas p in peliculas)
            {
                PeliculaControl control = new PeliculaControl();
                control.SetEstado(Enums.EstadosPelicula.NO_AGREGADA);
                control.SetPortada(p.portada);
                flowLayoutPanel.Controls.Add(control);
            }
            flowLayoutPanel.BringToFront();
        }

        private void verReparto_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.Add(new RepartoControl());
            flowLayoutPanel.Controls.Add(new RepartoControl());
            flowLayoutPanel.Controls.Add(new RepartoControl());
            flowLayoutPanel.Controls.Add(new RepartoControl());
            flowLayoutPanel.BringToFront();
        }

        private void inicio_Click(object sender, EventArgs e)
        {
            adminPanel.BringToFront();
        }
    }
}

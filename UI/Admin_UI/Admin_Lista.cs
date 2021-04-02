using PeliculaCtrl;
using RepartoCtrl;
using System;
using System.Windows.Forms;

namespace MDbM.UI.AdminUI
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();

            flowLayoutPanel1.Controls.Add(new RepartoControl());
            flowLayoutPanel1.Controls.Add(new RepartoControl());
            flowLayoutPanel1.Controls.Add(new RepartoControl());
            flowLayoutPanel1.Controls.Add(new RepartoControl());

            flowLayoutPanel2.Controls.Add(new PeliculaControl());
            flowLayoutPanel2.Controls.Add(new PeliculaControl());
            flowLayoutPanel2.Controls.Add(new PeliculaControl());
            flowLayoutPanel2.Controls.Add(new PeliculaControl());
        }

        private void verRepartoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.BringToFront();
            flowLayoutPanel1.BringToFront();
        }

        private void verPeliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.BringToFront();
            flowLayoutPanel2.BringToFront();
        }
    }
}

using MDbM.UI.Clases;
using RoundLbl;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PeliculaCtrl
{
    public class PeliculaControl : UserControl
    {
        public event EventHandler EntrarDetallePelicula;
        private RoundLabel roundLblFilmStatus;
        private PictureBox pictureBox1;

        public PeliculaControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.pictureBox1 = new PictureBox();
            this.roundLblFilmStatus = new RoundLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // roundLblFilmStatus
            // 
            this.roundLblFilmStatus._BackColor = System.Drawing.Color.Red;
            this.roundLblFilmStatus.BackColor = System.Drawing.Color.Transparent;
            this.roundLblFilmStatus.Location = new System.Drawing.Point(5, 203);
            this.roundLblFilmStatus.Name = "roundLblFilmStatus";
            this.roundLblFilmStatus.Size = new System.Drawing.Size(160, 34);
            this.roundLblFilmStatus.TabIndex = 1;
            this.roundLblFilmStatus.Click += new System.EventHandler(this.roundLblFilmStatus_Click);
            // 
            // PeliculaControl
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.roundLblFilmStatus);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PeliculaControl";
            this.Size = new System.Drawing.Size(170, 242);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        public void CambiarEstado(Enums.EstadosPelicula Estados)
        {

            switch (Estados)
            {
                case Enums.EstadosPelicula.VIENDO:
                    roundLblFilmStatus._BackColor = Color.FromArgb(0, 255, 0);
                    break;
                case Enums.EstadosPelicula.TERMINADA:
                    roundLblFilmStatus._BackColor = Color.FromArgb(0, 0, 255);
                    break;
                case Enums.EstadosPelicula.ABANDONADA:
                    roundLblFilmStatus._BackColor = Color.FromArgb(182, 60, 60);
                    break;
                case Enums.EstadosPelicula.PLANEADA:
                    roundLblFilmStatus._BackColor = Color.FromArgb(207, 209, 184);
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EntrarDetallePelicula(sender, null);
        }

        private void roundLblFilmStatus_Click(object sender, EventArgs e)
        {
            EntrarDetallePelicula(sender, null);
        }
    }
}

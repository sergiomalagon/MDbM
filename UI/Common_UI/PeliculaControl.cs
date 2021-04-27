using MDbM.Clases;
using MDbM.UI.Clases;
using MongoDB.Bson;
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
        private PictureBox portadaPelicula;
        public ObjectId id;
        public Enums.EstadosPelicula EstadosPelicula;


        public PeliculaControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.portadaPelicula = new System.Windows.Forms.PictureBox();
            this.roundLblFilmStatus = new RoundLbl.RoundLabel();
            ((System.ComponentModel.ISupportInitialize)(this.portadaPelicula)).BeginInit();
            this.SuspendLayout();
            // 
            // portadaPelicula
            // 
            this.portadaPelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.portadaPelicula.Location = new System.Drawing.Point(5, 5);
            this.portadaPelicula.Name = "portadaPelicula";
            this.portadaPelicula.Size = new System.Drawing.Size(160, 195);
            this.portadaPelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.portadaPelicula.TabIndex = 0;
            this.portadaPelicula.TabStop = false;
            this.portadaPelicula.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // roundLblFilmStatus
            // 
            this.roundLblFilmStatus._BackColor = System.Drawing.Color.WhiteSmoke;
            this.roundLblFilmStatus.BackColor = System.Drawing.Color.Transparent;
            this.roundLblFilmStatus.Location = new System.Drawing.Point(5, 203);
            this.roundLblFilmStatus.Name = "roundLblFilmStatus";
            this.roundLblFilmStatus.Size = new System.Drawing.Size(160, 34);
            this.roundLblFilmStatus.TabIndex = 1;
            this.roundLblFilmStatus.Click += new System.EventHandler(this.RoundLblFilmStatus_Click);
            // 
            // PeliculaControl
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.roundLblFilmStatus);
            this.Controls.Add(this.portadaPelicula);
            this.Name = "PeliculaControl";
            this.Size = new System.Drawing.Size(170, 242);
            ((System.ComponentModel.ISupportInitialize)(this.portadaPelicula)).EndInit();
            this.ResumeLayout(false);

        }

        public void SetEstado(Enums.EstadosPelicula Estados)
        {

            switch (Estados)
            {
                case Enums.EstadosPelicula.VIENDO:
                    roundLblFilmStatus._BackColor = Color.FromArgb(0, 255, 0);
                    this.EstadosPelicula = Enums.EstadosPelicula.VIENDO;
                    break;
                case Enums.EstadosPelicula.TERMINADA:
                    roundLblFilmStatus._BackColor = Color.FromArgb(0, 0, 255);
                    this.EstadosPelicula = Enums.EstadosPelicula.TERMINADA;
                    break;
                case Enums.EstadosPelicula.ABANDONADA:
                    roundLblFilmStatus._BackColor = Color.FromArgb(182, 60, 60);
                    this.EstadosPelicula = Enums.EstadosPelicula.ABANDONADA;
                    break;
                case Enums.EstadosPelicula.PLANEADA:
                    roundLblFilmStatus._BackColor = Color.FromArgb(207, 209, 184);
                    this.EstadosPelicula = Enums.EstadosPelicula.PLANEADA;
                    break;
                case Enums.EstadosPelicula.NO_AGREGADA:
                    roundLblFilmStatus._BackColor = Color.WhiteSmoke;
                    this.EstadosPelicula = Enums.EstadosPelicula.NO_AGREGADA;
                    break;
            }
        }

        public void SetPortada(string UrlPortada)
        {
            portadaPelicula.ImageLocation = Path.GetFilmCoversPath() + UrlPortada + ".jpg";
        }

        public void SetObjectId(ObjectId id)
        {
            this.id = id;
        }


        private void PictureBox1_Click(object sender, EventArgs e)
        {
            EntrarDetallePelicula(sender, null);
        }

        private void RoundLblFilmStatus_Click(object sender, EventArgs e)
        {
            EntrarDetallePelicula(sender, null);
        }
    }
}

﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace RepartoCtrl
{
    public class RepartoControl : UserControl
    {

        private Label lblRepartoName;
        private PictureBox picBoxRepartoImagen;
        internal static string PATH_IMG_PERFIL = "..\\..\\Resources\\People\\";

        public RepartoControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.picBoxRepartoImagen = new System.Windows.Forms.PictureBox();
            this.lblRepartoName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRepartoImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxRepartoImagen
            // 
            this.picBoxRepartoImagen.BackColor = System.Drawing.Color.LightCoral;
            this.picBoxRepartoImagen.Location = new System.Drawing.Point(3, 3);
            this.picBoxRepartoImagen.Name = "picBoxRepartoImagen";
            this.picBoxRepartoImagen.Size = new System.Drawing.Size(144, 207);
            this.picBoxRepartoImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxRepartoImagen.TabIndex = 0;
            this.picBoxRepartoImagen.TabStop = false;
            // 
            // lblRepartoName
            // 
            this.lblRepartoName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(85)))));
            this.lblRepartoName.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepartoName.ForeColor = System.Drawing.Color.White;
            this.lblRepartoName.Location = new System.Drawing.Point(3, 213);
            this.lblRepartoName.Name = "lblRepartoName";
            this.lblRepartoName.Size = new System.Drawing.Size(144, 27);
            this.lblRepartoName.TabIndex = 1;
            this.lblRepartoName.Text = "label1";
            this.lblRepartoName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RepartoControl
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblRepartoName);
            this.Controls.Add(this.picBoxRepartoImagen);
            this.Name = "RepartoControl";
            this.Size = new System.Drawing.Size(150, 246);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRepartoImagen)).EndInit();
            this.ResumeLayout(false);

        }



        internal void CambiarImagen(string image)
        {
            picBoxRepartoImagen.ImageLocation = PATH_IMG_PERFIL + image + ".jpg";
        }

        internal void CambiarNombre(String nombre)
        {
            lblRepartoName.Text = nombre;
        }
    }


}

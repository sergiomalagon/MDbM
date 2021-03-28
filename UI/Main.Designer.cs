
namespace MDbM.UI
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControlVentana = new System.Windows.Forms.Panel();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.lblSalir = new System.Windows.Forms.Label();
            this.lblListaCompleted = new System.Windows.Forms.Label();
            this.lblListaDropped = new System.Windows.Forms.Label();
            this.lblListaPlantToWatch = new System.Windows.Forms.Label();
            this.lblListaWatching = new System.Windows.Forms.Label();
            this.lblListaGeneral = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.imgPerfil1 = new ImagenPerfil.ImgPerfil();
            this.panelControlVentana.SuspendLayout();
            this.panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlVentana
            // 
            this.panelControlVentana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.panelControlVentana.Controls.Add(this.lblMinimize);
            this.panelControlVentana.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlVentana.Location = new System.Drawing.Point(0, 0);
            this.panelControlVentana.Name = "panelControlVentana";
            this.panelControlVentana.Size = new System.Drawing.Size(1600, 46);
            this.panelControlVentana.TabIndex = 0;
            this.panelControlVentana.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControlVentana_MouseDown);
            // 
            // lblMinimize
            // 
            this.lblMinimize.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.White;
            this.lblMinimize.Location = new System.Drawing.Point(1521, -15);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(79, 61);
            this.lblMinimize.TabIndex = 2;
            this.lblMinimize.Text = "-";
            this.lblMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            this.lblMinimize.MouseEnter += new System.EventHandler(this.lblMinimize_MouseEnter);
            this.lblMinimize.MouseLeave += new System.EventHandler(this.lblMinimize_MouseLeave);
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.panelLateral.Controls.Add(this.imgPerfil1);
            this.panelLateral.Controls.Add(this.lblSalir);
            this.panelLateral.Controls.Add(this.lblListaCompleted);
            this.panelLateral.Controls.Add(this.lblListaDropped);
            this.panelLateral.Controls.Add(this.lblListaPlantToWatch);
            this.panelLateral.Controls.Add(this.lblListaWatching);
            this.panelLateral.Controls.Add(this.lblListaGeneral);
            this.panelLateral.Controls.Add(this.lblNombreUsuario);
            this.panelLateral.Controls.Add(this.lblInicio);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 46);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(305, 854);
            this.panelLateral.TabIndex = 1;
            // 
            // lblSalir
            // 
            this.lblSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(228)))), ((int)(((byte)(24)))));
            this.lblSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSalir.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalir.ForeColor = System.Drawing.Color.Black;
            this.lblSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSalir.Location = new System.Drawing.Point(0, 804);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(305, 50);
            this.lblSalir.TabIndex = 17;
            this.lblSalir.Text = "SALIR";
            this.lblSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSalir.Click += new System.EventHandler(this.lblSalir_Click);
            // 
            // lblListaCompleted
            // 
            this.lblListaCompleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(71)))));
            this.lblListaCompleted.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaCompleted.ForeColor = System.Drawing.Color.White;
            this.lblListaCompleted.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblListaCompleted.Location = new System.Drawing.Point(65, 575);
            this.lblListaCompleted.Name = "lblListaCompleted";
            this.lblListaCompleted.Size = new System.Drawing.Size(228, 53);
            this.lblListaCompleted.TabIndex = 16;
            this.lblListaCompleted.Text = "Completada";
            this.lblListaCompleted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblListaDropped
            // 
            this.lblListaDropped.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(71)))));
            this.lblListaDropped.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaDropped.ForeColor = System.Drawing.Color.White;
            this.lblListaDropped.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblListaDropped.Location = new System.Drawing.Point(65, 637);
            this.lblListaDropped.Name = "lblListaDropped";
            this.lblListaDropped.Size = new System.Drawing.Size(228, 53);
            this.lblListaDropped.TabIndex = 15;
            this.lblListaDropped.Text = "Abandonada";
            this.lblListaDropped.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblListaPlantToWatch
            // 
            this.lblListaPlantToWatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(71)))));
            this.lblListaPlantToWatch.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaPlantToWatch.ForeColor = System.Drawing.Color.White;
            this.lblListaPlantToWatch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblListaPlantToWatch.Location = new System.Drawing.Point(65, 699);
            this.lblListaPlantToWatch.Name = "lblListaPlantToWatch";
            this.lblListaPlantToWatch.Size = new System.Drawing.Size(228, 53);
            this.lblListaPlantToWatch.TabIndex = 14;
            this.lblListaPlantToWatch.Text = "Planeada";
            this.lblListaPlantToWatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblListaWatching
            // 
            this.lblListaWatching.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(71)))));
            this.lblListaWatching.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaWatching.ForeColor = System.Drawing.Color.White;
            this.lblListaWatching.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblListaWatching.Location = new System.Drawing.Point(65, 513);
            this.lblListaWatching.Name = "lblListaWatching";
            this.lblListaWatching.Size = new System.Drawing.Size(228, 53);
            this.lblListaWatching.TabIndex = 13;
            this.lblListaWatching.Text = "Viendo";
            this.lblListaWatching.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblListaGeneral
            // 
            this.lblListaGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(71)))));
            this.lblListaGeneral.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaGeneral.ForeColor = System.Drawing.Color.White;
            this.lblListaGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblListaGeneral.Location = new System.Drawing.Point(12, 438);
            this.lblListaGeneral.Name = "lblListaGeneral";
            this.lblListaGeneral.Size = new System.Drawing.Size(281, 53);
            this.lblListaGeneral.TabIndex = 9;
            this.lblListaGeneral.Text = "Mi Lista";
            this.lblListaGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNombreUsuario.Location = new System.Drawing.Point(12, 238);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(275, 32);
            this.lblNombreUsuario.TabIndex = 1;
            this.lblNombreUsuario.Text = "Nombre Apellido Apellido";
            // 
            // lblInicio
            // 
            this.lblInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(71)))));
            this.lblInicio.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.Color.White;
            this.lblInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblInicio.Location = new System.Drawing.Point(12, 368);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(281, 53);
            this.lblInicio.TabIndex = 8;
            this.lblInicio.Text = "Inicio";
            this.lblInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgPerfil1
            // 
            this.imgPerfil1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.imgPerfil1.Location = new System.Drawing.Point(44, 17);
            this.imgPerfil1.Name = "imgPerfil1";
            this.imgPerfil1.Size = new System.Drawing.Size(213, 205);
            this.imgPerfil1.TabIndex = 18;
            this.imgPerfil1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.panelControlVentana);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MdbM";
            this.panelControlVentana.ResumeLayout(false);
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControlVentana;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblListaGeneral;
        private System.Windows.Forms.Label lblListaWatching;
        private System.Windows.Forms.Label lblListaCompleted;
        private System.Windows.Forms.Label lblListaDropped;
        private System.Windows.Forms.Label lblListaPlantToWatch;
        private System.Windows.Forms.Label lblSalir;
        private ImagenPerfil.ImgPerfil imgPerfil1;
    }
}
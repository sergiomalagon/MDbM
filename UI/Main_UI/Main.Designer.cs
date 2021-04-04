
namespace MDbM.UI.MainUI
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
            this.imgPerfil = new ImagenPerfil.ImgPerfil();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblListaCompleted = new System.Windows.Forms.Label();
            this.lblListaDropped = new System.Windows.Forms.Label();
            this.lblListaPlantToWatch = new System.Windows.Forms.Label();
            this.lblListaWatching = new System.Windows.Forms.Label();
            this.lblListaGeneral = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.panelLista = new System.Windows.Forms.FlowLayoutPanel();
            this.panelDetalle = new System.Windows.Forms.Panel();
            this.lblCerrarPanelDetalle = new System.Windows.Forms.Label();
            this.panelListaReparto = new System.Windows.Forms.FlowLayoutPanel();
            this.panelDescripcion = new System.Windows.Forms.Panel();
            this.panelCambiarStatus = new System.Windows.Forms.Panel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.panelPortadaHolder = new System.Windows.Forms.Panel();
            this.picBoxPortada = new System.Windows.Forms.PictureBox();
            this.panelInfoHolder = new System.Windows.Forms.Panel();
            this.lblValoracion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panelAux = new System.Windows.Forms.Panel();
            this.panelControlVentana.SuspendLayout();
            this.panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).BeginInit();
            this.panelDetalle.SuspendLayout();
            this.panelCambiarStatus.SuspendLayout();
            this.panelPortadaHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPortada)).BeginInit();
            this.panelInfoHolder.SuspendLayout();
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
            this.lblMinimize.Location = new System.Drawing.Point(1506, -15);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(94, 61);
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
            this.panelLateral.Controls.Add(this.imgPerfil);
            this.panelLateral.Controls.Add(this.lblVersion);
            this.panelLateral.Controls.Add(this.btnSalir);
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
            // imgPerfil
            // 
            this.imgPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.imgPerfil.Location = new System.Drawing.Point(50, 24);
            this.imgPerfil.Name = "imgPerfil";
            this.imgPerfil.Size = new System.Drawing.Size(200, 200);
            this.imgPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPerfil.TabIndex = 21;
            this.imgPerfil.TabStop = false;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVersion.Location = new System.Drawing.Point(3, 780);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(108, 22);
            this.lblVersion.TabIndex = 20;
            this.lblVersion.Text = "Version 0.0.1";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(228)))), ((int)(((byte)(24)))));
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(0, 808);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(305, 46);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.lblNombreUsuario.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNombreUsuario.Location = new System.Drawing.Point(12, 238);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(275, 32);
            this.lblNombreUsuario.TabIndex = 1;
            this.lblNombreUsuario.Text = "Nombre Apellido Apellido";
            this.lblNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // panelLista
            // 
            this.panelLista.AutoScroll = true;
            this.panelLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLista.Location = new System.Drawing.Point(305, 46);
            this.panelLista.Name = "panelLista";
            this.panelLista.Size = new System.Drawing.Size(1295, 854);
            this.panelLista.TabIndex = 0;
            // 
            // panelDetalle
            // 
            this.panelDetalle.Controls.Add(this.lblCerrarPanelDetalle);
            this.panelDetalle.Controls.Add(this.panelListaReparto);
            this.panelDetalle.Controls.Add(this.panelDescripcion);
            this.panelDetalle.Controls.Add(this.panelCambiarStatus);
            this.panelDetalle.Controls.Add(this.panelPortadaHolder);
            this.panelDetalle.Controls.Add(this.panelInfoHolder);
            this.panelDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetalle.Location = new System.Drawing.Point(305, 46);
            this.panelDetalle.Name = "panelDetalle";
            this.panelDetalle.Size = new System.Drawing.Size(1295, 854);
            this.panelDetalle.TabIndex = 0;
            // 
            // lblCerrarPanelDetalle
            // 
            this.lblCerrarPanelDetalle.AutoSize = true;
            this.lblCerrarPanelDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrarPanelDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.lblCerrarPanelDetalle.Location = new System.Drawing.Point(16, 6);
            this.lblCerrarPanelDetalle.Name = "lblCerrarPanelDetalle";
            this.lblCerrarPanelDetalle.Size = new System.Drawing.Size(47, 46);
            this.lblCerrarPanelDetalle.TabIndex = 4;
            this.lblCerrarPanelDetalle.Text = "X";
            this.lblCerrarPanelDetalle.Click += new System.EventHandler(this.lblCerrarPanelDetalle_Click);
            // 
            // panelListaReparto
            // 
            this.panelListaReparto.AutoScroll = true;
            this.panelListaReparto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.panelListaReparto.Location = new System.Drawing.Point(82, 564);
            this.panelListaReparto.Name = "panelListaReparto";
            this.panelListaReparto.Size = new System.Drawing.Size(1151, 256);
            this.panelListaReparto.TabIndex = 3;
            // 
            // panelDescripcion
            // 
            this.panelDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.panelDescripcion.Location = new System.Drawing.Point(328, 146);
            this.panelDescripcion.Name = "panelDescripcion";
            this.panelDescripcion.Size = new System.Drawing.Size(904, 364);
            this.panelDescripcion.TabIndex = 2;
            // 
            // panelCambiarStatus
            // 
            this.panelCambiarStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.panelCambiarStatus.Controls.Add(this.metroComboBox1);
            this.panelCambiarStatus.Location = new System.Drawing.Point(81, 438);
            this.panelCambiarStatus.Name = "panelCambiarStatus";
            this.panelCambiarStatus.Size = new System.Drawing.Size(225, 72);
            this.panelCambiarStatus.TabIndex = 2;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox1.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.metroComboBox1.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 29;
            this.metroComboBox1.Items.AddRange(new object[] {
            "VIENDO",
            "COMPLETADA",
            "ABANDONADA",
            "PLANEADA"});
            this.metroComboBox1.Location = new System.Drawing.Point(14, 23);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(196, 35);
            this.metroComboBox1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroComboBox1.TabIndex = 0;
            this.metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // panelPortadaHolder
            // 
            this.panelPortadaHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.panelPortadaHolder.Controls.Add(this.picBoxPortada);
            this.panelPortadaHolder.Location = new System.Drawing.Point(81, 53);
            this.panelPortadaHolder.Name = "panelPortadaHolder";
            this.panelPortadaHolder.Size = new System.Drawing.Size(225, 360);
            this.panelPortadaHolder.TabIndex = 2;
            // 
            // picBoxPortada
            // 
            this.picBoxPortada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(110)))));
            this.picBoxPortada.Location = new System.Drawing.Point(14, 15);
            this.picBoxPortada.Name = "picBoxPortada";
            this.picBoxPortada.Size = new System.Drawing.Size(197, 322);
            this.picBoxPortada.TabIndex = 0;
            this.picBoxPortada.TabStop = false;
            // 
            // panelInfoHolder
            // 
            this.panelInfoHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.panelInfoHolder.Controls.Add(this.lblValoracion);
            this.panelInfoHolder.Controls.Add(this.lblNombre);
            this.panelInfoHolder.Location = new System.Drawing.Point(328, 53);
            this.panelInfoHolder.Name = "panelInfoHolder";
            this.panelInfoHolder.Size = new System.Drawing.Size(904, 72);
            this.panelInfoHolder.TabIndex = 1;
            // 
            // lblValoracion
            // 
            this.lblValoracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(85)))));
            this.lblValoracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblValoracion.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValoracion.ForeColor = System.Drawing.Color.White;
            this.lblValoracion.Location = new System.Drawing.Point(62, 8);
            this.lblValoracion.Name = "lblValoracion";
            this.lblValoracion.Size = new System.Drawing.Size(103, 54);
            this.lblValoracion.TabIndex = 0;
            this.lblValoracion.Text = "label1";
            this.lblValoracion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(85)))));
            this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombre.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(216, 8);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(613, 54);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "label1";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAux
            // 
            this.panelAux.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(110)))));
            this.panelAux.Location = new System.Drawing.Point(1537, 46);
            this.panelAux.Name = "panelAux";
            this.panelAux.Size = new System.Drawing.Size(63, 854);
            this.panelAux.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.panelAux);
            this.Controls.Add(this.panelLista);
            this.Controls.Add(this.panelDetalle);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.panelControlVentana);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MdbM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.panelControlVentana.ResumeLayout(false);
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).EndInit();
            this.panelDetalle.ResumeLayout(false);
            this.panelDetalle.PerformLayout();
            this.panelCambiarStatus.ResumeLayout(false);
            this.panelPortadaHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPortada)).EndInit();
            this.panelInfoHolder.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.FlowLayoutPanel panelLista;
        private System.Windows.Forms.Panel panelDetalle;
        private System.Windows.Forms.Panel panelAux;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.PictureBox picBoxPortada;
        private System.Windows.Forms.Panel panelInfoHolder;
        private System.Windows.Forms.Panel panelPortadaHolder;
        private System.Windows.Forms.Panel panelDescripcion;
        private System.Windows.Forms.Panel panelCambiarStatus;
        private System.Windows.Forms.FlowLayoutPanel panelListaReparto;
        private System.Windows.Forms.Label lblCerrarPanelDetalle;
        private System.Windows.Forms.Label lblValoracion;
        private System.Windows.Forms.Label lblNombre;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private ImagenPerfil.ImgPerfil imgPerfil;
    }
}

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
            this.PanelControlVentana = new System.Windows.Forms.Panel();
            this.ComboBoxOrden = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxBarraBusqueda = new System.Windows.Forms.TextBox();
            this.ComboBoxOrdenKey = new MetroFramework.Controls.MetroComboBox();
            this.LblMinimize = new System.Windows.Forms.Label();
            this.PanelLateral = new System.Windows.Forms.Panel();
            this.BtnInicio = new System.Windows.Forms.Button();
            this.BtnMiLista = new System.Windows.Forms.Button();
            this.BtnViendo = new System.Windows.Forms.Button();
            this.BtnCompletada = new System.Windows.Forms.Button();
            this.BtnAbandonada = new System.Windows.Forms.Button();
            this.BtnPlaneada = new System.Windows.Forms.Button();
            this.LblVersion = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LblNombreUsuario = new System.Windows.Forms.Label();
            this.PanelLista = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelDetalle = new System.Windows.Forms.Panel();
            this.LblCerrarPanelDetalle = new System.Windows.Forms.Label();
            this.PanelListaReparto = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelDescripcion = new System.Windows.Forms.Panel();
            this.TxtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.PanelCambiarStatus = new System.Windows.Forms.Panel();
            this.ComboBoxEstado = new MetroFramework.Controls.MetroComboBox();
            this.PanelPortadaHolder = new System.Windows.Forms.Panel();
            this.PicBoxPortada = new System.Windows.Forms.PictureBox();
            this.PanelInfoHolder = new System.Windows.Forms.Panel();
            this.LblGenros = new System.Windows.Forms.Label();
            this.LblValoracion = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.PanelAux = new System.Windows.Forms.Panel();
            this.ImgPerfil = new ImagenPerfil.ImgPerfil();
            this.PanelControlVentana.SuspendLayout();
            this.PanelLateral.SuspendLayout();
            this.PanelDetalle.SuspendLayout();
            this.PanelDescripcion.SuspendLayout();
            this.PanelCambiarStatus.SuspendLayout();
            this.PanelPortadaHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxPortada)).BeginInit();
            this.PanelInfoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelControlVentana
            // 
            this.PanelControlVentana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.PanelControlVentana.Controls.Add(this.ComboBoxOrden);
            this.PanelControlVentana.Controls.Add(this.label1);
            this.PanelControlVentana.Controls.Add(this.TxtBoxBarraBusqueda);
            this.PanelControlVentana.Controls.Add(this.ComboBoxOrdenKey);
            this.PanelControlVentana.Controls.Add(this.LblMinimize);
            this.PanelControlVentana.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelControlVentana.Location = new System.Drawing.Point(0, 0);
            this.PanelControlVentana.Name = "PanelControlVentana";
            this.PanelControlVentana.Size = new System.Drawing.Size(1600, 55);
            this.PanelControlVentana.TabIndex = 0;
            this.PanelControlVentana.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelControlVentana_MouseDown);
            // 
            // ComboBoxOrden
            // 
            this.ComboBoxOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxOrden.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.ComboBoxOrden.FormattingEnabled = true;
            this.ComboBoxOrden.ItemHeight = 23;
            this.ComboBoxOrden.Items.AddRange(new object[] {
            "ASC",
            "DESC"});
            this.ComboBoxOrden.Location = new System.Drawing.Point(651, 14);
            this.ComboBoxOrden.Name = "ComboBoxOrden";
            this.ComboBoxOrden.Size = new System.Drawing.Size(99, 29);
            this.ComboBoxOrden.Style = MetroFramework.MetroColorStyle.Black;
            this.ComboBoxOrden.TabIndex = 5;
            this.ComboBoxOrden.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ComboBoxOrden.SelectedIndexChanged += new System.EventHandler(this.ComboBoxOrden_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(301, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ordenadar Por:";
            // 
            // TxtBoxBarraBusqueda
            // 
            this.TxtBoxBarraBusqueda.AllowDrop = true;
            this.TxtBoxBarraBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBoxBarraBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBoxBarraBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBoxBarraBusqueda.Font = new System.Drawing.Font("Tw Cen MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxBarraBusqueda.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TxtBoxBarraBusqueda.Location = new System.Drawing.Point(817, 7);
            this.TxtBoxBarraBusqueda.Name = "TxtBoxBarraBusqueda";
            this.TxtBoxBarraBusqueda.Size = new System.Drawing.Size(601, 39);
            this.TxtBoxBarraBusqueda.TabIndex = 3;
            this.TxtBoxBarraBusqueda.Text = "BUSCAR PELICULA...";
            this.TxtBoxBarraBusqueda.TextChanged += new System.EventHandler(this.TxtBoxBarraBusqueda_TextChanged);
            this.TxtBoxBarraBusqueda.Enter += new System.EventHandler(this.TxtBoxBarraBusqueda_Enter);
            this.TxtBoxBarraBusqueda.Leave += new System.EventHandler(this.TxtBoxBarraBusqueda_Leave);
            // 
            // ComboBoxOrdenKey
            // 
            this.ComboBoxOrdenKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxOrdenKey.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.ComboBoxOrdenKey.FormattingEnabled = true;
            this.ComboBoxOrdenKey.ItemHeight = 23;
            this.ComboBoxOrdenKey.Items.AddRange(new object[] {
            "TITULO",
            "VALORACION",
            "AÑO"});
            this.ComboBoxOrdenKey.Location = new System.Drawing.Point(429, 14);
            this.ComboBoxOrdenKey.Name = "ComboBoxOrdenKey";
            this.ComboBoxOrdenKey.Size = new System.Drawing.Size(212, 29);
            this.ComboBoxOrdenKey.Style = MetroFramework.MetroColorStyle.Black;
            this.ComboBoxOrdenKey.TabIndex = 3;
            this.ComboBoxOrdenKey.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ComboBoxOrdenKey.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxOrden_SelectionChangeCommitted);
            // 
            // LblMinimize
            // 
            this.LblMinimize.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMinimize.ForeColor = System.Drawing.Color.White;
            this.LblMinimize.Location = new System.Drawing.Point(1502, -9);
            this.LblMinimize.Name = "LblMinimize";
            this.LblMinimize.Size = new System.Drawing.Size(98, 64);
            this.LblMinimize.TabIndex = 2;
            this.LblMinimize.Text = "-";
            this.LblMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblMinimize.Click += new System.EventHandler(this.LblMinimize_Click);
            this.LblMinimize.MouseEnter += new System.EventHandler(this.LblMinimize_MouseEnter);
            this.LblMinimize.MouseLeave += new System.EventHandler(this.LblMinimize_MouseLeave);
            // 
            // PanelLateral
            // 
            this.PanelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.PanelLateral.Controls.Add(this.BtnInicio);
            this.PanelLateral.Controls.Add(this.BtnMiLista);
            this.PanelLateral.Controls.Add(this.BtnViendo);
            this.PanelLateral.Controls.Add(this.BtnCompletada);
            this.PanelLateral.Controls.Add(this.BtnAbandonada);
            this.PanelLateral.Controls.Add(this.BtnPlaneada);
            this.PanelLateral.Controls.Add(this.ImgPerfil);
            this.PanelLateral.Controls.Add(this.LblVersion);
            this.PanelLateral.Controls.Add(this.BtnSalir);
            this.PanelLateral.Controls.Add(this.LblNombreUsuario);
            this.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLateral.Location = new System.Drawing.Point(0, 55);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Size = new System.Drawing.Size(305, 845);
            this.PanelLateral.TabIndex = 1;
            // 
            // BtnInicio
            // 
            this.BtnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(71)))));
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicio.ForeColor = System.Drawing.Color.White;
            this.BtnInicio.Location = new System.Drawing.Point(12, 309);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(281, 53);
            this.BtnInicio.TabIndex = 27;
            this.BtnInicio.Text = "Inicio";
            this.BtnInicio.UseVisualStyleBackColor = false;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // BtnMiLista
            // 
            this.BtnMiLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(71)))));
            this.BtnMiLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMiLista.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMiLista.ForeColor = System.Drawing.Color.White;
            this.BtnMiLista.Location = new System.Drawing.Point(12, 368);
            this.BtnMiLista.Name = "BtnMiLista";
            this.BtnMiLista.Size = new System.Drawing.Size(281, 53);
            this.BtnMiLista.TabIndex = 26;
            this.BtnMiLista.Text = "Mi Lista";
            this.BtnMiLista.UseVisualStyleBackColor = false;
            this.BtnMiLista.Click += new System.EventHandler(this.BtnMiLista_Click);
            // 
            // BtnViendo
            // 
            this.BtnViendo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(71)))));
            this.BtnViendo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnViendo.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViendo.ForeColor = System.Drawing.Color.White;
            this.BtnViendo.Location = new System.Drawing.Point(65, 447);
            this.BtnViendo.Name = "BtnViendo";
            this.BtnViendo.Size = new System.Drawing.Size(228, 53);
            this.BtnViendo.TabIndex = 25;
            this.BtnViendo.Text = "Viendo";
            this.BtnViendo.UseVisualStyleBackColor = false;
            this.BtnViendo.Click += new System.EventHandler(this.BtnViendo_Click);
            // 
            // BtnCompletada
            // 
            this.BtnCompletada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(71)))));
            this.BtnCompletada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCompletada.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCompletada.ForeColor = System.Drawing.Color.White;
            this.BtnCompletada.Location = new System.Drawing.Point(65, 506);
            this.BtnCompletada.Name = "BtnCompletada";
            this.BtnCompletada.Size = new System.Drawing.Size(228, 53);
            this.BtnCompletada.TabIndex = 24;
            this.BtnCompletada.Text = "Completada";
            this.BtnCompletada.UseVisualStyleBackColor = false;
            this.BtnCompletada.Click += new System.EventHandler(this.BtnCompletada_Click);
            // 
            // BtnAbandonada
            // 
            this.BtnAbandonada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(71)))));
            this.BtnAbandonada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbandonada.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbandonada.ForeColor = System.Drawing.Color.White;
            this.BtnAbandonada.Location = new System.Drawing.Point(65, 565);
            this.BtnAbandonada.Name = "BtnAbandonada";
            this.BtnAbandonada.Size = new System.Drawing.Size(228, 53);
            this.BtnAbandonada.TabIndex = 23;
            this.BtnAbandonada.Text = "Abandonada";
            this.BtnAbandonada.UseVisualStyleBackColor = false;
            this.BtnAbandonada.Click += new System.EventHandler(this.BtnAbandonada_Click);
            // 
            // BtnPlaneada
            // 
            this.BtnPlaneada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(71)))));
            this.BtnPlaneada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlaneada.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlaneada.ForeColor = System.Drawing.Color.White;
            this.BtnPlaneada.Location = new System.Drawing.Point(65, 624);
            this.BtnPlaneada.Name = "BtnPlaneada";
            this.BtnPlaneada.Size = new System.Drawing.Size(228, 53);
            this.BtnPlaneada.TabIndex = 22;
            this.BtnPlaneada.Text = "Pleaneada";
            this.BtnPlaneada.UseVisualStyleBackColor = false;
            this.BtnPlaneada.Click += new System.EventHandler(this.BtnPlaneada_Click);
            // 
            // LblVersion
            // 
            this.LblVersion.AutoSize = true;
            this.LblVersion.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVersion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LblVersion.Location = new System.Drawing.Point(3, 774);
            this.LblVersion.Name = "LblVersion";
            this.LblVersion.Size = new System.Drawing.Size(108, 22);
            this.LblVersion.TabIndex = 20;
            this.LblVersion.Text = "Version 1.0.0";
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(228)))), ((int)(((byte)(24)))));
            this.BtnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.Black;
            this.BtnSalir.Location = new System.Drawing.Point(0, 799);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(305, 46);
            this.BtnSalir.TabIndex = 19;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LblNombreUsuario
            // 
            this.LblNombreUsuario.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.LblNombreUsuario.Location = new System.Drawing.Point(12, 238);
            this.LblNombreUsuario.Name = "LblNombreUsuario";
            this.LblNombreUsuario.Size = new System.Drawing.Size(275, 32);
            this.LblNombreUsuario.TabIndex = 1;
            this.LblNombreUsuario.Text = "Nombre Apellido Apellido";
            this.LblNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelLista
            // 
            this.PanelLista.AutoScroll = true;
            this.PanelLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelLista.Location = new System.Drawing.Point(305, 55);
            this.PanelLista.Name = "PanelLista";
            this.PanelLista.Size = new System.Drawing.Size(1295, 845);
            this.PanelLista.TabIndex = 0;
            // 
            // PanelDetalle
            // 
            this.PanelDetalle.Controls.Add(this.LblCerrarPanelDetalle);
            this.PanelDetalle.Controls.Add(this.PanelListaReparto);
            this.PanelDetalle.Controls.Add(this.PanelDescripcion);
            this.PanelDetalle.Controls.Add(this.PanelCambiarStatus);
            this.PanelDetalle.Controls.Add(this.PanelPortadaHolder);
            this.PanelDetalle.Controls.Add(this.PanelInfoHolder);
            this.PanelDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDetalle.Location = new System.Drawing.Point(305, 55);
            this.PanelDetalle.Name = "PanelDetalle";
            this.PanelDetalle.Size = new System.Drawing.Size(1295, 845);
            this.PanelDetalle.TabIndex = 0;
            // 
            // LblCerrarPanelDetalle
            // 
            this.LblCerrarPanelDetalle.AutoSize = true;
            this.LblCerrarPanelDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCerrarPanelDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.LblCerrarPanelDetalle.Location = new System.Drawing.Point(16, 6);
            this.LblCerrarPanelDetalle.Name = "LblCerrarPanelDetalle";
            this.LblCerrarPanelDetalle.Size = new System.Drawing.Size(47, 46);
            this.LblCerrarPanelDetalle.TabIndex = 4;
            this.LblCerrarPanelDetalle.Text = "X";
            this.LblCerrarPanelDetalle.Click += new System.EventHandler(this.LblCerrarPanelDetalle_Click);
            // 
            // PanelListaReparto
            // 
            this.PanelListaReparto.AutoScroll = true;
            this.PanelListaReparto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.PanelListaReparto.Location = new System.Drawing.Point(72, 564);
            this.PanelListaReparto.Name = "PanelListaReparto";
            this.PanelListaReparto.Size = new System.Drawing.Size(1161, 256);
            this.PanelListaReparto.TabIndex = 3;
            // 
            // PanelDescripcion
            // 
            this.PanelDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.PanelDescripcion.Controls.Add(this.TxtBoxDescripcion);
            this.PanelDescripcion.Location = new System.Drawing.Point(328, 146);
            this.PanelDescripcion.Name = "PanelDescripcion";
            this.PanelDescripcion.Size = new System.Drawing.Size(904, 364);
            this.PanelDescripcion.TabIndex = 2;
            // 
            // TxtBoxDescripcion
            // 
            this.TxtBoxDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.TxtBoxDescripcion.Enabled = false;
            this.TxtBoxDescripcion.Font = new System.Drawing.Font("Tw Cen MT Condensed", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxDescripcion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TxtBoxDescripcion.Location = new System.Drawing.Point(18, 15);
            this.TxtBoxDescripcion.Multiline = true;
            this.TxtBoxDescripcion.Name = "TxtBoxDescripcion";
            this.TxtBoxDescripcion.ReadOnly = true;
            this.TxtBoxDescripcion.Size = new System.Drawing.Size(869, 335);
            this.TxtBoxDescripcion.TabIndex = 0;
            // 
            // PanelCambiarStatus
            // 
            this.PanelCambiarStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.PanelCambiarStatus.Controls.Add(this.ComboBoxEstado);
            this.PanelCambiarStatus.Location = new System.Drawing.Point(72, 438);
            this.PanelCambiarStatus.Name = "PanelCambiarStatus";
            this.PanelCambiarStatus.Size = new System.Drawing.Size(234, 72);
            this.PanelCambiarStatus.TabIndex = 2;
            // 
            // ComboBoxEstado
            // 
            this.ComboBoxEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxEstado.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.ComboBoxEstado.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.ComboBoxEstado.FormattingEnabled = true;
            this.ComboBoxEstado.ItemHeight = 29;
            this.ComboBoxEstado.Items.AddRange(new object[] {
            "-- NO AGREGADA --",
            "VIENDO",
            "COMPLETADA",
            "ABANDONADA",
            "PLANEADA"});
            this.ComboBoxEstado.Location = new System.Drawing.Point(14, 23);
            this.ComboBoxEstado.Name = "ComboBoxEstado";
            this.ComboBoxEstado.Size = new System.Drawing.Size(205, 35);
            this.ComboBoxEstado.Style = MetroFramework.MetroColorStyle.Black;
            this.ComboBoxEstado.TabIndex = 0;
            this.ComboBoxEstado.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ComboBoxEstado.DropDown += new System.EventHandler(this.ComboBoxEstado_DropDown);
            this.ComboBoxEstado.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxEstado_SelectedIndexChanged);
            // 
            // PanelPortadaHolder
            // 
            this.PanelPortadaHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.PanelPortadaHolder.Controls.Add(this.PicBoxPortada);
            this.PanelPortadaHolder.Location = new System.Drawing.Point(72, 53);
            this.PanelPortadaHolder.Name = "PanelPortadaHolder";
            this.PanelPortadaHolder.Size = new System.Drawing.Size(234, 360);
            this.PanelPortadaHolder.TabIndex = 2;
            // 
            // PicBoxPortada
            // 
            this.PicBoxPortada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(110)))));
            this.PicBoxPortada.Location = new System.Drawing.Point(14, 15);
            this.PicBoxPortada.Name = "PicBoxPortada";
            this.PicBoxPortada.Size = new System.Drawing.Size(205, 322);
            this.PicBoxPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxPortada.TabIndex = 0;
            this.PicBoxPortada.TabStop = false;
            // 
            // PanelInfoHolder
            // 
            this.PanelInfoHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.PanelInfoHolder.Controls.Add(this.LblGenros);
            this.PanelInfoHolder.Controls.Add(this.LblValoracion);
            this.PanelInfoHolder.Controls.Add(this.LblNombre);
            this.PanelInfoHolder.Location = new System.Drawing.Point(328, 53);
            this.PanelInfoHolder.Name = "PanelInfoHolder";
            this.PanelInfoHolder.Size = new System.Drawing.Size(904, 87);
            this.PanelInfoHolder.TabIndex = 1;
            // 
            // LblGenros
            // 
            this.LblGenros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(85)))));
            this.LblGenros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblGenros.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGenros.ForeColor = System.Drawing.Color.White;
            this.LblGenros.Location = new System.Drawing.Point(216, 52);
            this.LblGenros.Name = "LblGenros";
            this.LblGenros.Size = new System.Drawing.Size(613, 25);
            this.LblGenros.TabIndex = 2;
            this.LblGenros.Text = "label1";
            this.LblGenros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblValoracion
            // 
            this.LblValoracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(85)))));
            this.LblValoracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblValoracion.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValoracion.ForeColor = System.Drawing.Color.White;
            this.LblValoracion.Location = new System.Drawing.Point(19, 13);
            this.LblValoracion.Name = "LblValoracion";
            this.LblValoracion.Size = new System.Drawing.Size(113, 62);
            this.LblValoracion.TabIndex = 0;
            this.LblValoracion.Text = "label1";
            this.LblValoracion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblNombre
            // 
            this.LblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(85)))));
            this.LblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblNombre.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.Color.White;
            this.LblNombre.Location = new System.Drawing.Point(216, 8);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(613, 39);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "label1";
            this.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelAux
            // 
            this.PanelAux.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(110)))));
            this.PanelAux.Location = new System.Drawing.Point(1537, 55);
            this.PanelAux.Name = "PanelAux";
            this.PanelAux.Size = new System.Drawing.Size(63, 845);
            this.PanelAux.TabIndex = 0;
            // 
            // ImgPerfil
            // 
            this.ImgPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ImgPerfil.Location = new System.Drawing.Point(50, 24);
            this.ImgPerfil.Name = "ImgPerfil";
            this.ImgPerfil.Size = new System.Drawing.Size(200, 200);
            this.ImgPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgPerfil.TabIndex = 21;
            this.ImgPerfil.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.PanelAux);
            this.Controls.Add(this.PanelLista);
            this.Controls.Add(this.PanelDetalle);
            this.Controls.Add(this.PanelLateral);
            this.Controls.Add(this.PanelControlVentana);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MdbM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.PanelControlVentana.ResumeLayout(false);
            this.PanelControlVentana.PerformLayout();
            this.PanelLateral.ResumeLayout(false);
            this.PanelLateral.PerformLayout();
            this.PanelDetalle.ResumeLayout(false);
            this.PanelDetalle.PerformLayout();
            this.PanelDescripcion.ResumeLayout(false);
            this.PanelDescripcion.PerformLayout();
            this.PanelCambiarStatus.ResumeLayout(false);
            this.PanelPortadaHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxPortada)).EndInit();
            this.PanelInfoHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgPerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelControlVentana;
        private System.Windows.Forms.Panel PanelLateral;
        private System.Windows.Forms.Label LblMinimize;
        private System.Windows.Forms.Label LblNombreUsuario;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.FlowLayoutPanel PanelLista;
        private System.Windows.Forms.Panel PanelDetalle;
        private System.Windows.Forms.Panel PanelAux;
        private System.Windows.Forms.Label LblVersion;
        private System.Windows.Forms.PictureBox PicBoxPortada;
        private System.Windows.Forms.Panel PanelInfoHolder;
        private System.Windows.Forms.Panel PanelPortadaHolder;
        private System.Windows.Forms.Panel PanelDescripcion;
        private System.Windows.Forms.Panel PanelCambiarStatus;
        private System.Windows.Forms.FlowLayoutPanel PanelListaReparto;
        private System.Windows.Forms.Label LblCerrarPanelDetalle;
        private System.Windows.Forms.Label LblValoracion;
        private System.Windows.Forms.Label LblNombre;
        private MetroFramework.Controls.MetroComboBox ComboBoxEstado;
        private ImagenPerfil.ImgPerfil ImgPerfil;
        private System.Windows.Forms.Button BtnPlaneada;
        private System.Windows.Forms.Button BtnAbandonada;
        private System.Windows.Forms.Button BtnViendo;
        private System.Windows.Forms.Button BtnCompletada;
        private System.Windows.Forms.Button BtnMiLista;
        private System.Windows.Forms.Button BtnInicio;
        private System.Windows.Forms.TextBox TxtBoxBarraBusqueda;
        private MetroFramework.Controls.MetroComboBox ComboBoxOrdenKey;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox ComboBoxOrden;
        private System.Windows.Forms.Label LblGenros;
        private System.Windows.Forms.TextBox TxtBoxDescripcion;
    }
}
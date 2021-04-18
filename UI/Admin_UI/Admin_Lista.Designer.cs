
namespace MDbM.UI.AdminUI
{
    partial class Admin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicio = new System.Windows.Forms.ToolStripMenuItem();
            this.peliculasList = new System.Windows.Forms.ToolStripMenuItem();
            this.verPeliculas = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPeliculas = new System.Windows.Forms.ToolStripMenuItem();
            this.repartoList = new System.Windows.Forms.ToolStripMenuItem();
            this.verReparto = new System.Windows.Forms.ToolStripMenuItem();
            this.crearReparto = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.BtnPararServicio = new System.Windows.Forms.Button();
            this.BtnIniciarServicio = new System.Windows.Forms.Button();
            this.LblEstadoServicio = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.editarPelicula = new System.Windows.Forms.Panel();
            this.BtnEliminarPelicula = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtBoxAño = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxTitulo = new System.Windows.Forms.TextBox();
            this.TxtBoxValoracion = new System.Windows.Forms.TextBox();
            this.TxtBoxDescripcion = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PicBoxReparto2 = new System.Windows.Forms.PictureBox();
            this.PicBoxReparto1 = new System.Windows.Forms.PictureBox();
            this.PicBoxDirector = new System.Windows.Forms.PictureBox();
            this.PicBoxReparto3 = new System.Windows.Forms.PictureBox();
            this.CBoxReparto1 = new System.Windows.Forms.ComboBox();
            this.CBoxReparto2 = new System.Windows.Forms.ComboBox();
            this.CBoxReparto3 = new System.Windows.Forms.ComboBox();
            this.CBoxDirector = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListBoxTodosGeneros = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ListBoxGenerosSeleccionados = new System.Windows.Forms.ListBox();
            this.BtnCambiarPortada = new System.Windows.Forms.Button();
            this.PicBoxPortada = new System.Windows.Forms.PictureBox();
            this.editarReparto = new System.Windows.Forms.Panel();
            this.BtnEliminarReparto = new System.Windows.Forms.Button();
            this.BtnCancelarReparto = new System.Windows.Forms.Button();
            this.BtnAceptarReparto = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtBoxNombreReparto = new System.Windows.Forms.TextBox();
            this.BtnCambiarImagenReparto = new System.Windows.Forms.Button();
            this.PicBoxPortadaRetrato = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.adminPanel.SuspendLayout();
            this.editarPelicula.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxReparto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxReparto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxDirector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxReparto3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxPortada)).BeginInit();
            this.editarReparto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxPortadaRetrato)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicio,
            this.peliculasList,
            this.repartoList});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1149, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicio
            // 
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(48, 20);
            this.inicio.Text = "Inicio";
            this.inicio.Click += new System.EventHandler(this.Inicio_Click);
            // 
            // peliculasList
            // 
            this.peliculasList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPeliculas,
            this.crearPeliculas});
            this.peliculasList.Name = "peliculasList";
            this.peliculasList.Size = new System.Drawing.Size(65, 20);
            this.peliculasList.Text = "Peliculas";
            // 
            // verPeliculas
            // 
            this.verPeliculas.Name = "verPeliculas";
            this.verPeliculas.Size = new System.Drawing.Size(146, 22);
            this.verPeliculas.Text = "Ver Peliculas";
            this.verPeliculas.Click += new System.EventHandler(this.VerPeliculas_Click);
            // 
            // crearPeliculas
            // 
            this.crearPeliculas.Name = "crearPeliculas";
            this.crearPeliculas.Size = new System.Drawing.Size(146, 22);
            this.crearPeliculas.Text = "Crear Pelicula";
            this.crearPeliculas.Click += new System.EventHandler(this.CrearPeliculas_Click);
            // 
            // repartoList
            // 
            this.repartoList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verReparto,
            this.crearReparto});
            this.repartoList.Name = "repartoList";
            this.repartoList.Size = new System.Drawing.Size(60, 20);
            this.repartoList.Text = "Reparto";
            // 
            // verReparto
            // 
            this.verReparto.Name = "verReparto";
            this.verReparto.Size = new System.Drawing.Size(146, 22);
            this.verReparto.Text = "Ver Reparto";
            this.verReparto.Click += new System.EventHandler(this.VerReparto_Click);
            // 
            // crearReparto
            // 
            this.crearReparto.Name = "crearReparto";
            this.crearReparto.Size = new System.Drawing.Size(146, 22);
            this.crearReparto.Text = "Crear Reparto";
            this.crearReparto.Click += new System.EventHandler(this.CrearReparto_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(1149, 545);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // adminPanel
            // 
            this.adminPanel.Controls.Add(this.BtnPararServicio);
            this.adminPanel.Controls.Add(this.BtnIniciarServicio);
            this.adminPanel.Controls.Add(this.LblEstadoServicio);
            this.adminPanel.Controls.Add(this.label10);
            this.adminPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminPanel.Location = new System.Drawing.Point(0, 24);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(1149, 545);
            this.adminPanel.TabIndex = 0;
            // 
            // BtnPararServicio
            // 
            this.BtnPararServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnPararServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPararServicio.Font = new System.Drawing.Font("Tw Cen MT Condensed", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPararServicio.Location = new System.Drawing.Point(141, 391);
            this.BtnPararServicio.Name = "BtnPararServicio";
            this.BtnPararServicio.Size = new System.Drawing.Size(287, 83);
            this.BtnPararServicio.TabIndex = 3;
            this.BtnPararServicio.Text = "Parar";
            this.BtnPararServicio.UseVisualStyleBackColor = false;
            this.BtnPararServicio.Click += new System.EventHandler(this.BtnPararServicio_Click);
            // 
            // BtnIniciarServicio
            // 
            this.BtnIniciarServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(90)))), ((int)(((byte)(30)))));
            this.BtnIniciarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciarServicio.Font = new System.Drawing.Font("Tw Cen MT Condensed", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciarServicio.Location = new System.Drawing.Point(535, 391);
            this.BtnIniciarServicio.Name = "BtnIniciarServicio";
            this.BtnIniciarServicio.Size = new System.Drawing.Size(288, 83);
            this.BtnIniciarServicio.TabIndex = 2;
            this.BtnIniciarServicio.Text = "Iniciar";
            this.BtnIniciarServicio.UseVisualStyleBackColor = false;
            this.BtnIniciarServicio.Click += new System.EventHandler(this.BtnIniciarServicio_Click);
            // 
            // LblEstadoServicio
            // 
            this.LblEstadoServicio.AutoSize = true;
            this.LblEstadoServicio.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstadoServicio.ForeColor = System.Drawing.Color.GreenYellow;
            this.LblEstadoServicio.Location = new System.Drawing.Point(841, 195);
            this.LblEstadoServicio.Name = "LblEstadoServicio";
            this.LblEstadoServicio.Size = new System.Drawing.Size(412, 48);
            this.LblEstadoServicio.TabIndex = 1;
            this.LblEstadoServicio.Text = "Estado Servicio MongoDB:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(826, 94);
            this.label10.TabIndex = 0;
            this.label10.Text = "Estado Servicio MongoDB:";
            // 
            // editarPelicula
            // 
            this.editarPelicula.Controls.Add(this.BtnEliminarPelicula);
            this.editarPelicula.Controls.Add(this.BtnCancelar);
            this.editarPelicula.Controls.Add(this.BtnAceptar);
            this.editarPelicula.Controls.Add(this.groupBox3);
            this.editarPelicula.Controls.Add(this.groupBox2);
            this.editarPelicula.Controls.Add(this.groupBox1);
            this.editarPelicula.Controls.Add(this.BtnCambiarPortada);
            this.editarPelicula.Controls.Add(this.PicBoxPortada);
            this.editarPelicula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editarPelicula.Location = new System.Drawing.Point(0, 24);
            this.editarPelicula.Name = "editarPelicula";
            this.editarPelicula.Size = new System.Drawing.Size(1149, 545);
            this.editarPelicula.TabIndex = 0;
            // 
            // BtnEliminarPelicula
            // 
            this.BtnEliminarPelicula.Location = new System.Drawing.Point(23, 454);
            this.BtnEliminarPelicula.Name = "BtnEliminarPelicula";
            this.BtnEliminarPelicula.Size = new System.Drawing.Size(192, 25);
            this.BtnEliminarPelicula.TabIndex = 24;
            this.BtnEliminarPelicula.Text = "Eliminar";
            this.BtnEliminarPelicula.UseVisualStyleBackColor = true;
            this.BtnEliminarPelicula.Visible = false;
            this.BtnEliminarPelicula.Click += new System.EventHandler(this.BtnEliminarPelicula_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(141, 499);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 23;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(23, 499);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 22;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.TxtBoxAño);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.TxtBoxTitulo);
            this.groupBox3.Controls.Add(this.TxtBoxValoracion);
            this.groupBox3.Controls.Add(this.TxtBoxDescripcion);
            this.groupBox3.Location = new System.Drawing.Point(243, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(476, 272);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "General";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(354, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Año";
            // 
            // TxtBoxAño
            // 
            this.TxtBoxAño.Location = new System.Drawing.Point(386, 19);
            this.TxtBoxAño.Name = "TxtBoxAño";
            this.TxtBoxAño.Size = new System.Drawing.Size(59, 20);
            this.TxtBoxAño.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Titulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valoracion";
            // 
            // TxtBoxTitulo
            // 
            this.TxtBoxTitulo.Location = new System.Drawing.Point(90, 59);
            this.TxtBoxTitulo.Name = "TxtBoxTitulo";
            this.TxtBoxTitulo.Size = new System.Drawing.Size(190, 20);
            this.TxtBoxTitulo.TabIndex = 2;
            // 
            // TxtBoxValoracion
            // 
            this.TxtBoxValoracion.Location = new System.Drawing.Point(90, 19);
            this.TxtBoxValoracion.Name = "TxtBoxValoracion";
            this.TxtBoxValoracion.Size = new System.Drawing.Size(50, 20);
            this.TxtBoxValoracion.TabIndex = 1;
            // 
            // TxtBoxDescripcion
            // 
            this.TxtBoxDescripcion.Location = new System.Drawing.Point(90, 109);
            this.TxtBoxDescripcion.Name = "TxtBoxDescripcion";
            this.TxtBoxDescripcion.Size = new System.Drawing.Size(355, 154);
            this.TxtBoxDescripcion.TabIndex = 0;
            this.TxtBoxDescripcion.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.PicBoxReparto2);
            this.groupBox2.Controls.Add(this.PicBoxReparto1);
            this.groupBox2.Controls.Add(this.PicBoxDirector);
            this.groupBox2.Controls.Add(this.PicBoxReparto3);
            this.groupBox2.Controls.Add(this.CBoxReparto1);
            this.groupBox2.Controls.Add(this.CBoxReparto2);
            this.groupBox2.Controls.Add(this.CBoxReparto3);
            this.groupBox2.Controls.Add(this.CBoxDirector);
            this.groupBox2.Location = new System.Drawing.Point(243, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(894, 237);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reparto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Reparto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Director";
            // 
            // PicBoxReparto2
            // 
            this.PicBoxReparto2.Location = new System.Drawing.Point(459, 69);
            this.PicBoxReparto2.Name = "PicBoxReparto2";
            this.PicBoxReparto2.Size = new System.Drawing.Size(121, 157);
            this.PicBoxReparto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxReparto2.TabIndex = 15;
            this.PicBoxReparto2.TabStop = false;
            // 
            // PicBoxReparto1
            // 
            this.PicBoxReparto1.Location = new System.Drawing.Point(277, 69);
            this.PicBoxReparto1.Name = "PicBoxReparto1";
            this.PicBoxReparto1.Size = new System.Drawing.Size(121, 157);
            this.PicBoxReparto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxReparto1.TabIndex = 14;
            this.PicBoxReparto1.TabStop = false;
            // 
            // PicBoxDirector
            // 
            this.PicBoxDirector.Location = new System.Drawing.Point(34, 69);
            this.PicBoxDirector.Name = "PicBoxDirector";
            this.PicBoxDirector.Size = new System.Drawing.Size(121, 157);
            this.PicBoxDirector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxDirector.TabIndex = 13;
            this.PicBoxDirector.TabStop = false;
            // 
            // PicBoxReparto3
            // 
            this.PicBoxReparto3.Location = new System.Drawing.Point(637, 69);
            this.PicBoxReparto3.Name = "PicBoxReparto3";
            this.PicBoxReparto3.Size = new System.Drawing.Size(121, 157);
            this.PicBoxReparto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxReparto3.TabIndex = 12;
            this.PicBoxReparto3.TabStop = false;
            // 
            // CBoxReparto1
            // 
            this.CBoxReparto1.FormattingEnabled = true;
            this.CBoxReparto1.Location = new System.Drawing.Point(277, 42);
            this.CBoxReparto1.Name = "CBoxReparto1";
            this.CBoxReparto1.Size = new System.Drawing.Size(121, 21);
            this.CBoxReparto1.TabIndex = 11;
            this.CBoxReparto1.SelectedIndexChanged += new System.EventHandler(this.CBoxReparto1_SelectedIndexChanged);
            // 
            // CBoxReparto2
            // 
            this.CBoxReparto2.FormattingEnabled = true;
            this.CBoxReparto2.Location = new System.Drawing.Point(459, 42);
            this.CBoxReparto2.Name = "CBoxReparto2";
            this.CBoxReparto2.Size = new System.Drawing.Size(121, 21);
            this.CBoxReparto2.TabIndex = 10;
            this.CBoxReparto2.SelectedIndexChanged += new System.EventHandler(this.CBoxReparto2_SelectedIndexChanged);
            // 
            // CBoxReparto3
            // 
            this.CBoxReparto3.FormattingEnabled = true;
            this.CBoxReparto3.Location = new System.Drawing.Point(637, 42);
            this.CBoxReparto3.Name = "CBoxReparto3";
            this.CBoxReparto3.Size = new System.Drawing.Size(121, 21);
            this.CBoxReparto3.TabIndex = 9;
            this.CBoxReparto3.SelectedIndexChanged += new System.EventHandler(this.CBoxReparto3_SelectedIndexChanged);
            // 
            // CBoxDirector
            // 
            this.CBoxDirector.FormattingEnabled = true;
            this.CBoxDirector.Location = new System.Drawing.Point(34, 42);
            this.CBoxDirector.Name = "CBoxDirector";
            this.CBoxDirector.Size = new System.Drawing.Size(121, 21);
            this.CBoxDirector.TabIndex = 8;
            this.CBoxDirector.SelectedIndexChanged += new System.EventHandler(this.CBoxDirector_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListBoxTodosGeneros);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ListBoxGenerosSeleccionados);
            this.groupBox1.Location = new System.Drawing.Point(732, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 272);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generos";
            // 
            // ListBoxTodosGeneros
            // 
            this.ListBoxTodosGeneros.FormattingEnabled = true;
            this.ListBoxTodosGeneros.Items.AddRange(new object[] {
            "ACCION",
            "DRAMA",
            "AVENTURA",
            "COMEDIA",
            "CRIMEN",
            "FANTASIA",
            "HISTORICA",
            "TERROR",
            "ROMANCE",
            "SATIRA",
            "THRILLER",
            "WESTERN"});
            this.ListBoxTodosGeneros.Location = new System.Drawing.Point(241, 59);
            this.ListBoxTodosGeneros.Name = "ListBoxTodosGeneros";
            this.ListBoxTodosGeneros.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBoxTodosGeneros.Size = new System.Drawing.Size(148, 199);
            this.ListBoxTodosGeneros.TabIndex = 19;
            this.ListBoxTodosGeneros.DoubleClick += new System.EventHandler(this.ListBoxTodosGeneros_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Generos Disponibles";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Generos Seleccionados";
            // 
            // ListBoxGenerosSeleccionados
            // 
            this.ListBoxGenerosSeleccionados.FormattingEnabled = true;
            this.ListBoxGenerosSeleccionados.Location = new System.Drawing.Point(22, 59);
            this.ListBoxGenerosSeleccionados.Name = "ListBoxGenerosSeleccionados";
            this.ListBoxGenerosSeleccionados.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBoxGenerosSeleccionados.Size = new System.Drawing.Size(148, 199);
            this.ListBoxGenerosSeleccionados.TabIndex = 18;
            this.ListBoxGenerosSeleccionados.DoubleClick += new System.EventHandler(this.ListBoxGenerosSeleccionados_DoubleClick);
            // 
            // BtnCambiarPortada
            // 
            this.BtnCambiarPortada.Location = new System.Drawing.Point(24, 285);
            this.BtnCambiarPortada.Name = "BtnCambiarPortada";
            this.BtnCambiarPortada.Size = new System.Drawing.Size(192, 31);
            this.BtnCambiarPortada.TabIndex = 7;
            this.BtnCambiarPortada.Text = "Cambiar Portada";
            this.BtnCambiarPortada.UseVisualStyleBackColor = true;
            this.BtnCambiarPortada.Click += new System.EventHandler(this.BtnCambiarPortada_Click);
            // 
            // PicBoxPortada
            // 
            this.PicBoxPortada.Location = new System.Drawing.Point(23, 7);
            this.PicBoxPortada.Name = "PicBoxPortada";
            this.PicBoxPortada.Size = new System.Drawing.Size(193, 272);
            this.PicBoxPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxPortada.TabIndex = 6;
            this.PicBoxPortada.TabStop = false;
            // 
            // editarReparto
            // 
            this.editarReparto.Controls.Add(this.BtnEliminarReparto);
            this.editarReparto.Controls.Add(this.BtnCancelarReparto);
            this.editarReparto.Controls.Add(this.BtnAceptarReparto);
            this.editarReparto.Controls.Add(this.label9);
            this.editarReparto.Controls.Add(this.TxtBoxNombreReparto);
            this.editarReparto.Controls.Add(this.BtnCambiarImagenReparto);
            this.editarReparto.Controls.Add(this.PicBoxPortadaRetrato);
            this.editarReparto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editarReparto.Location = new System.Drawing.Point(0, 24);
            this.editarReparto.Name = "editarReparto";
            this.editarReparto.Size = new System.Drawing.Size(1149, 545);
            this.editarReparto.TabIndex = 1;
            // 
            // BtnEliminarReparto
            // 
            this.BtnEliminarReparto.Location = new System.Drawing.Point(393, 500);
            this.BtnEliminarReparto.Name = "BtnEliminarReparto";
            this.BtnEliminarReparto.Size = new System.Drawing.Size(130, 35);
            this.BtnEliminarReparto.TabIndex = 6;
            this.BtnEliminarReparto.Text = "Eliminar";
            this.BtnEliminarReparto.UseVisualStyleBackColor = true;
            this.BtnEliminarReparto.Visible = false;
            this.BtnEliminarReparto.Click += new System.EventHandler(this.BtnEliminarReparto_Click);
            // 
            // BtnCancelarReparto
            // 
            this.BtnCancelarReparto.Location = new System.Drawing.Point(222, 500);
            this.BtnCancelarReparto.Name = "BtnCancelarReparto";
            this.BtnCancelarReparto.Size = new System.Drawing.Size(130, 35);
            this.BtnCancelarReparto.TabIndex = 5;
            this.BtnCancelarReparto.Text = "Cancelar";
            this.BtnCancelarReparto.UseVisualStyleBackColor = true;
            this.BtnCancelarReparto.Click += new System.EventHandler(this.BtnCancelarReparto_Click);
            // 
            // BtnAceptarReparto
            // 
            this.BtnAceptarReparto.Location = new System.Drawing.Point(50, 500);
            this.BtnAceptarReparto.Name = "BtnAceptarReparto";
            this.BtnAceptarReparto.Size = new System.Drawing.Size(130, 35);
            this.BtnAceptarReparto.TabIndex = 4;
            this.BtnAceptarReparto.Text = "Aceptar";
            this.BtnAceptarReparto.UseVisualStyleBackColor = true;
            this.BtnAceptarReparto.Click += new System.EventHandler(this.BtnAceptarReparto_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(298, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Nombre";
            // 
            // TxtBoxNombreReparto
            // 
            this.TxtBoxNombreReparto.Location = new System.Drawing.Point(301, 92);
            this.TxtBoxNombreReparto.Name = "TxtBoxNombreReparto";
            this.TxtBoxNombreReparto.Size = new System.Drawing.Size(179, 20);
            this.TxtBoxNombreReparto.TabIndex = 2;
            // 
            // BtnCambiarImagenReparto
            // 
            this.BtnCambiarImagenReparto.Location = new System.Drawing.Point(50, 352);
            this.BtnCambiarImagenReparto.Name = "BtnCambiarImagenReparto";
            this.BtnCambiarImagenReparto.Size = new System.Drawing.Size(211, 33);
            this.BtnCambiarImagenReparto.TabIndex = 1;
            this.BtnCambiarImagenReparto.Text = "Cambiar Imagen";
            this.BtnCambiarImagenReparto.UseVisualStyleBackColor = true;
            this.BtnCambiarImagenReparto.Click += new System.EventHandler(this.BtnCambiarImagenReparto_Click);
            // 
            // PicBoxPortadaRetrato
            // 
            this.PicBoxPortadaRetrato.Location = new System.Drawing.Point(50, 29);
            this.PicBoxPortadaRetrato.Name = "PicBoxPortadaRetrato";
            this.PicBoxPortadaRetrato.Size = new System.Drawing.Size(212, 296);
            this.PicBoxPortadaRetrato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxPortadaRetrato.TabIndex = 0;
            this.PicBoxPortadaRetrato.TabStop = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(1149, 569);
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.editarReparto);
            this.Controls.Add(this.editarPelicula);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.Text = "Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.adminPanel.ResumeLayout(false);
            this.adminPanel.PerformLayout();
            this.editarPelicula.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxReparto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxReparto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxDirector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxReparto3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxPortada)).EndInit();
            this.editarReparto.ResumeLayout(false);
            this.editarReparto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxPortadaRetrato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem repartoList;
        private System.Windows.Forms.ToolStripMenuItem verReparto;
        private System.Windows.Forms.ToolStripMenuItem crearReparto;
        private System.Windows.Forms.ToolStripMenuItem peliculasList;
        private System.Windows.Forms.ToolStripMenuItem verPeliculas;
        private System.Windows.Forms.ToolStripMenuItem crearPeliculas;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.ToolStripMenuItem inicio;
        private System.Windows.Forms.Panel editarPelicula;
        private System.Windows.Forms.Panel editarReparto;
        private System.Windows.Forms.TextBox TxtBoxTitulo;
        private System.Windows.Forms.TextBox TxtBoxValoracion;
        private System.Windows.Forms.RichTextBox TxtBoxDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCambiarPortada;
        private System.Windows.Forms.PictureBox PicBoxPortada;
        private System.Windows.Forms.ComboBox CBoxReparto1;
        private System.Windows.Forms.ComboBox CBoxReparto2;
        private System.Windows.Forms.ComboBox CBoxReparto3;
        private System.Windows.Forms.ComboBox CBoxDirector;
        private System.Windows.Forms.PictureBox PicBoxReparto2;
        private System.Windows.Forms.PictureBox PicBoxReparto1;
        private System.Windows.Forms.PictureBox PicBoxDirector;
        private System.Windows.Forms.PictureBox PicBoxReparto3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox ListBoxGenerosSeleccionados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox ListBoxTodosGeneros;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtBoxAño;
        private System.Windows.Forms.TextBox TxtBoxNombreReparto;
        private System.Windows.Forms.Button BtnCambiarImagenReparto;
        private System.Windows.Forms.PictureBox PicBoxPortadaRetrato;
        private System.Windows.Forms.Button BtnCancelarReparto;
        private System.Windows.Forms.Button BtnAceptarReparto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnEliminarReparto;
        private System.Windows.Forms.Button BtnEliminarPelicula;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblEstadoServicio;
        private System.Windows.Forms.Button BtnIniciarServicio;
        private System.Windows.Forms.Button BtnPararServicio;
    }
}
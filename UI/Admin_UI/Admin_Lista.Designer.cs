
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
            this.components = new System.ComponentModel.Container();
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
            this.editarPelicula = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picBoxReparto2 = new System.Windows.Forms.PictureBox();
            this.picBoxReparto1 = new System.Windows.Forms.PictureBox();
            this.picBoxDirector = new System.Windows.Forms.PictureBox();
            this.picBoxReparto3 = new System.Windows.Forms.PictureBox();
            this.cBoxReparto1 = new System.Windows.Forms.ComboBox();
            this.cBoxReparto2 = new System.Windows.Forms.ComboBox();
            this.cBoxReparto3 = new System.Windows.Forms.ComboBox();
            this.cBoxDirector = new System.Windows.Forms.ComboBox();
            this.btnCambiarPortada = new System.Windows.Forms.Button();
            this.picBoxPortada = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxTitulo = new System.Windows.Forms.TextBox();
            this.txtBoxValoracion = new System.Windows.Forms.TextBox();
            this.txtBoxDescripcion = new System.Windows.Forms.RichTextBox();
            this.editarReparto = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.editarPelicula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxReparto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxReparto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDirector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxReparto3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPortada)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(920, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicio
            // 
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(48, 20);
            this.inicio.Text = "Inicio";
            this.inicio.Click += new System.EventHandler(this.inicio_Click);
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
            this.verPeliculas.Size = new System.Drawing.Size(151, 22);
            this.verPeliculas.Text = "Ver Peliculas";
            this.verPeliculas.Click += new System.EventHandler(this.verPeliculas_Click);
            // 
            // crearPeliculas
            // 
            this.crearPeliculas.Name = "crearPeliculas";
            this.crearPeliculas.Size = new System.Drawing.Size(151, 22);
            this.crearPeliculas.Text = "Crear Peliculas";
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
            this.verReparto.Click += new System.EventHandler(this.verReparto_Click);
            // 
            // crearReparto
            // 
            this.crearReparto.Name = "crearReparto";
            this.crearReparto.Size = new System.Drawing.Size(146, 22);
            this.crearReparto.Text = "Crear Reparto";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(920, 519);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // adminPanel
            // 
            this.adminPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminPanel.Location = new System.Drawing.Point(0, 24);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(920, 519);
            this.adminPanel.TabIndex = 0;
            // 
            // editarPelicula
            // 
            this.editarPelicula.Controls.Add(this.label5);
            this.editarPelicula.Controls.Add(this.label4);
            this.editarPelicula.Controls.Add(this.picBoxReparto2);
            this.editarPelicula.Controls.Add(this.picBoxReparto1);
            this.editarPelicula.Controls.Add(this.picBoxDirector);
            this.editarPelicula.Controls.Add(this.picBoxReparto3);
            this.editarPelicula.Controls.Add(this.cBoxReparto1);
            this.editarPelicula.Controls.Add(this.cBoxReparto2);
            this.editarPelicula.Controls.Add(this.cBoxReparto3);
            this.editarPelicula.Controls.Add(this.cBoxDirector);
            this.editarPelicula.Controls.Add(this.btnCambiarPortada);
            this.editarPelicula.Controls.Add(this.picBoxPortada);
            this.editarPelicula.Controls.Add(this.label3);
            this.editarPelicula.Controls.Add(this.label2);
            this.editarPelicula.Controls.Add(this.label1);
            this.editarPelicula.Controls.Add(this.txtBoxTitulo);
            this.editarPelicula.Controls.Add(this.txtBoxValoracion);
            this.editarPelicula.Controls.Add(this.txtBoxDescripcion);
            this.editarPelicula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editarPelicula.Location = new System.Drawing.Point(0, 24);
            this.editarPelicula.Name = "editarPelicula";
            this.editarPelicula.Size = new System.Drawing.Size(920, 519);
            this.editarPelicula.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(645, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Reparto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Director";
            // 
            // picBoxReparto2
            // 
            this.picBoxReparto2.Location = new System.Drawing.Point(648, 340);
            this.picBoxReparto2.Name = "picBoxReparto2";
            this.picBoxReparto2.Size = new System.Drawing.Size(121, 157);
            this.picBoxReparto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxReparto2.TabIndex = 15;
            this.picBoxReparto2.TabStop = false;
            // 
            // picBoxReparto1
            // 
            this.picBoxReparto1.Location = new System.Drawing.Point(521, 340);
            this.picBoxReparto1.Name = "picBoxReparto1";
            this.picBoxReparto1.Size = new System.Drawing.Size(121, 157);
            this.picBoxReparto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxReparto1.TabIndex = 14;
            this.picBoxReparto1.TabStop = false;
            // 
            // picBoxDirector
            // 
            this.picBoxDirector.Location = new System.Drawing.Point(368, 340);
            this.picBoxDirector.Name = "picBoxDirector";
            this.picBoxDirector.Size = new System.Drawing.Size(121, 157);
            this.picBoxDirector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxDirector.TabIndex = 13;
            this.picBoxDirector.TabStop = false;
            // 
            // picBoxReparto3
            // 
            this.picBoxReparto3.Location = new System.Drawing.Point(775, 340);
            this.picBoxReparto3.Name = "picBoxReparto3";
            this.picBoxReparto3.Size = new System.Drawing.Size(121, 157);
            this.picBoxReparto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxReparto3.TabIndex = 12;
            this.picBoxReparto3.TabStop = false;
            // 
            // cBoxReparto1
            // 
            this.cBoxReparto1.FormattingEnabled = true;
            this.cBoxReparto1.Location = new System.Drawing.Point(521, 313);
            this.cBoxReparto1.Name = "cBoxReparto1";
            this.cBoxReparto1.Size = new System.Drawing.Size(121, 21);
            this.cBoxReparto1.TabIndex = 11;
            // 
            // cBoxReparto2
            // 
            this.cBoxReparto2.FormattingEnabled = true;
            this.cBoxReparto2.Location = new System.Drawing.Point(648, 313);
            this.cBoxReparto2.Name = "cBoxReparto2";
            this.cBoxReparto2.Size = new System.Drawing.Size(121, 21);
            this.cBoxReparto2.TabIndex = 10;
            // 
            // cBoxReparto3
            // 
            this.cBoxReparto3.FormattingEnabled = true;
            this.cBoxReparto3.Location = new System.Drawing.Point(775, 313);
            this.cBoxReparto3.Name = "cBoxReparto3";
            this.cBoxReparto3.Size = new System.Drawing.Size(121, 21);
            this.cBoxReparto3.TabIndex = 9;
            // 
            // cBoxDirector
            // 
            this.cBoxDirector.FormattingEnabled = true;
            this.cBoxDirector.Location = new System.Drawing.Point(368, 313);
            this.cBoxDirector.Name = "cBoxDirector";
            this.cBoxDirector.Size = new System.Drawing.Size(121, 21);
            this.cBoxDirector.TabIndex = 8;
            // 
            // btnCambiarPortada
            // 
            this.btnCambiarPortada.Location = new System.Drawing.Point(39, 319);
            this.btnCambiarPortada.Name = "btnCambiarPortada";
            this.btnCambiarPortada.Size = new System.Drawing.Size(192, 31);
            this.btnCambiarPortada.TabIndex = 7;
            this.btnCambiarPortada.Text = "Cambiar Portada";
            this.btnCambiarPortada.UseVisualStyleBackColor = true;
            this.btnCambiarPortada.Click += new System.EventHandler(this.btnCambiarPortada_Click);
            // 
            // picBoxPortada
            // 
            this.picBoxPortada.Location = new System.Drawing.Point(38, 29);
            this.picBoxPortada.Name = "picBoxPortada";
            this.picBoxPortada.Size = new System.Drawing.Size(193, 272);
            this.picBoxPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPortada.TabIndex = 6;
            this.picBoxPortada.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Titulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valoracion";
            // 
            // txtBoxTitulo
            // 
            this.txtBoxTitulo.Location = new System.Drawing.Point(433, 56);
            this.txtBoxTitulo.Name = "txtBoxTitulo";
            this.txtBoxTitulo.Size = new System.Drawing.Size(190, 20);
            this.txtBoxTitulo.TabIndex = 2;
            // 
            // txtBoxValoracion
            // 
            this.txtBoxValoracion.Location = new System.Drawing.Point(433, 16);
            this.txtBoxValoracion.Name = "txtBoxValoracion";
            this.txtBoxValoracion.Size = new System.Drawing.Size(50, 20);
            this.txtBoxValoracion.TabIndex = 1;
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Location = new System.Drawing.Point(433, 106);
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(355, 154);
            this.txtBoxDescripcion.TabIndex = 0;
            this.txtBoxDescripcion.Text = "";
            // 
            // editarReparto
            // 
            this.editarReparto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editarReparto.Location = new System.Drawing.Point(0, 24);
            this.editarReparto.Name = "editarReparto";
            this.editarReparto.Size = new System.Drawing.Size(920, 519);
            this.editarReparto.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(920, 543);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.editarPelicula);
            this.Controls.Add(this.editarReparto);
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.Text = "Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.editarPelicula.ResumeLayout(false);
            this.editarPelicula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxReparto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxReparto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDirector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxReparto3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPortada)).EndInit();
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
        private System.Windows.Forms.TextBox txtBoxTitulo;
        private System.Windows.Forms.TextBox txtBoxValoracion;
        private System.Windows.Forms.RichTextBox txtBoxDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCambiarPortada;
        private System.Windows.Forms.PictureBox picBoxPortada;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cBoxReparto1;
        private System.Windows.Forms.ComboBox cBoxReparto2;
        private System.Windows.Forms.ComboBox cBoxReparto3;
        private System.Windows.Forms.ComboBox cBoxDirector;
        private System.Windows.Forms.PictureBox picBoxReparto2;
        private System.Windows.Forms.PictureBox picBoxReparto1;
        private System.Windows.Forms.PictureBox picBoxDirector;
        private System.Windows.Forms.PictureBox picBoxReparto3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}
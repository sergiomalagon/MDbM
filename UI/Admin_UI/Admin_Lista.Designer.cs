
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
            this.repartoList = new System.Windows.Forms.ToolStripMenuItem();
            this.verReparto = new System.Windows.Forms.ToolStripMenuItem();
            this.crearReparto = new System.Windows.Forms.ToolStripMenuItem();
            this.peliculasList = new System.Windows.Forms.ToolStripMenuItem();
            this.verPeliculas = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPeliculas = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.inicio = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.verReparto.Size = new System.Drawing.Size(180, 22);
            this.verReparto.Text = "Ver Reparto";
            this.verReparto.Click += new System.EventHandler(this.verReparto_Click);
            // 
            // crearReparto
            // 
            this.crearReparto.Name = "crearReparto";
            this.crearReparto.Size = new System.Drawing.Size(180, 22);
            this.crearReparto.Text = "Crear Reparto";
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
            this.verPeliculas.Size = new System.Drawing.Size(180, 22);
            this.verPeliculas.Text = "Ver Peliculas";
            this.verPeliculas.Click += new System.EventHandler(this.verPeliculas_Click);
            // 
            // crearPeliculas
            // 
            this.crearPeliculas.Name = "crearPeliculas";
            this.crearPeliculas.Size = new System.Drawing.Size(180, 22);
            this.crearPeliculas.Text = "Crear Peliculas";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(800, 426);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // adminPanel
            // 
            this.adminPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminPanel.Location = new System.Drawing.Point(0, 24);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(800, 426);
            this.adminPanel.TabIndex = 0;
            // 
            // inicio
            // 
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(48, 20);
            this.inicio.Text = "Inicio";
            this.inicio.Click += new System.EventHandler(this.inicio_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.Text = "Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}
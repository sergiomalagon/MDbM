
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
            this.repartoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verRepartoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearRepartoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peliculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPeliculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPeliculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repartoToolStripMenuItem,
            this.peliculasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // repartoToolStripMenuItem
            // 
            this.repartoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verRepartoToolStripMenuItem,
            this.crearRepartoToolStripMenuItem});
            this.repartoToolStripMenuItem.Name = "repartoToolStripMenuItem";
            this.repartoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.repartoToolStripMenuItem.Text = "Reparto";
            // 
            // verRepartoToolStripMenuItem
            // 
            this.verRepartoToolStripMenuItem.Name = "verRepartoToolStripMenuItem";
            this.verRepartoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verRepartoToolStripMenuItem.Text = "Ver Reparto";
            this.verRepartoToolStripMenuItem.Click += new System.EventHandler(this.verRepartoToolStripMenuItem_Click);
            // 
            // crearRepartoToolStripMenuItem
            // 
            this.crearRepartoToolStripMenuItem.Name = "crearRepartoToolStripMenuItem";
            this.crearRepartoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearRepartoToolStripMenuItem.Text = "Crear Reparto";
            // 
            // peliculasToolStripMenuItem
            // 
            this.peliculasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPeliculasToolStripMenuItem,
            this.crearPeliculasToolStripMenuItem});
            this.peliculasToolStripMenuItem.Name = "peliculasToolStripMenuItem";
            this.peliculasToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.peliculasToolStripMenuItem.Text = "Peliculas";
            // 
            // verPeliculasToolStripMenuItem
            // 
            this.verPeliculasToolStripMenuItem.Name = "verPeliculasToolStripMenuItem";
            this.verPeliculasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verPeliculasToolStripMenuItem.Text = "Ver Peliculas";
            this.verPeliculasToolStripMenuItem.Click += new System.EventHandler(this.verPeliculasToolStripMenuItem_Click);
            // 
            // crearPeliculasToolStripMenuItem
            // 
            this.crearPeliculasToolStripMenuItem.Name = "crearPeliculasToolStripMenuItem";
            this.crearPeliculasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearPeliculasToolStripMenuItem.Text = "Crear Peliculas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(748, 114);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido [admin]";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 426);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 426);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(800, 426);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.Text = "Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem repartoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verRepartoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearRepartoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peliculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPeliculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearPeliculasToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}
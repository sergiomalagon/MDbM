
namespace MDbM.UI.LoginUI
{
    partial class Login
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
            this.TxtBoxLoginUsuario = new System.Windows.Forms.TextBox();
            this.TxtBoxLoginPassword = new System.Windows.Forms.TextBox();
            this.PanelLoginPassword = new System.Windows.Forms.Panel();
            this.PanelLoginUsuario = new System.Windows.Forms.Panel();
            this.PanelIcono = new System.Windows.Forms.Panel();
            this.ImgPerfil = new ImagenPerfil.ImgPerfil();
            this.BtnImagenUsuario = new System.Windows.Forms.Button();
            this.PanelControlVentana = new System.Windows.Forms.Panel();
            this.LblClose = new System.Windows.Forms.Label();
            this.LblMinimize = new System.Windows.Forms.Label();
            this.BtnLoginRegistrer = new System.Windows.Forms.Button();
            this.LblMensaje = new System.Windows.Forms.Label();
            this.PanelIcono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPerfil)).BeginInit();
            this.PanelControlVentana.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtBoxLoginUsuario
            // 
            this.TxtBoxLoginUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(110)))));
            this.TxtBoxLoginUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxLoginUsuario.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxLoginUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.TxtBoxLoginUsuario.Location = new System.Drawing.Point(343, 76);
            this.TxtBoxLoginUsuario.MaxLength = 15;
            this.TxtBoxLoginUsuario.Name = "TxtBoxLoginUsuario";
            this.TxtBoxLoginUsuario.Size = new System.Drawing.Size(624, 44);
            this.TxtBoxLoginUsuario.TabIndex = 1;
            this.TxtBoxLoginUsuario.Text = "Usuario...";
            this.TxtBoxLoginUsuario.Enter += new System.EventHandler(this.TxtBoxLoginUsuario_Enter);
            this.TxtBoxLoginUsuario.Leave += new System.EventHandler(this.TxtBoxLoginUsuario_Leave);
            // 
            // TxtBoxLoginPassword
            // 
            this.TxtBoxLoginPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(110)))));
            this.TxtBoxLoginPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxLoginPassword.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxLoginPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.TxtBoxLoginPassword.Location = new System.Drawing.Point(343, 189);
            this.TxtBoxLoginPassword.MaxLength = 15;
            this.TxtBoxLoginPassword.Name = "TxtBoxLoginPassword";
            this.TxtBoxLoginPassword.Size = new System.Drawing.Size(624, 44);
            this.TxtBoxLoginPassword.TabIndex = 2;
            this.TxtBoxLoginPassword.Text = "Contraseña...";
            this.TxtBoxLoginPassword.Enter += new System.EventHandler(this.TxtBoxLoginPassword_Enter);
            this.TxtBoxLoginPassword.Leave += new System.EventHandler(this.TxtBoxLoginPassword_Leave);
            // 
            // PanelLoginPassword
            // 
            this.PanelLoginPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(228)))), ((int)(((byte)(24)))));
            this.PanelLoginPassword.Location = new System.Drawing.Point(343, 239);
            this.PanelLoginPassword.Name = "PanelLoginPassword";
            this.PanelLoginPassword.Size = new System.Drawing.Size(624, 3);
            this.PanelLoginPassword.TabIndex = 3;
            // 
            // PanelLoginUsuario
            // 
            this.PanelLoginUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(228)))), ((int)(((byte)(24)))));
            this.PanelLoginUsuario.Location = new System.Drawing.Point(343, 126);
            this.PanelLoginUsuario.Name = "PanelLoginUsuario";
            this.PanelLoginUsuario.Size = new System.Drawing.Size(624, 3);
            this.PanelLoginUsuario.TabIndex = 1;
            // 
            // PanelIcono
            // 
            this.PanelIcono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PanelIcono.Controls.Add(this.ImgPerfil);
            this.PanelIcono.Controls.Add(this.BtnImagenUsuario);
            this.PanelIcono.Location = new System.Drawing.Point(26, 76);
            this.PanelIcono.Name = "PanelIcono";
            this.PanelIcono.Size = new System.Drawing.Size(290, 270);
            this.PanelIcono.TabIndex = 999;
            // 
            // ImgPerfil
            // 
            this.ImgPerfil.BackColor = System.Drawing.Color.DarkGray;
            this.ImgPerfil.Location = new System.Drawing.Point(21, 11);
            this.ImgPerfil.Name = "ImgPerfil";
            this.ImgPerfil.Size = new System.Drawing.Size(250, 250);
            this.ImgPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgPerfil.TabIndex = 0;
            this.ImgPerfil.TabStop = false;
            // 
            // BtnImagenUsuario
            // 
            this.BtnImagenUsuario.AutoSize = true;
            this.BtnImagenUsuario.BackColor = System.Drawing.Color.Black;
            this.BtnImagenUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImagenUsuario.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImagenUsuario.ForeColor = System.Drawing.Color.White;
            this.BtnImagenUsuario.Location = new System.Drawing.Point(108, 123);
            this.BtnImagenUsuario.Name = "BtnImagenUsuario";
            this.BtnImagenUsuario.Size = new System.Drawing.Size(75, 34);
            this.BtnImagenUsuario.TabIndex = 1;
            this.BtnImagenUsuario.Text = "SUBIR";
            this.BtnImagenUsuario.UseVisualStyleBackColor = false;
            this.BtnImagenUsuario.Click += new System.EventHandler(this.BtnImagenUsuario_Click);
            // 
            // PanelControlVentana
            // 
            this.PanelControlVentana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.PanelControlVentana.Controls.Add(this.LblClose);
            this.PanelControlVentana.Controls.Add(this.LblMinimize);
            this.PanelControlVentana.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelControlVentana.Location = new System.Drawing.Point(0, 0);
            this.PanelControlVentana.Name = "PanelControlVentana";
            this.PanelControlVentana.Size = new System.Drawing.Size(979, 42);
            this.PanelControlVentana.TabIndex = 6;
            this.PanelControlVentana.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBarraControlVentana_MouseDown);
            // 
            // LblClose
            // 
            this.LblClose.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClose.ForeColor = System.Drawing.Color.White;
            this.LblClose.Location = new System.Drawing.Point(903, -4);
            this.LblClose.Name = "LblClose";
            this.LblClose.Size = new System.Drawing.Size(83, 51);
            this.LblClose.TabIndex = 0;
            this.LblClose.Text = "X";
            this.LblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblClose.Click += new System.EventHandler(this.LblClose_Click);
            this.LblClose.MouseEnter += new System.EventHandler(this.LblClose_MouseEnter);
            this.LblClose.MouseLeave += new System.EventHandler(this.LblClose_MouseLeave);
            // 
            // LblMinimize
            // 
            this.LblMinimize.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMinimize.ForeColor = System.Drawing.Color.White;
            this.LblMinimize.Location = new System.Drawing.Point(827, -14);
            this.LblMinimize.Name = "LblMinimize";
            this.LblMinimize.Size = new System.Drawing.Size(79, 61);
            this.LblMinimize.TabIndex = 1;
            this.LblMinimize.Text = "-";
            this.LblMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblMinimize.Click += new System.EventHandler(this.LblMinimize_Click);
            this.LblMinimize.MouseEnter += new System.EventHandler(this.LblMinimize_MouseEnter);
            this.LblMinimize.MouseLeave += new System.EventHandler(this.LblMinimize_MouseLeave);
            // 
            // BtnLoginRegistrer
            // 
            this.BtnLoginRegistrer.AutoSize = true;
            this.BtnLoginRegistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(228)))), ((int)(((byte)(24)))));
            this.BtnLoginRegistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoginRegistrer.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoginRegistrer.Location = new System.Drawing.Point(343, 291);
            this.BtnLoginRegistrer.Name = "BtnLoginRegistrer";
            this.BtnLoginRegistrer.Size = new System.Drawing.Size(624, 55);
            this.BtnLoginRegistrer.TabIndex = 3;
            this.BtnLoginRegistrer.Text = "LOGIN/REGISTRER";
            this.BtnLoginRegistrer.UseVisualStyleBackColor = false;
            this.BtnLoginRegistrer.Click += new System.EventHandler(this.BtnLoginRegistrer_Click);
            // 
            // LblMensaje
            // 
            this.LblMensaje.AutoSize = true;
            this.LblMensaje.Font = new System.Drawing.Font("Eras Medium ITC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMensaje.ForeColor = System.Drawing.Color.DarkRed;
            this.LblMensaje.Location = new System.Drawing.Point(340, 260);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(44, 17);
            this.LblMensaje.TabIndex = 1000;
            this.LblMensaje.Text = "label1";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(979, 364);
            this.Controls.Add(this.LblMensaje);
            this.Controls.Add(this.PanelControlVentana);
            this.Controls.Add(this.BtnLoginRegistrer);
            this.Controls.Add(this.PanelIcono);
            this.Controls.Add(this.TxtBoxLoginPassword);
            this.Controls.Add(this.PanelLoginPassword);
            this.Controls.Add(this.TxtBoxLoginUsuario);
            this.Controls.Add(this.PanelLoginUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MdbM";
            this.PanelIcono.ResumeLayout(false);
            this.PanelIcono.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPerfil)).EndInit();
            this.PanelControlVentana.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBoxLoginUsuario;
        private System.Windows.Forms.TextBox TxtBoxLoginPassword;
        private System.Windows.Forms.Panel PanelLoginPassword;
        private System.Windows.Forms.Panel PanelLoginUsuario;
        private System.Windows.Forms.Panel PanelIcono;
        private System.Windows.Forms.Panel PanelControlVentana;
        private System.Windows.Forms.Label LblClose;
        private System.Windows.Forms.Label LblMinimize;
        private System.Windows.Forms.Button BtnLoginRegistrer;
        private System.Windows.Forms.Label LblMensaje;
        private ImagenPerfil.ImgPerfil ImgPerfil;
        private System.Windows.Forms.Button BtnImagenUsuario;
    }
}


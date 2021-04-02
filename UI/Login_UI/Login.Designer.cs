
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
            this.txtBoxLoginUsuario = new System.Windows.Forms.TextBox();
            this.txtBoxLoginPassword = new System.Windows.Forms.TextBox();
            this.panelLoginPassword = new System.Windows.Forms.Panel();
            this.panelLoginUsuario = new System.Windows.Forms.Panel();
            this.panelIcono = new System.Windows.Forms.Panel();
            this.panelControlVentana = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.btnLoginRegistrer = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.panelControlVentana.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxLoginUsuario
            // 
            this.txtBoxLoginUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(110)))));
            this.txtBoxLoginUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxLoginUsuario.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLoginUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.txtBoxLoginUsuario.Location = new System.Drawing.Point(343, 76);
            this.txtBoxLoginUsuario.MaxLength = 15;
            this.txtBoxLoginUsuario.Name = "txtBoxLoginUsuario";
            this.txtBoxLoginUsuario.Size = new System.Drawing.Size(624, 44);
            this.txtBoxLoginUsuario.TabIndex = 999;
            this.txtBoxLoginUsuario.Text = "Usuario...";
            this.txtBoxLoginUsuario.Enter += new System.EventHandler(this.txtBoxLoginUsuario_Enter);
            this.txtBoxLoginUsuario.Leave += new System.EventHandler(this.txtBoxLoginUsuario_Leave);
            // 
            // txtBoxLoginPassword
            // 
            this.txtBoxLoginPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(110)))));
            this.txtBoxLoginPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxLoginPassword.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLoginPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.txtBoxLoginPassword.Location = new System.Drawing.Point(343, 189);
            this.txtBoxLoginPassword.MaxLength = 15;
            this.txtBoxLoginPassword.Name = "txtBoxLoginPassword";
            this.txtBoxLoginPassword.Size = new System.Drawing.Size(624, 44);
            this.txtBoxLoginPassword.TabIndex = 999;
            this.txtBoxLoginPassword.Text = "Contraseña...";
            this.txtBoxLoginPassword.Enter += new System.EventHandler(this.txtBoxLoginPassword_Enter);
            this.txtBoxLoginPassword.Leave += new System.EventHandler(this.txtBoxLoginPassword_Leave);
            // 
            // panelLoginPassword
            // 
            this.panelLoginPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(228)))), ((int)(((byte)(24)))));
            this.panelLoginPassword.Location = new System.Drawing.Point(343, 239);
            this.panelLoginPassword.Name = "panelLoginPassword";
            this.panelLoginPassword.Size = new System.Drawing.Size(624, 3);
            this.panelLoginPassword.TabIndex = 3;
            // 
            // panelLoginUsuario
            // 
            this.panelLoginUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(228)))), ((int)(((byte)(24)))));
            this.panelLoginUsuario.Location = new System.Drawing.Point(343, 126);
            this.panelLoginUsuario.Name = "panelLoginUsuario";
            this.panelLoginUsuario.Size = new System.Drawing.Size(624, 3);
            this.panelLoginUsuario.TabIndex = 1;
            // 
            // panelIcono
            // 
            this.panelIcono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panelIcono.Location = new System.Drawing.Point(26, 76);
            this.panelIcono.Name = "panelIcono";
            this.panelIcono.Size = new System.Drawing.Size(290, 270);
            this.panelIcono.TabIndex = 999;
            // 
            // panelControlVentana
            // 
            this.panelControlVentana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.panelControlVentana.Controls.Add(this.lblClose);
            this.panelControlVentana.Controls.Add(this.lblMinimize);
            this.panelControlVentana.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlVentana.Location = new System.Drawing.Point(0, 0);
            this.panelControlVentana.Name = "panelControlVentana";
            this.panelControlVentana.Size = new System.Drawing.Size(979, 42);
            this.panelControlVentana.TabIndex = 6;
            this.panelControlVentana.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraControlVentana_MouseDown);
            // 
            // lblClose
            // 
            this.lblClose.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(903, -4);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(83, 51);
            this.lblClose.TabIndex = 0;
            this.lblClose.Text = "X";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblClose_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            // 
            // lblMinimize
            // 
            this.lblMinimize.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.White;
            this.lblMinimize.Location = new System.Drawing.Point(827, -14);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(79, 61);
            this.lblMinimize.TabIndex = 1;
            this.lblMinimize.Text = "-";
            this.lblMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            this.lblMinimize.MouseEnter += new System.EventHandler(this.lblMinimize_MouseEnter);
            this.lblMinimize.MouseLeave += new System.EventHandler(this.lblMinimize_MouseLeave);
            // 
            // btnLoginRegistrer
            // 
            this.btnLoginRegistrer.AutoSize = true;
            this.btnLoginRegistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(228)))), ((int)(((byte)(24)))));
            this.btnLoginRegistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginRegistrer.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginRegistrer.Location = new System.Drawing.Point(343, 291);
            this.btnLoginRegistrer.Name = "btnLoginRegistrer";
            this.btnLoginRegistrer.Size = new System.Drawing.Size(624, 55);
            this.btnLoginRegistrer.TabIndex = 999;
            this.btnLoginRegistrer.Text = "LOGIN/REGISTRER";
            this.btnLoginRegistrer.UseVisualStyleBackColor = false;
            this.btnLoginRegistrer.Click += new System.EventHandler(this.btnLoginRegistrer_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Eras Medium ITC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMensaje.Location = new System.Drawing.Point(340, 260);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(44, 17);
            this.lblMensaje.TabIndex = 1000;
            this.lblMensaje.Text = "label1";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(979, 364);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.panelControlVentana);
            this.Controls.Add(this.btnLoginRegistrer);
            this.Controls.Add(this.panelIcono);
            this.Controls.Add(this.txtBoxLoginPassword);
            this.Controls.Add(this.panelLoginPassword);
            this.Controls.Add(this.txtBoxLoginUsuario);
            this.Controls.Add(this.panelLoginUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MdbM";
            this.panelControlVentana.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxLoginUsuario;
        private System.Windows.Forms.TextBox txtBoxLoginPassword;
        private System.Windows.Forms.Panel panelLoginPassword;
        private System.Windows.Forms.Panel panelLoginUsuario;
        private System.Windows.Forms.Panel panelIcono;
        private System.Windows.Forms.Panel panelControlVentana;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Button btnLoginRegistrer;
        private System.Windows.Forms.Label lblMensaje;
    }
}


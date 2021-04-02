using MDbM.UI.Clases;
using MDbM.UI.MongoDB;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MDbM.UI.LoginUI
{
    public partial class Login : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private readonly Mongo db = new Mongo();
        private bool IsLogin = false;
        private bool IsValidUsername = false;
        private bool IsValidPassw = false;

        public Login()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            db.GetConexion();
            lblMensaje.Visible = false;
        }

        private void RegistrarUsuario(Usuario Usuario)
        {

        }

        private void IniciarSesion(Usuario Usuario)
        {

        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void panelBarraControlVentana_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtBoxLoginUsuario_Enter(object sender, EventArgs e)
        {
            if (txtBoxLoginUsuario.Text.Trim().Equals("Usuario..."))
            {
                txtBoxLoginUsuario.Text = "";
            }
        }

        private void txtBoxLoginUsuario_Leave(object sender, EventArgs e)
        {
            if (txtBoxLoginUsuario.Text.Trim().Equals(""))
            {
                txtBoxLoginUsuario.Text = "Usuario...";
                this.IsValidUsername = false;
            }
            else
            {
                if (db.ComprobarExisteUsuario(txtBoxLoginUsuario.Text.Trim()))
                {
                    btnLoginRegistrer.Text = "LOGIN";
                    lblMensaje.Visible = false;
                    this.IsLogin = true;
                }
                else
                {
                    btnLoginRegistrer.Text = "REGISTRER";
                    this.IsLogin = false;
                    lblMensaje.Text = "Advertencia!!!: Vas a crear un nuevo usuario";
                    lblMensaje.Visible = true;
                }
                this.IsValidUsername = true;
            }

        }

        private void txtBoxLoginPassword_Enter(object sender, EventArgs e)
        {
            if (txtBoxLoginPassword.Text.Trim().Equals("Contraseña..."))
            {
                txtBoxLoginPassword.Text = "";
                txtBoxLoginPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtBoxLoginPassword_Leave(object sender, EventArgs e)
        {
            if (txtBoxLoginPassword.Text.Trim().Equals(""))
            {
                txtBoxLoginPassword.Text = "Contraseña...";
                txtBoxLoginPassword.UseSystemPasswordChar = false;
                this.IsValidPassw = false;
            }
            else
            {
                this.IsValidPassw = true;
            }
        }

        private void lblMinimize_MouseEnter(object sender, EventArgs e)
        {
            lblMinimize.BackColor = Color.DarkGray;
        }

        private void lblMinimize_MouseLeave(object sender, EventArgs e)
        {
            lblMinimize.BackColor = Color.FromArgb(48, 47, 49);

        }

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            lblClose.BackColor = Color.Red;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.BackColor = Color.FromArgb(48, 47, 49);
        }

        private void btnLoginRegistrer_Click(object sender, EventArgs e)
        {
            if (!this.IsValidUsername && !this.IsValidPassw)
            {
                lblMensaje.Text = "Error: Los campos USUARIO y CONTRASEÑA no pueden estar vacios";
                lblMensaje.Visible = true;
            }
            else
            {
                if (!this.IsValidUsername)
                {
                    lblMensaje.Text = "Error: El campo USUARIO no puede estar vacio";
                    lblMensaje.Visible = true;
                }

                if (!this.IsValidPassw)
                {
                    lblMensaje.Text = "Error: El campo CONTRASEÑA no puede estar vacio";
                    lblMensaje.Visible = true;
                }
            }
            if (this.IsLogin && this.IsValidPassw && this.IsValidUsername)
            {
                Usuario usuario = new Usuario();
                //usuario.

                IniciarSesion(usuario);
            }
            else if (!this.IsLogin && this.IsValidPassw && this.IsValidUsername)
            {
                Usuario usuario = new Usuario();
                RegistrarUsuario(usuario);
            }



        }
    }
}

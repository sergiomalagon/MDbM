using MDbM.Properties;
using MDbM.UI.Clases;
using MDbM.UI.MainUI;
using MDbM.UI.MongoDB;
using MDbM.UI.AdminUI;
using MongoDB.Bson;
using System;
using System.Collections;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using MDbM.Clases;

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
            LblMensaje.Visible = false;
        }

        private void RegistrarUsuario()
        {
            Usuario usuario = new Usuario
            {
                nombre = TxtBoxLoginUsuario.Text.Trim(),
                passw = TxtBoxLoginPassword.Text.Trim(),
                rol = (int)Enums.TipoUsuario.USER,
                imagenPerfil = Path.GenerarUrlImagen(Path.GetUser(),TxtBoxLoginUsuario.Text.Trim()),
                abandonada = new ObjectId[0],
                completada = new ObjectId[0],
                planeada = new ObjectId[0],
                viendo = new ObjectId[0],
            };

            if (db.CearUsuario(usuario))
            {
                ImgPerfil.Image.Save(Path.GetUserPPPath() + usuario.imagenPerfil + ".jpg");
                new Main(this, usuario).Show();
                this.Hide();
            }
        }

        private bool IniciarSesion()
        {
            Usuario usuarioLogin =  this.db.LoginUsuario(TxtBoxLoginUsuario.Text.Trim(), TxtBoxLoginPassword.Text.Trim());
            if(usuarioLogin.rol == (int)Enums.TipoUsuario.ADMIN)
            {
                new Admin().Show();
                return true;
            }
            new Main(this, usuarioLogin).Show();
            this.Hide();
            return true;
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

        private void PanelBarraControlVentana_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TxtBoxLoginUsuario_Enter(object sender, EventArgs e)
        {
            if (TxtBoxLoginUsuario.Text.Trim().Equals("Usuario..."))
            {
                TxtBoxLoginUsuario.Text = "";
            }
        }

        private void TxtBoxLoginUsuario_Leave(object sender, EventArgs e)
        {
            if (TxtBoxLoginUsuario.Text.Trim().Equals(""))
            {
                TxtBoxLoginUsuario.Text = "Usuario...";
                this.IsValidUsername = false;
            }
            else
            {
                if (db.ComprobarExisteUsuario(TxtBoxLoginUsuario.Text.Trim()))
                {
                    BtnLoginRegistrer.Text = "LOGIN";
                    LblMensaje.Visible = false;
                    this.IsLogin = true;
                    ImgPerfil.Image = db.GetImagenUsuario(TxtBoxLoginUsuario.Text.Trim());
                    ImgPerfil.Visible = true;
                //    ImgPerfil.BringToFront();
                    BtnImagenUsuario.SendToBack();
                }
                else
                {
                    BtnLoginRegistrer.Text = "REGISTRER";
                    this.IsLogin = false;
                    LblMensaje.Text = "Advertencia!!!: Vas a crear un nuevo usuario";
                    LblMensaje.Visible = true;
                    ImgPerfil.Image = null;
                    BtnImagenUsuario.BringToFront();
                }
                this.IsValidUsername = true;
            }

        }

        private void TxtBoxLoginPassword_Enter(object sender, EventArgs e)
        {
            if (TxtBoxLoginPassword.Text.Trim().Equals("Contraseña..."))
            {
                TxtBoxLoginPassword.Text = "";
                TxtBoxLoginPassword.UseSystemPasswordChar = true;
            }
        }

        private void TxtBoxLoginPassword_Leave(object sender, EventArgs e)
        {
            if (TxtBoxLoginPassword.Text.Trim().Equals(""))
            {
                TxtBoxLoginPassword.Text = "Contraseña...";
                TxtBoxLoginPassword.UseSystemPasswordChar = false;
                this.IsValidPassw = false;
            }
            else
            {
                this.IsValidPassw = true;
            }
        }

        private void LblMinimize_MouseEnter(object sender, EventArgs e)
        {
            LblMinimize.BackColor = Color.DarkGray;
        }

        private void LblMinimize_MouseLeave(object sender, EventArgs e)
        {
            LblMinimize.BackColor = Color.FromArgb(48, 47, 49);

        }

        private void LblClose_MouseEnter(object sender, EventArgs e)
        {
            LblClose.BackColor = Color.Red;
        }

        private void LblClose_MouseLeave(object sender, EventArgs e)
        {
            LblClose.BackColor = Color.FromArgb(48, 47, 49);
        }

        private void BtnLoginRegistrer_Click(object sender, EventArgs e)
        {
            if (!this.IsValidUsername && !this.IsValidPassw)
            {
                LblMensaje.Text = "Error: Los campos USUARIO y CONTRASEÑA no pueden estar vacios";
                LblMensaje.Visible = true;
            }
            else
            {
                if (!this.IsValidUsername)
                {
                    LblMensaje.Text = "Error: El campo USUARIO no puede estar vacio";
                    LblMensaje.Visible = true;
                }

                if (!this.IsValidPassw)
                {
                    LblMensaje.Text = "Error: El campo CONTRASEÑA no puede estar vacio";
                    LblMensaje.Visible = true;
                }
            }
            if (this.IsLogin && this.IsValidPassw && this.IsValidUsername)
            {
                LblMensaje.Visible = false;
                IniciarSesion();
            }
            else if (!this.IsLogin && this.IsValidPassw && this.IsValidUsername)
            {
                LblMensaje.Visible = false;
                RegistrarUsuario();
            }
        }
        private void BtnImagenUsuario_Click(object sender, EventArgs e)
        {
            Image File;
            OpenFileDialog f = new OpenFileDialog
            {
                Filter = "Image files (*.jpg, *.png) | *.jpg; *.png"
            };

            if (f.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(f.FileName);
                ImgPerfil.Image = File;
            }
        }
    }
}

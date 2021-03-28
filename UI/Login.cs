using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MDbM.UI;

namespace MDbM
{
    public partial class Login : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        public Login()
        {
            InitializeComponent();

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

        private void Main_Load(object sender, EventArgs e)
        {

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
            new Main().Show();
            this.Hide();
        }
    }
}

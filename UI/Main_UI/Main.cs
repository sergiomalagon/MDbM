using MDbM.Properties;
using MDbM.UI.Clases;
using MDbM.UI.LoginUI;
using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MDbM.UI.MainUI
{
    public partial class Main : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        internal ResourceManager resourceManager = new ResourceManager(typeof(Resources));


        internal Login LoginForm = null;
        internal Usuario Usuario = null;
        internal static string PATH_IMG_PERFIL = "..\\..\\Resources\\UserPP\\";

        public Main(Login Login, Usuario Usuario)
        {
            InitializeComponent();
            this.LoginForm = Login;
            this.Usuario = Usuario;
            Init();
        }

        private void Init()
        {
            imgPerfil.ImageLocation = PATH_IMG_PERFIL + this.Usuario.imagenPerfil + ".jpg";
            lblNombreUsuario.Text = this.Usuario.nombre;
        }

        private void entrarPeliculaDetalle(object sender, EventArgs e)
        {
            panelDetalle.BringToFront();
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

        private void lblMinimize_MouseEnter(object sender, EventArgs e)
        {
            lblMinimize.BackColor = Color.DarkGray;
        }

        private void lblMinimize_MouseLeave(object sender, EventArgs e)
        {
            lblMinimize.BackColor = Color.FromArgb(48, 47, 49);
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelControlVentana_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            this.LoginForm.Show();
            Hide();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lblCerrarPanelDetalle_Click(object sender, EventArgs e)
        {
            panelDetalle.SendToBack();
        }
    }
}

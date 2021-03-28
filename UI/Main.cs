using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDbM.UI
{
    public partial class Main : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Main()
        {
            InitializeComponent();
            Init();
        }
        /// <summary>
        /// Cargo la informacion del usuario logeado
        /// </summary>
        private void Init()
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

        private void lblSalir_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }
    }
}

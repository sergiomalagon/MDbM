using MDbM.UI.LoginUI;
using System;
using System.Windows.Forms;

namespace MDbM
{
    static class MDbM
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}

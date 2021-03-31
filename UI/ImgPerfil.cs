using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Resources;

namespace ImagenPerfil
{
    public class ImgPerfil : PictureBox
    {
        ResourceManager rm = new ResourceManager(typeof(ImgPerfil));
        public ImgPerfil()
        {
            this.BackColor = Color.DarkGray;
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            using (var gp = new GraphicsPath())
            {
                gp.AddEllipse(new Rectangle(0, 0, this.Width - 1, this.Height - 1));
                this.Region = new Region(gp);
            }
        }

        public void CambiarImagen(String rutaImagen)
        {
            this.Image = (Image)rm.GetObject(rutaImagen);
        }
    }
}

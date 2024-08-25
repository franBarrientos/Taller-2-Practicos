using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Practicos.Practico_5
{
    class OvalImg : PictureBox
    {
        public OvalImg()
        {
            this.BackColor = Color.DarkGray;
            this.SizeMode = PictureBoxSizeMode.StretchImage; // Ajustar la imagen al área del PictureBox
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            using (var gp = new GraphicsPath())
            {
                gp.AddEllipse(new Rectangle(2, 0, this.Width - 2, this.Height - 3));
                this.Region = new Region(gp);
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            // Dibujar la imagen para que rellene el área ovalada
            if (this.Image != null)
            {
                pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                // Crear el GraphicsPath para el óvalo
                using (var gp = new GraphicsPath())
                {
                    gp.AddEllipse(new Rectangle(2, 0, this.Width - 2, this.Height - 3));
                    pe.Graphics.SetClip(gp);
                }

                // Dibujar la imagen dentro del área ovalada
                pe.Graphics.DrawImage(this.Image, new Rectangle(2, 0, this.Width - 2, this.Height - 3));
            }
        }
    }
}

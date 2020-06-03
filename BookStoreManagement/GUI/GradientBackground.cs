using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GUI
{
    public partial class GradientBackground : Panel
    {
        int wh = 20;

        Color color0 = Color.Blue;
        Color color1 = Color.Orange;

        public Color Color0
        {
            get { return color0; }
            set { color0 = value; Invalidate(); }
        }

        public Color Color1
        {
            get { return color1; }
            set { color1 = value; Invalidate(); }
        }


        public GradientBackground()
        {
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(new Rectangle(0, 0, wh, wh), 180, 90);
            gp.AddArc(new Rectangle(Width - wh, 0, wh, wh), -90, 90);
            gp.AddArc(new Rectangle(Width - wh, Height - wh, wh, wh), 0, 90);
            gp.AddArc(new Rectangle(0, Height - wh, wh, wh), 90, 90);
            e.Graphics.FillPath(new LinearGradientBrush(ClientRectangle, color0, color1,45), gp);

            base.OnPaint(e);
        }


    }
}

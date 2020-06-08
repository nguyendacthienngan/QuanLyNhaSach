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
        Timer timer = new Timer();
        public float angle = 45;

        Color color0 = Color.Blue;
        Color color1 = Color.Orange;

        public GradientBackground()
        {
            DoubleBuffered = true;
            timer.Interval = 60;
            timer.Start();
            timer.Tick += (s, e) => { Angle = (Angle % 360) + 2; };
        }
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

        public float Angle
        {
            get { return angle; }
            set { angle = value; Invalidate(); }
        }

        


        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.FillRectangle(new LinearGradientBrush(ClientRectangle, color0, color1,Angle), this.ClientRectangle);

            base.OnPaint(e);
        }


    }
}

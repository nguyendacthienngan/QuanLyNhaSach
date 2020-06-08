using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.User_Controls
{
    public partial class SlideUp_Login : UserControl
    {
        public delegate void OnFinish();
        public event OnFinish onFinish;

        int waiter = 0, waiter2 = 0;
        int panel1_y = 519;
        public SlideUp_Login()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1_y -= 17;
            panel1.Size = new Size(panel1.Size.Width, panel1_y);
            if (panel1_y < 1)
            {
                panel1.Hide();
                timer1.Enabled = false;
                timer2.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            waiter2++;
            if (waiter2 > 50)
            {
                timer2.Stop();
                onFinish();
            }
        }
    }
}

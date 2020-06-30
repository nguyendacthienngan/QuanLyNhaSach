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
    public partial class UC_DebtReport : UserControl
    {
        int panel_y;
        public UC_DebtReport()
        {
            InitializeComponent();
            DoubleBuffered = true;
            panel_y = gradientBackground1.Height;
        }

        private void UC_DebtReport_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel_y -= 19;
            gradientBackground1.Size = new Size(panel1.Size.Width, panel_y);
            if (panel_y < 1)
            {
                gradientBackground1.Hide();
                timer1.Enabled = false;
            }

        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void gradientBackground1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

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
    public partial class UC_InventoryReport : UserControl
    {
        int panel_y;
        public UC_InventoryReport()
        {
            InitializeComponent();
            panel_y = gradientBackground1.Height;
        }

        private void dtgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
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
    }
}

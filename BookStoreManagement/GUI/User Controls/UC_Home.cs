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
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void illustration_Click(object sender, EventArgs e)
        {

        }

        private void bunifuVScrollBar2_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            contentPanel.VerticalScroll.Value = scrollbar.Value;
        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            contentPanel.VerticalScroll.Visible = false;
        }
    }
}

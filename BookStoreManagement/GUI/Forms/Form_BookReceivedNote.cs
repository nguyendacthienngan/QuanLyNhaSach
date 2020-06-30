using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class Form_BookReceivedNote : Form
    {
        public Form_BookReceivedNote()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void lb_Amount_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("List");
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Input");
        }
    }
}

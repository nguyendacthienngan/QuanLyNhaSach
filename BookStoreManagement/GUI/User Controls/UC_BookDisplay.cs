using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.User_Controls
{
    public partial class UC_BookDisplay : UserControl
    {
        public Image Cover
        {
            set { picCover.Image = value; }
        }

        public string BookTitle
        {
            set { lbTitle.Text = value; }
        }

        public string Author
        {
            set { lbAuthor.Text = "by " + value; }
        }

        public string Price
        {
            set { lbPrice.Text = value; }
        }


        public UC_BookDisplay()
        {
            InitializeComponent();
            panel.Visible = false;
            panelButton.Visible = false;
            btnDelete.Enabled = true;
        }
           
        private void picCover_MouseEnter(object sender, EventArgs e)
        {
            panel.Visible = true;
            panelButton.Visible = true;
        }

        private void picCover_MouseLeave(object sender, EventArgs e)
        {
            panel.Visible = false;
            panelButton.Visible = false;

        }

        private void panelButton_MouseEnter(object sender, EventArgs e)
        {

        }

        private void panelButton_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button click");
        }
    }
}

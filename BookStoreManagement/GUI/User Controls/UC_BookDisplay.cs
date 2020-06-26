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
            panelTitle.Visible = false;
            panelButton.Visible = false;
            btnDelete.Enabled = true;
        }

        #region Appear/Disappear
        private void picCover_MouseEnter(object sender, EventArgs e)
        {
            panelTitle.Visible = true;
            panelButton.Visible = true;
        }

        private void picCover_MouseLeave(object sender, EventArgs e)
        {
           if(this.ClientRectangle.Contains(this.PointToClient(Control.MousePosition)))
           {
                return;
           }
           else
           {
                panelTitle.Visible = false;
                panelButton.Visible = false;
           }
        }
        private void panelButton_MouseLeave(object sender, EventArgs e)
        {
            if(picCover.ClientRectangle.Contains(picCover.PointToClient(Control.MousePosition)))
            {
                return;
            }
            else
            {
                panelTitle.Visible = false;
                panelButton.Visible = false;
            }
        }

        private void panelTitle_MouseLeave(object sender, EventArgs e)
        {
            if (picCover.ClientRectangle.Contains(picCover.PointToClient(Control.MousePosition)))
            {
                return;
            }
            else
            {
                panelTitle.Visible = false;
                panelButton.Visible = false;
            }
        }
        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            if (picCover.ClientRectangle.Contains(picCover.PointToClient(Control.MousePosition)))
            {
                return;
            }
            else
            {
                panelTitle.Visible = false;
                panelButton.Visible = false;
            }
        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            if (picCover.ClientRectangle.Contains(picCover.PointToClient(Control.MousePosition)))
            {
                return;
            }
            else
            {
                panelTitle.Visible = false;
                panelButton.Visible = false;
            }
        }
        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button click");
        }
    }
}

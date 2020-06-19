using GUI.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form_Main : Form
    {
        bool isSellCollapsed = true;

        public Form_Main()
        {
            InitializeComponent();
            (new GUI.DropShadow()).ApplyShadows(this);
            AddControlsToPanel(new UC_Home());
            sellDropdown.BackColor = Color.FromArgb(150, 0, 0, 0);

        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AddControlsToPanel(new UC_Home());
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            CollapsePanel();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            AddControlsToPanel(new Employee());
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            AddControlsToPanel(new UC_Sell_Details());
            CollapsePanel();
        }

        void CollapsePanel()
        {
            if (isSellCollapsed)
            {
                sellDropdown.Visible = false;
                sellDropdown.Height = 100;
                DropdownAnimation.ShowSync(sellDropdown);
                isSellCollapsed = false;
            }
            else
            {
                sellDropdown.Visible = false;
                sellDropdown.Height = 1;
                isSellCollapsed = true;
            }
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            AddControlsToPanel(new UC_Books());
        }
    }
}

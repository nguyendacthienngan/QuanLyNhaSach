using GUI.Forms;
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
        bool isReportCollapsed = true;

        public Form_Main()
        {
            InitializeComponent();
            (new GUI.DropShadow()).ApplyShadows(this);
            AddControlsToPanel(new UC_Home());
            sellDropdown.BackColor = Color.FromArgb(150, 0, 0, 0);
            reportDropdown.BackColor = Color.FromArgb(150, 0, 0, 0);

        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }
        void CollapsePanel(Panel control, ref bool isCollapsed, bool isSell)
        {
            int height;
            if (isSell == true)
                height = 170;
            else
                height = 100;
            if (isCollapsed)
            {
                control.Visible = false;
                control.Height = height;
                DropdownAnimation.ShowSync(control);
                isCollapsed = false;
            }
            else
            {
                control.Visible = false;
                control.Height = 1;
                isCollapsed = true;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AddControlsToPanel(new UC_Home());
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            CollapsePanel(sellDropdown, ref isSellCollapsed, true);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            AddControlsToPanel(new UC_Employee());
        }

        private void btnTabSell_Click(object sender, EventArgs e)
        {
            AddControlsToPanel(new UC_Sell());
            CollapsePanel(sellDropdown, ref isSellCollapsed, true);
        }
        private void btnBooks_Click(object sender, EventArgs e)
        {
            AddControlsToPanel(new UC_Books());
        }

        private void navigationBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {

            CollapsePanel(reportDropdown, ref isReportCollapsed, false);
        }

        private void btnTabInvoice_Click(object sender, EventArgs e)
        {
            AddControlsToPanel(new UC_Invoice());
            CollapsePanel(sellDropdown, ref isSellCollapsed, true);
        }

        private void btnReport_MouseEnter(object sender, EventArgs e)
        {
        }

        private void btnDebt_Click(object sender, EventArgs e)
        {
            AddControlsToPanel(new UC_DebtReport());
            CollapsePanel(reportDropdown, ref isReportCollapsed, false);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            AddControlsToPanel(new UC_InventoryReport());
            CollapsePanel(reportDropdown, ref isReportCollapsed, false);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            /*Control csDetails = new UC_Customer_Detail();
            csDetails.Name = "csDetails";
            Control csDefault = new UC_Customer_Default();
            csDetails.Name = "csDetails";

            AddControlsToPanel(csDetails);
            AddControlsToPanel(csDefault);*/
            AddControlsToPanel(new UC_Customer());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            using (var form = new Form_Settings())
            {
                form.ShowDialog();
            }
        }
        private void btnTabDebt_Click(object sender, EventArgs e)
        {
            AddControlsToPanel(new UC_Debt());
            CollapsePanel(sellDropdown, ref isSellCollapsed, true);
        }
    }
}

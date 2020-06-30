using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class Form_Settings : Form
    {
        public Form_Settings()
        {
            InitializeComponent();
            (new GUI.DropShadow()).ApplyShadows(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnConstraints_Click(object sender, EventArgs e)
        {
            if(Pages.Page.Text != "Constraints")
            {
                Pages.SetPage("Constraints");
            }
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            if (Pages.Page.Text != "Price")
            {
                Pages.SetPage("Price");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FromDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker2_onValueChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Invoice : UserControl
    {
        public Invoice(string name)
        {
            InitializeComponent();
            lbName.Text = name;
            AddData();
        }

        private void AddData()
        {
            for (int i = 0; i < 7; i++)
            {
                bunifuCustomDataGrid1.Rows.Add(
                new object[]
                {
                    1, "Biology", 2, 10000, 0, 20000
                });
            }
        }
        private void AddControlsToPanel(Control c)
        {
            this.Controls.Clear();
            c.Dock = DockStyle.Fill;
            this.Controls.Add(c);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AddControlsToPanel(new InvoiceList());
        }
    }
}

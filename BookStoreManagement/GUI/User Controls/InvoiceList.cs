using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace GUI.User_Controls
{
    public partial class InvoiceList : UserControl
    {
        public InvoiceList()
        {
            InitializeComponent();;

            AddData();
        }

        private void AddControlsToPanel(Control c)
        {
            this.Controls.Clear();
            c.Dock = DockStyle.Fill;
            this.Controls.Add(c);
        }


        private void AddData()
        {
            bunifuCustomDataGrid1.Rows.Add(
               new object[]
               {
                0, "1-1-1", "Dung", "x", "20", "200"
               });
            bunifuCustomDataGrid1.Rows.Add(
            new object[]
            {
                1, "1-1-1", "Chuong", "x", "20", "200"
            });
            bunifuCustomDataGrid1.Rows.Add(
            new object[]
            {
                2, "1-1-1", "Tien", "x", "20", "200"
            });
            bunifuCustomDataGrid1.Rows.Add(
            new object[]
            {
                3, "1-1-1", "Ngan", "x", "20", "200"
            });
            bunifuCustomDataGrid1.Rows.Add(
            new object[]
            {
                4, "1-1-1", "Hieu", "x", "20", "200"
            });
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AddControlsToPanel(new Invoice(bunifuCustomDataGrid1.CurrentRow.Cells[2].Value.ToString()));
        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            NewInvoice newInvoice = new NewInvoice();
            newInvoice.ShowDialog();
        }
    }
}

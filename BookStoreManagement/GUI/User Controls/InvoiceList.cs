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
    public partial class InvoiceList : UserControl
    {
        public InvoiceList()
        {
            InitializeComponent();;

            addData();
        }

        private void addData()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

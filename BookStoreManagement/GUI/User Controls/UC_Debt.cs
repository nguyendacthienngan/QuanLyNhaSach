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
    public partial class UC_Debt : UserControl
    {
        bool IsAdd;
        UC_DebtList uC_DebtList;
        public UC_Debt()
        {
            InitializeComponent();
            uC_DebtList = new UC_DebtList();
            uC_DebtList.Dock = DockStyle.Fill;
            panelDebt.Controls.Clear();
            panelDebt.Controls.Add(uC_DebtList);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UC_DebtRecepit uC_DebtRecepit = new UC_DebtRecepit(uC_DebtList, panelDebt);
            uC_DebtRecepit.Dock = DockStyle.Fill;
            panelDebt.Controls.Clear();
            panelDebt.Controls.Add(uC_DebtRecepit);
        }
    }
}

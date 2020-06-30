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
    public partial class UC_DebtRecepit : UserControl
    {
        UserControl UCDebtRecepit;
        Panel PanelDebt;
        public UC_DebtRecepit(UserControl ucDebtReceipt, Panel panelDebt)
        {
            InitializeComponent();
            UCDebtRecepit = ucDebtReceipt;
            PanelDebt = panelDebt;
        }

        private void btn_AddToList_Click(object sender, EventArgs e)
        {
            UCDebtRecepit.Dock = DockStyle.Fill;
            PanelDebt.Controls.Clear();
            PanelDebt.Controls.Add(UCDebtRecepit);
        }
    }
}

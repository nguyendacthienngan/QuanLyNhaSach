using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.User_Controls;
using BLL;
using Model;

namespace GUI.User_Controls
{
    public partial class UC_Customer : UserControl
    {
        public int ID = 5;
        public int IDc = -1;
        public EmployeeBLL employeeBLL;
        private bool isDefault = true;
        public UC_Customer()
        {
            employeeBLL = new EmployeeBLL();
            InitializeComponent();
            
           
        }

        #region Functions




        #endregion

        #region Navigation







        #endregion

        #region Events




        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isDefault)
            {
                bunifuPages1.SetPage("CustomerDetails");
            }
            else
            {
                bunifuPages1.SetPage("CustomerDefault");
            }
            isDefault = !isDefault;
           
        }
    }
}

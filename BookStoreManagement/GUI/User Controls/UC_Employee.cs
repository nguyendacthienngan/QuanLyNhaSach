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
    public partial class UC_Employee : UserControl
    {
        public int ID=5;
        public EmployeeBLL employeeBLL;
        public UC_Employee()
        {
            employeeBLL = new EmployeeBLL();
            InitializeComponent();
            LoadEmployee();
            LoadEmployeeEE();
        }
        #region Functions
        private void ClearData()
        {
            txtLastnameEE.Clear();
            txtFirstnameEE.Clear();
            txtCmndEE.Clear();
            txtPhoneEE.Clear();
            txtAddressEE.Clear();
        }
        private void Disable()
        {
            txtLastnameEE.Enabled = false;
            txtFirstnameEE.Enabled = false;
            txtCmndEE.Enabled = false;
            txtPhoneEE.Enabled = false;
            txtAddressEE.Enabled = false;
            dpDobEE.Enabled = false;
            ddGenderEE.Enabled = false;
            ddRoleEE.Enabled = false;
            ddStatusEE.Enabled = false;
        }
        private void LoadEmployee()
        {
            //List<User> listUsers = employeeBLL.GetAllEmployee();
            //dgvEmployee.DataSource = listUsers;
            try
            {
                List<User> listUsers = employeeBLL.GetAllEmployee();
                dgvEmployee.DataSource = listUsers;
            }
            catch
            {
                MessageBox.Show("Failed");
            }
        }
        private void LoadEmployeeEE()
        {
            //List<User> listUsers = employeeBLL.GetAllEmployee();
            //dgvEmployee.DataSource = listUsers;
            try
            {
                List<User> listUsers = employeeBLL.GetAllEmployee();
                dgvEmployeeEE.DataSource = listUsers;
            }
            catch
            {
                MessageBox.Show("Failed");
            }
        }
        #endregion

        #region Navigation
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("EmployeeEdit");
            ClearData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("EmployeeEdit");
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtAddressEE.Text!="" || txtLastnameEE.Text!="" || txtFirstnameEE.Text != "" || txtCmndEE.Text != "" || txtPhoneEE.Text != "" )
            {
                if (MessageBox.Show("This action will cancel add new profile. Are you sure ?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    bunifuPages1.SetPage("Employee");
                else return;
            }
            else
            {
                bunifuPages1.SetPage("Employee");
            }
        }
        #endregion

        #region Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            ID++;
            bool IsFemale=false;
            if (ddGenderEE.Text == "Female")
                IsFemale = true;
            User user1 = new User( ID, txtFirstnameEE.Text, txtLastnameEE.Text, txtPhoneEE.Text, txtEmailEE.Text,txtAddressEE.Text,dpDobEE.Value,IsFemale,txtCmndEE.Text) ;
            bool result = employeeBLL.AddUser(user1);
            if (result == true)
            { 
                MessageBox.Show(user1.LastName + " " + user1.FirstName + " has been added");
                ClearData();
                LoadEmployeeEE();
                LoadEmployee();
            }
            else
                MessageBox.Show("Failed to add");
        }
        #endregion
    }
}

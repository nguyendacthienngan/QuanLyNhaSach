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
        public int ID = 5;
        public EmployeeBLL employeeBLL;
        public UC_Employee()
        {
            employeeBLL = new EmployeeBLL();
            InitializeComponent();
            LoadEmployee();
            LoadEmployeeEE();
            label1.Visible = label4.Visible = false;
            
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
        private void DisableEE()
        {
            txtLastnameEE.Enabled = false;
            txtFirstnameEE.Enabled = false;
            txtCmndEE.Enabled = false;
            txtPhoneEE.Enabled = false;
            txtAddressEE.Enabled = false;
            dpDobEE.Enabled = false;
            ddGenderEE.Enabled = false;
            ddRoleEE.Enabled = false;
           
            txtEmailEE.Enabled = false;
        }
        private void EnableEE()
        {
            txtLastnameEE.Enabled = true;
            txtFirstnameEE.Enabled = true;
            txtCmndEE.Enabled = true;
            txtPhoneEE.Enabled = true;
            txtAddressEE.Enabled = true;
            dpDobEE.Enabled = true;
            ddGenderEE.Enabled = true;
            ddRoleEE.Enabled = true;
            
            txtEmailEE.Enabled = true;
        }

        private void LoadEmployee()
        {
            try
            {
                List<User> listUsers = employeeBLL.GetAllEmployee();
               
                dgvEmployee.AutoGenerateColumns = false;

                dgvEmployee.ColumnCount = 8;
                dgvEmployee.Columns[0].HeaderText = "First Name";
                dgvEmployee.Columns[0].DataPropertyName = "firstName";

                dgvEmployee.Columns[1].HeaderText = "Last Name";
                dgvEmployee.Columns[1].DataPropertyName = "lastName";

                dgvEmployee.Columns[2].HeaderText = "Phone Number";
                dgvEmployee.Columns[2].DataPropertyName = "phone";

                dgvEmployee.Columns[3].HeaderText = "Date Of Birth";
                dgvEmployee.Columns[3].DataPropertyName = "dateOfBirth";

                dgvEmployee.Columns[4].HeaderText = "Email";
                dgvEmployee.Columns[4].DataPropertyName = "email";

                dgvEmployee.Columns[5].HeaderText = "Address";
                dgvEmployee.Columns[5].DataPropertyName = "address";

                dgvEmployee.Columns[6].HeaderText = "Female";
                dgvEmployee.Columns[6].DataPropertyName = "isFemale";

                dgvEmployee.Columns[7].HeaderText = "CMND";
                dgvEmployee.Columns[7].DataPropertyName = "idCard";
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
                dgvEmployeeEE.AutoGenerateColumns = false;

                dgvEmployeeEE.ColumnCount = 5;
                dgvEmployeeEE.Columns[0].Name = "id";
              //  dgvEmployeeEE.Columns[0].HeaderText = "id";
                dgvEmployeeEE.Columns[0].DataPropertyName = "id";
                //dgvEmployeeEE.Columns[0].Visible = false ;

                dgvEmployeeEE.Columns[1].HeaderText = "First Name";
                dgvEmployeeEE.Columns[1].DataPropertyName = "firstName";

                dgvEmployeeEE.Columns[2].HeaderText = "Last Name";
                dgvEmployeeEE.Columns[2].DataPropertyName = "lastName";

                dgvEmployeeEE.Columns[3].HeaderText = "Phone Number";
                dgvEmployeeEE.Columns[3].DataPropertyName = "phone";

                dgvEmployeeEE.Columns[4].HeaderText = "CMND";
                dgvEmployeeEE.Columns[4].DataPropertyName = "idCard";

                

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
            //bunifuPages1.SetPage("EmployeeEdit");
            bunifuPages1.SetPage("EmployeeProfile");
            ClearData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit_EE.Visible = true;
         
            bunifuPages1.SetPage("EmployeeEdit");
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtAddressEE.Text != "" || txtLastnameEE.Text != "" || txtFirstnameEE.Text != "" || txtCmndEE.Text != "" || txtPhoneEE.Text != "")
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
        private void btnBack_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Employee");
        }
        #endregion

        #region Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            ID++;
            bool IsFemale = false;
            if (ddGenderEE.Text == "Female")
                IsFemale = true;
            User user1 = new User(ID, txtFirstnameEE.Text, txtLastnameEE.Text, txtPhoneEE.Text, txtEmailEE.Text, txtAddressEE.Text, dpDobEE.Value, IsFemale, txtCmndEE.Text);
            bool result = employeeBLL.AddUser(user1);
            if (result == true)
            {
                MessageBox.Show(user1.lastName + " " + user1.firstName + " has been added");
                ClearData();
                LoadEmployeeEE();
                LoadEmployee();
            }
            else
                MessageBox.Show("Failed to add");
        }

        private void txtCmndEE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void dgvEmployeeEE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var temp = dgvEmployeeEE.Rows[e.RowIndex];
            int id = (int)temp.Cells["ID"].Value;
            User user1 = employeeBLL.FindEmployee(id);
            txtLastnameEE.Text = user1.lastName;
            txtFirstnameEE.Text = user1.firstName;
            txtAddressEE.Text = user1.address;
            txtPhoneEE.Text = user1.phone;
            txtCmndEE.Text = user1.idCard;
            txtEmailEE.Text = user1.email;
            ddGenderEE.Text = "Male";
            if (user1.isFemale==true)
                ddGenderEE.Text = "Female";
            dpDobEE.Value = user1.dateOfBirth;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {


        }

        #endregion

        
    }
}

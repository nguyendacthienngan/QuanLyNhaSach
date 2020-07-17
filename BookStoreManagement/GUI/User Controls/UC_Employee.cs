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
        public int IDc=-1;
        public EmployeeBLL employeeBLL;
        public UC_Employee()
        {
            employeeBLL = new EmployeeBLL();
            InitializeComponent();
            LoadEmployee();
            LoadEmployeeEE();
        }
        #region Functions
        private void ClearDataEE()
        {
            txtLastnameEE.Clear();
            txtFirstnameEE.Clear();
            txtCmndEE.Clear();
            txtPhoneEE.Clear();
            txtAddressEE.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtEmailEE.Clear();
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
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
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
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            txtEmailEE.Enabled = true;
        }
        private void LoadEmployee()
        {
            try
            {
                List<User> listUsers = employeeBLL.GetAllEmployee();
               
                dgvEmployee.AutoGenerateColumns = false;

                dgvEmployee.ColumnCount = 9;
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

                dgvEmployee.Columns[8].Name = "id";
                dgvEmployee.Columns[8].DataPropertyName = "id";
                dgvEmployee.Columns[8].Visible = false;

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
                dgvEmployeeEE.Columns[0].Visible = false ;

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
            bunifuPages1.SetPage("EmployeeEdit");
            ClearDataEE();
            btnEdit_EE.Visible = false;
            btnBack.Visible = false;
            btnSaveedit.Visible = false;
            btnDelete.Visible = false;
            btnSavenew.Visible = true;
            btnCancel.Visible = true;
            label1.Visible = label11.Visible = true;
            txtUsername.Visible = txtPassword.Visible = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("EmployeeEdit");
            EnableEE();
            btnEdit_EE.Visible = false;
            btnBack.Visible = false;
            btnSavenew.Visible = false;
            btnSaveedit.Visible = true;
            btnCancel.Visible = true;
            txtLastnameEE.Text = txtLastnameEP.Text;
            txtFirstnameEE.Text = txtFirstnameEP.Text;
            txtAddressEE.Text = txtAddressEP.Text;
            txtPhoneEE.Text = txtPhoneEP.Text;
            txtCmndEE.Text = txtCmndEP.Text;
            txtEmailEE.Text = txtEmailEP.Text;
            if (ddGenderEP.Text == "Female")
                ddGenderEE.Text = "Female";
            else ddGenderEE.Text = "Male";
            dpDobEE.Value = dpDobEP.Value;
            label1.Visible = label11.Visible = false;
            txtUsername.Visible = txtPassword.Visible = false;
            //List<User> users = employeeBLL.SearchUser(txtEmailEE.Text);

        }
       
        private void btnBack_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Employee");
        }
        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bunifuPages1.SetPage("EmployeeProfile");
            int index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = dgvEmployee.Rows[index];
            txtLastnameEP.Text = selectedRow.Cells[1].Value.ToString();
            txtFirstnameEP.Text = selectedRow.Cells[0].Value.ToString();
            txtAddressEP.Text = selectedRow.Cells[5].Value.ToString();
            txtPhoneEP.Text = selectedRow.Cells[2].Value.ToString();
            txtCmndEP.Text = selectedRow.Cells[7].Value.ToString();
            txtEmailEP.Text = selectedRow.Cells[4].Value.ToString();
            if (selectedRow.Cells[6].Value.ToString() == "Female")
                ddGenderEP.Text = "Female";
            else ddGenderEP.Text = "Male";
            dpDobEP.Value = Convert.ToDateTime(selectedRow.Cells[3].Value.ToString());
            var temp = dgvEmployee.Rows[e.RowIndex];
            IDc = (int)temp.Cells["ID"].Value;
        }
        #endregion

        #region Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            ID++;
            bool IsFemale = false;
            if (ddGenderEE.Text == "Female")
                IsFemale = true;
            User user1 = new User( ID,txtFirstnameEE.Text, txtLastnameEE.Text, txtPhoneEE.Text, txtEmailEE.Text, txtAddressEE.Text, dpDobEE.Value, IsFemale, txtCmndEE.Text);
            bool IsAdmin = false;
            if (ddRoleEE.Text=="Admin")
                IsAdmin = true;
            Account account1 = new Account(ID, txtUsername.Text, txtPassword.Text, IsAdmin);
            bool result = employeeBLL.AddUser(user1,account1);
            if (result == true)
            {
                MessageBox.Show(user1.lastName + " " + user1.firstName + " has been added");
                ClearDataEE();
                LoadEmployeeEE();
                LoadEmployee();
                btnEdit_EE.Visible = true;
                btnBack.Visible = true;
                btnSavenew.Visible = false;
                btnSaveedit.Visible = false;
                btnCancel.Visible = false;
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
            IDc = (int)temp.Cells["ID"].Value;
            User user1 = employeeBLL.FindEmployee(IDc);
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
        private void btnSearch_Click(object sender, EventArgs e)
        {

            List<User> listUsers = employeeBLL.SearchUser(txtSearch.Text);
            dgvEmployee.AutoGenerateColumns = false;
            dgvEmployee.DataSource = listUsers;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtAddressEE.Text != "" || txtLastnameEE.Text != "" || txtFirstnameEE.Text != "" || txtCmndEE.Text != "" || txtPhoneEE.Text != "")
            {
                if (MessageBox.Show("This action will cancel add new profile. Are you sure ?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    ClearDataEE();
                    DisableEE();
                    btnEdit_EE.Visible = true;
                    btnBack.Visible = true;
                    btnSavenew.Visible = false;
                    btnCancel.Visible = false;
                    btnSaveedit.Visible = false;
                    label1.Visible = label11.Visible = true;
                    txtUsername.Visible = txtPassword.Visible = true;
                }
                else return;
            }
            else
            {
                DisableEE();
                btnEdit_EE.Visible = true;
                btnBack.Visible = true;
                btnSavenew.Visible = false;
                btnCancel.Visible = false;
                btnSaveedit.Visible = false;
                label1.Visible = label11.Visible = true;
                txtUsername.Visible = txtPassword.Visible = true;
            }
        }
        private void btnSaveedit_Click(object sender, EventArgs e)
        {
            bool IsFemale = false;
            if (ddGenderEE.Text == "Female")
                IsFemale = true;
            User user1 = new User(IDc, txtFirstnameEE.Text, txtLastnameEE.Text, txtPhoneEE.Text, txtEmailEE.Text, txtAddressEE.Text, dpDobEE.Value, IsFemale, txtCmndEE.Text);
            MessageBox.Show(Convert.ToString(IDc));
            bool result = employeeBLL.EditUser(user1);
            if (result == true)
            {
                MessageBox.Show("Edit successful");
                List<User> listUsers = employeeBLL.GetAllEmployee();
                dgvEmployee.AutoGenerateColumns = false;
                dgvEmployee.DataSource = listUsers;
                LoadEmployee();
                btnEdit_EE.Visible = true;
                btnBack.Visible = true;
                btnSavenew.Visible = false;
                btnSaveedit.Visible = false;
                btnCancel.Visible = false;
            }
            else
                MessageBox.Show("Failed to edit");
        }

        private void btnEdit_EE_Click(object sender, EventArgs e)
        {
            label1.Visible = label11.Visible = false;
            txtUsername.Visible = txtPassword.Visible = false;
        }

        #endregion


    }
}

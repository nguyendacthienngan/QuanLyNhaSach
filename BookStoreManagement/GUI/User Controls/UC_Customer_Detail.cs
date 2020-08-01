using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Model;
using System.Text.RegularExpressions;

namespace GUI.User_Controls
{
    public partial class UC_Customer_Detail : UserControl
    {
        private Label[] errorLabels = new Label[] { };
        public CustomerBLL customerBLL;
        private List<Customer> listCustomers = new List<Customer>();
        private string strFilter = "";

        //DataGridView datagrid;
        public UC_Customer_Detail()
        {
            //datagrid = data;
            customerBLL = new CustomerBLL();

            InitializeComponent();

            

            dgvCustomerDetail.AutoGenerateColumns = false;

            dgvCustomerDetail.ColumnCount = 4;
            dgvCustomerDetail.Columns[0].HeaderText = "First Name";
            dgvCustomerDetail.Columns[0].DataPropertyName = "firstName";

            dgvCustomerDetail.Columns[1].HeaderText = "Last Name";
            dgvCustomerDetail.Columns[1].DataPropertyName = "lastName";

            dgvCustomerDetail.Columns[2].HeaderText = "Phone";
            dgvCustomerDetail.Columns[2].DataPropertyName = "phone";

            dgvCustomerDetail.Columns[3].HeaderText = "Female";
            dgvCustomerDetail.Columns[3].DataPropertyName = "isFemale";
            LoadCustomer();
        }

        private List<Customer> CustomerFilter (List<Customer> lc)
        {
            List<Customer> result = new List<Customer>();
            foreach(Customer c in lc)
            {
                if(c.firstName.ToLower().IndexOf(strFilter.ToLower()) != -1
                    || c.lastName.ToLower().IndexOf(strFilter.ToLower()) != -1
                    || c.address.ToLower().IndexOf(strFilter.ToLower()) != -1
                    || c.phone.ToLower().IndexOf(strFilter.ToLower()) != -1)
                {
                    result.Add(c);
                }
            }
            return result;
        }

        private void LoadCustomer()
        {
            try
            {
                listCustomers = new List<Customer>();
                listCustomers = customerBLL.GetAllCustomer();
                
                dgvCustomerDetail.DataSource = CustomerFilter(listCustomers);
            }
            catch
            {
                MessageBox.Show("Failed");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFirstName.Text) || String.IsNullOrEmpty(txtLastName.Text)
            || String.IsNullOrEmpty(ddGender.Text) || String.IsNullOrEmpty(txtPhone.Text)
            || String.IsNullOrEmpty(txtEmail.Text)|| String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please insert information fully !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string fName = txtFirstName.Text;
                string lName = txtLastName.Text;
                string phone = txtPhone.Text;
                string email = txtEmail.Text;
                string address = txtAddress.Text;
                bool gender = (ddGender.SelectedItem.ToString() == "Female") ? true : false;
                Customer customer = new Customer(1, fName, lName, phone, email, address, gender, true);
                bool addCustomer = customerBLL.AddCustomer(customer);
                if (addCustomer)
                {
                    MessageBox.Show("Add customer success");
                }
                LoadCustomer();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string fName = txtFirstName.Text;
            string lName = txtLastName.Text;
            string phone = txtPhone.Text;
            bool gender;
            if (ddGender.SelectedIndex == 0)
            {
                gender = false;
            }
            else
                gender = true;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            Customer customer = new Customer(id, fName, lName, phone, email, address, gender, true);
            bool editCustomer = customerBLL.EditCustomer(customer);
            if (editCustomer)
            {
                MessageBox.Show("Edit customer success");
                LoadCustomer();
            }
            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtAddress.Clear();
            txtEmail.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            ddGender.Text = "-select-";
        }

        private void AddErrorMessage(Bunifu.Framework.BunifuCustomTextbox txbox, string myTag, string myMessage = "Please input this field !")
        {
            Label lbError = new Label();
            lbError.Text = myMessage;
            lbError.Top = txbox.Bottom + 5;
            lbError.Left = txbox.Left;
            lbError.ForeColor = Color.FromArgb(255, 0, 0);
            lbError.AutoSize = true;
            lbError.Font = new Font("Arial", 12);
            lbError.Tag = myTag;
            pnInput.Controls.Add(lbError);
        }

        private void RemoveErrorMessage(string myTag)
        {
            foreach (Label lb in pnInput.Controls.OfType<Label>())
            {
                if (lb.Tag == myTag) pnInput.Controls.Remove(lb);
            }
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                AddErrorMessage(txtFirstName, "firstname");
            }
            else
            {
                RemoveErrorMessage("firstname");
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (txtLastName.Text == "")
            {
                AddErrorMessage(txtLastName, "lastname");
            }
            else
            {
                RemoveErrorMessage("lastname");
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                AddErrorMessage(txtPhone, "phone");
            }
            else
            {
                RemoveErrorMessage("phone");
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                AddErrorMessage(txtEmail, "email");
            }
            else
            {
                RemoveErrorMessage("email");
                Regex mRegxExpression;

                if (txtEmail.Text.Trim() != string.Empty)
                {
                    mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
                    if (!mRegxExpression.IsMatch(txtEmail.Text.Trim()))
                    {
                        MessageBox.Show("5454644");
                        AddErrorMessage(txtEmail, "email", "Incorrect email format !");
                    }

                }
            }
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (txtAddress.Text == "")
            {
                AddErrorMessage(txtAddress, "address");
            }
            else
            {
                RemoveErrorMessage("address");
            }
        }

        private void dgvCustomerDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int myIndex = e.RowIndex != -1 ? e.RowIndex : 0;
            txtId.Text = listCustomers[myIndex].id.ToString();
            txtFirstName.Text = listCustomers[myIndex].firstName;
            txtLastName.Text = listCustomers[myIndex].lastName;
            txtPhone.Text = listCustomers[myIndex].phone;
            txtAddress.Text = listCustomers[myIndex].address;
            txtEmail.Text = listCustomers[myIndex].email;
            
            ddGender.SelectedIndex = listCustomers[myIndex].isFemale ? 1 : 0;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string fName = txtFirstName.Text;
            string lName = txtLastName.Text;
            string phone = txtPhone.Text;
            bool gender;
            if (ddGender.SelectedIndex == 0)
            {
                gender = false;
            }
            else
                gender = true;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            Customer customer = new Customer(id, fName, lName, phone, email, address, gender, true);
            bool deleteCustomer = customerBLL.DeleteCustomer(customer);
            if (deleteCustomer)
            {
                MessageBox.Show("Delete customer success");
            }
            LoadCustomer();
        }

        private void txtFilter_OnValueChanged(object sender, EventArgs e)
        {
            strFilter = txtFilter.Text;
            dgvCustomerDetail.DataSource = CustomerFilter(listCustomers);
        }
    }
}

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
        //DataGridView datagrid;
        public UC_Customer_Detail()
        {
            //datagrid = data;
            customerBLL = new CustomerBLL();
            InitializeComponent();
            LoadCustomer();
        }

        private int CheckFirstName()
        {
            if(txtFirstName.Text == "")
            {
                //lbErorrFName.Text = "Phải nhập";
                return 0;
            }
            //lbErorrFName.Text = "";
            return 1;
        }

        private int CheckLastName()
        {
            if (txtLastName.Text == "")
            {
                //lbErrorLName.Text = "Phải nhập";
                return 0;
            }
            //lbErrorLName.Text = "";
            return 1;
        }

        private int CheckGender()
        {
            if (ddGender.Text == "-select-")
            {
                //lbErorrGender.Text = "Phải chọn";
                return 0;
            }
            //lbErorrGender.Text = "";
            return 1;
        }

        

        private int CheckPhone()
        {
            if (txtPhone.Text == "")
            {
                //lbErorrPhone.Text = "Phải nhập";
                return 0;
            }
           // lbErorrPhone.Text = "";
            return 1;
        }

        
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                //lbErorrPhone.Text = "This input requires numbers only";
                e.Handled = true;

            }
            //else
               // lbErorrPhone.Text = "";
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void LoadCustomer()
        {
            try
            {
                List<Customer> listCustomers = customerBLL.GetAllCustomer();
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
                dgvCustomerDetail.DataSource = listCustomers;
            }
            catch
            {
                MessageBox.Show("Failed");
            }
        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckFirstName() == 0 || CheckLastName() == 0
            || CheckGender() == 0 || String.IsNullOrEmpty(txtPhone.Text)
            || String.IsNullOrEmpty(txtEmail.Text)
            || CheckPhone() == 0)

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
            bool gender = true;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            Customer customer = new Customer(id, fName, lName, phone, email, address, gender, true);
            bool editCustomer = customerBLL.EditCustomer(customer);
            if (editCustomer)
            {
                MessageBox.Show("Edit customer success");
            }
            LoadCustomer();
        }

        

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

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

        private void bunifuLabel6_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel11_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void ddGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel8_Click(object sender, EventArgs e)
        {

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
            if(dgvCustomerDetail.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvCustomerDetail.CurrentRow.Selected = true;
                txtId.Text = dgvCustomerDetail.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                txtFirstName.Text = dgvCustomerDetail.Rows[e.RowIndex].Cells["firstName"].FormattedValue.ToString();
                txtLastName.Text = dgvCustomerDetail.Rows[e.RowIndex].Cells["lastName"].FormattedValue.ToString();
                txtPhone.Text = dgvCustomerDetail.Rows[e.RowIndex].Cells["phone"].FormattedValue.ToString();
                txtEmail.Text = dgvCustomerDetail.Rows[e.RowIndex].Cells["email"].FormattedValue.ToString();
                txtAddress.Text = dgvCustomerDetail.Rows[e.RowIndex].Cells["address"].FormattedValue.ToString();

            }
        }

        private void dgvCustomerDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

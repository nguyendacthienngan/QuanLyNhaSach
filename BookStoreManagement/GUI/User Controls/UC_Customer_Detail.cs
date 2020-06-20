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

namespace GUI.User_Controls
{
    public partial class UC_Customer_Detail : UserControl
    {
        public CustomerBLL customerBLL;
        DataGridView datagrid;
        public UC_Customer_Detail(DataGridView data)
        {
            datagrid = data;
            customerBLL = new CustomerBLL();
            InitializeComponent();
            LoadCustomer();
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
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhone.Text = "";
            ddGender.Text = "-select-";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                /*if (String.IsNullOrEmpty(txtFirstName.Text) || (String.IsNullOrEmpty(txtLastName.Text) || ddGender.Text == "-select-"
             || String.IsNullOrEmpty(txtPhone.Text) || String.IsNullOrEmpty(txtAddress.Text) || String.IsNullOrEmpty(txtEmail.Text))

            {
                    MessageBox.Show("Please insert information fully !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {*/
                    
                    string fName = txtFirstName.Text;
            string lName = txtLastName.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            bool gender = (ddGender.SelectedItem.ToString() == "Female") ? true : false;
            /*while (Name.IndexOf("  ") != -1)
                    {
                        Name = Name.Replace("   ", " ");
                    }
                    Name = Name.Trim();*/
            Customer customer = new Customer(1,fName,lName,phone,email,address,gender);
        
        }
    }
}

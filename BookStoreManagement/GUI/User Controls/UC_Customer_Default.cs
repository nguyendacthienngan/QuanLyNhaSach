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
    public partial class UC_Customer_Default : UserControl
    {
        public CustomerBLL customerBLL;
        DataGridView data;
        private string strFilter = "";
        private List<Customer> listCustomers = new List<Customer>();
        public UC_Customer_Default()
        {
            customerBLL = new CustomerBLL();
            InitializeComponent();

            dgvCustomer.AutoGenerateColumns = false;

            dgvCustomer.ColumnCount = 6;
            dgvCustomer.Columns[0].HeaderText = "First Name";
            dgvCustomer.Columns[0].DataPropertyName = "firstName";

            dgvCustomer.Columns[1].HeaderText = "Last Name";
            dgvCustomer.Columns[1].DataPropertyName = "lastName";

            dgvCustomer.Columns[2].HeaderText = "Phone";
            dgvCustomer.Columns[2].DataPropertyName = "phone";

            dgvCustomer.Columns[3].HeaderText = "Email";
            dgvCustomer.Columns[3].DataPropertyName = "email";

            dgvCustomer.Columns[4].HeaderText = "Address";
            dgvCustomer.Columns[4].DataPropertyName = "address";

            dgvCustomer.Columns[5].HeaderText = "Female";
            dgvCustomer.Columns[5].DataPropertyName = "isFemale";
            dgvCustomer.DataSource = listCustomers;
            LoadCustomer();
        }

        public DataGridView GetDataGridView()
        {
            return data;
        }
        
        private void LoadCustomer()
        {
            try
            {
                listCustomers = new List<Customer>();
                listCustomers = customerBLL.GetAllCustomer();

                dgvCustomer.DataSource = CustomerFilter(listCustomers);
            }
            catch
            {
                MessageBox.Show("Failed");
            }
        }

        private List<Customer> CustomerFilter(List<Customer> lc)
        {
            List<Customer> result = new List<Customer>();
            foreach (Customer c in lc)
            {
                if (c.firstName.ToLower().IndexOf(strFilter.ToLower()) != -1
                    || c.lastName.ToLower().IndexOf(strFilter.ToLower()) != -1
                    || c.address.ToLower().IndexOf(strFilter.ToLower()) != -1
                    || c.phone.ToLower().IndexOf(strFilter.ToLower()) != -1)
                {
                    result.Add(c);
                }
            }
            return result;
        }

        private void txtFilter_OnValueChanged(object sender, EventArgs e)
        {
            strFilter = txtFilter.Text;
            dgvCustomer.DataSource = CustomerFilter(listCustomers);
        }
    }
}

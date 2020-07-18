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
        List<Customer> lstCustomers;
        public UC_Customer_Default()
        {
            customerBLL = new CustomerBLL();
            lstCustomers = customerBLL.GetAllCustomer();
            InitializeComponent();
            //loadData();
            //dgvCustomer = data;
            LoadCustomer();
        }

        public DataGridView GetDataGridView()
        {
            return data;
        }
        private void Customer_Default_Load(object sender, EventArgs e)
        {

        }

        private void LoadCustomer()
        {
            try
            {
                List<Customer> listCustomers = customerBLL.GetAllCustomer();
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
            }
            catch
            {
                MessageBox.Show("Failed");
            }
        }

        /*public DataGridView GetDataGridView()
        {
            return data;
        }*/
        public void loadData()
        {
            dgvCustomer.AutoGenerateColumns = false;

            dgvCustomer.DataSource = lstCustomers;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "id";
            column.Name = "STT";
            column.Visible = false;
            dgvCustomer.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "firstName";
            column.Name = "First Name";
            column.Visible = true;
            dgvCustomer.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "lastName";
            column.Name = "Last Name";
            column.Visible = true;
            dgvCustomer.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "phone";
            column.Name = "Phone";
            dgvCustomer.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "email";
            column.Name = "Email";
            dgvCustomer.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "address";
            column.Name = "Address";
            dgvCustomer.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "isFemale";
            column.Name = "Gender";
            dgvCustomer.Columns.Add(column);

            data = dgvCustomer;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }
    }
}

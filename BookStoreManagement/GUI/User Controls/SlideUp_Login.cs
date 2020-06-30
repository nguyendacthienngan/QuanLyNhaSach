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
namespace GUI.User_Controls
{
    public partial class SlideUp_Login : UserControl
    {
        public delegate void OnFinish();
        public event OnFinish onFinish;
        public EmployeeBLL employeeBLL;
        int waiter = 0, waiter2 = 0;
        int panel1_y = 519;
        public SlideUp_Login()
        {
            InitializeComponent();
            DoubleBuffered = true;
            employeeBLL = new EmployeeBLL();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password)) 
            {
                if (String.IsNullOrEmpty(username))
                    MessageBox.Show("You need to insert username");
                else
                    MessageBox.Show("You need to insert password");
            }
            else
            {
                // Đăng nhập đúng
                if(employeeBLL.CheckLoginAsync(username,password)==true)
                    timer1.Enabled = true;
                // Đăng nhập sai
                else
                    MessageBox.Show("Wrong password/username. Please try again");
            }
           
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1_y -= 17;
            panel1.Size = new Size(panel1.Size.Width, panel1_y);
            if (panel1_y < 1)
            {
                panel1.Hide();
                timer1.Enabled = false;
                timer2.Enabled = true;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
                {
                    if (String.IsNullOrEmpty(username))
                        MessageBox.Show("You need to insert username");
                    else
                        MessageBox.Show("You need to insert password");
                }
                else
                {
                    // Đăng nhập đúng
                    if (employeeBLL.CheckLoginAsync(username, password) == true)
                        timer1.Enabled = true;
                    // Đăng nhập sai
                    else
                        MessageBox.Show("Wrong password/username. Please try again");
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            waiter2++;
            if (waiter2 > 50)
            {
                timer2.Stop();
                onFinish();
            }
        }
    }
}

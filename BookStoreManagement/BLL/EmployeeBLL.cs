using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
namespace BLL
{
    public class EmployeeBLL
    {
        EmployeeDAL employeeDAL;
        public EmployeeBLL()
        {
            employeeDAL = new EmployeeDAL();
        }
        public bool CheckLoginAsync(string username, string password)
        {
            Console.WriteLine("Hello from BLL");
            try
            {
                string result = "";
                bool checkLogin = employeeDAL.CheckLoginAsync(username, password, ref result);
                if (checkLogin == true)
                    return true;
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
            
        }
        public List<User> GetAllEmployee()
        {
            try
            {
                List<User> users = employeeDAL.GetAllEmployee();
                return users;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool AddUser(User user1, Account account1)
        {
            bool result = employeeDAL.AddEmployee(user1, account1);
            return result;
        }
        public User FindEmployee(int id)
        {
            return employeeDAL.FindEmployee(id);
        }
        public List<User> SearchUser(string x)
        {
            List<User> users = employeeDAL.SearchUser(x);
            return users;
        }
        public bool EditUser(User user1)
        {
            return employeeDAL.EditUser(user1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
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
                bool checkLogin = employeeDAL.CheckLoginAsync(username, password).Result;
                if (checkLogin == true)
                    return true;
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
            
        }
    }
}

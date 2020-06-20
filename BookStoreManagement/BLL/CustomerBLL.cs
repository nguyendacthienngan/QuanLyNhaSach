using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
namespace BLL
{
    public class CustomerBLL
    {
        CustomerDAL customerDAL;
        public CustomerBLL()
        {
            customerDAL = new CustomerDAL();
        }

        public List<Customer> GetAllCustomer()
        {
            try
            {
                List<Customer> customers = customerDAL.GetAllCustomer();
                return customers;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool AddCustomer(Customer e)
        {
            return customerDAL.AddCustomer(e);
        }
    }
}


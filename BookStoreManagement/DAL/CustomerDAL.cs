using System;
using System.Collections.Generic;
using Model;
using Newtonsoft.Json;

namespace DAL
{
    public class CustomerDAL
    {
        private string root = "http://localhost:8080/";
        //private string DATA;

        public CustomerDAL()
        {

        }

        public List<Customer> GetAllCustomer()
        {
            string url = root + "customer";
            CallAPI cal = new CallAPI();
            string jsonResult = "";
            cal.callAPI(url, null, "GET", ref jsonResult);
            try
            {
                List<Customer> allCustomers = JsonConvert.DeserializeObject<List<Customer>>(jsonResult); // Trả về danh sách Object User
                return allCustomers;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool AddCustomer(Customer e)
        {
            try
            {
                if (e != null)
                {
                    string url = root + "customer/add";
                    CallAPI cal = new CallAPI();
                    string json = JsonConvert.SerializeObject(e);
                    string jsonResult = "";
                    return cal.callAPI(url, json, "POST", ref jsonResult);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool EditCustomer(Customer e)
        {
            try
            {
                if (e != null)
                {
                    string url = root + "customer/update";
                    CallAPI cal = new CallAPI();
                    string json = JsonConvert.SerializeObject(e);
                    string jsonResult = "";
                    return cal.callAPI(url, json, "PUT", ref jsonResult);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteCustomer(Customer e)
        {
            try
            {
                if (e != null)
                {
                    string url = root + "customer/delete";
                    CallAPI cal = new CallAPI();
                    string json = JsonConvert.SerializeObject(e);
                    string jsonResult = "";
                    return cal.callAPI(url, json, "POST", ref jsonResult);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}


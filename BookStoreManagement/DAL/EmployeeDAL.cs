using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DAL
{
    public class EmployeeDAL
    {

        private const string URL = "http://localhost:8080/auth/login";
        private string DATA ;
        
        public EmployeeDAL()
        {
            
        }
        public bool CheckLoginAsync(string U, string P)
        {
            //String req_body = "{\"username\": \"admin\", \"password\": \"admin\"}";
            //JObject json = JObject.Parse(req_body);
            // DATA = @"{""username"":""admin"", ""password"":""admin""}";
            string DATA = "{\"username\":\"" + U;
             DATA += "\", \"password\": \"" + P + "\"}";
            CallAPI cal = new CallAPI();
            return cal.callAPI(URL, DATA);
            
        }
    }
}

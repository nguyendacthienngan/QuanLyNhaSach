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
        public async Task<bool> CheckLoginAsync(string U, string P)
        {
            //String req_body = "{\"username\": \"admin\", \"password\": \"admin\"}";
            //JObject json = JObject.Parse(req_body);
            // DATA = @"{""username"":""admin"", ""password"":""admin""}";
            string DATA = "{\"username\":\"" + U;
             DATA += "\", \"password\": \"" + P + "\"}";
            Console.WriteLine("Hello from DAL");
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = DATA.Length;
            using (Stream webStream = request.GetRequestStream())
            using (StreamWriter requestWriter = new StreamWriter(webStream, System.Text.Encoding.ASCII))
            {
                requestWriter.Write(DATA);
            }

            try
            {
                WebResponse webResponse = request.GetResponse();
                using (Stream webStream = webResponse.GetResponseStream() ?? Stream.Null)
                using (StreamReader responseReader = new StreamReader(webStream))
                {
                    string response = responseReader.ReadToEnd();
                    //200 Ok : "message: success"
                    return true;
                }
            }
            catch (Exception e)
            {
                //400 Bad request
                Console.WriteLine("-----------------");
                Console.WriteLine(e.Message);
                return false;
            }

            
            
           
        }
    }
}

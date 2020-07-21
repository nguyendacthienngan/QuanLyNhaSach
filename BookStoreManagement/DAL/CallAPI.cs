using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL
{
    public class CallAPI
    {
        // Nói sơ lược về hàm CallAPI này:
        // Tham số truyền vào là url (khi nẫy mình nói), data truyền vào, method sử dụng, result - kết quả trả về 
        // về method GET
        // Thì GET sẽ không có DATA nên mình sẽ không cần gán ContentLength hay DATA
        // về method POST 
        // POST nghĩa là mình sẽ truyền 1 body với 1 file JSON (DATA) => Nên phải truyền contentlength với data
        // kết quả trả về của hàm callAPI này là true hoặc false, 200 OK hay 400 bad request 
        // RESULT kết quả trả về là file JSON thì mình sẽ truyền vào tham số RESULT với tham chiếu (ref)

        public bool callAPI(string URL, string DATA, string METHOD, ref string RESULT)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Method = METHOD; // "POST", "GET"
            request.ContentType = "application/json";
            if (METHOD == "POST" || METHOD == "PUT"|| METHOD=="DELETE")
            {
                request.ContentLength = DATA.Length;
                using (Stream webStream = request.GetRequestStream())
                using (StreamWriter requestWriter = new StreamWriter(webStream, System.Text.Encoding.ASCII))
                {
                    requestWriter.Write(DATA);
                }
            }
            

            try
            {
                WebResponse webResponse = request.GetResponse();
                using (Stream webStream = webResponse.GetResponseStream() ?? Stream.Null)
                using (StreamReader responseReader = new StreamReader(webStream))
                {
                    string response = responseReader.ReadToEnd();
                    //200 Ok : "message: success"
                    RESULT = response;
                    return true;
                }
            }
            catch (Exception e)
            {
                //400 Bad request
                Console.WriteLine("-----------------");
                Console.WriteLine(e.Message);
                //RESULT = null;
                return false;
            }
        }
    }
}

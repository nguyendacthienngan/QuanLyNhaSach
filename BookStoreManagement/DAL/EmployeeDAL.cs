using System;
using System.Collections.Generic;
using Model;
using Newtonsoft.Json;

namespace DAL
{
    public class EmployeeDAL
    {
        // Sau đó mọi người vào visual studio ai chưa có thì tạo bên DAL nha. Tui chỉ tạo demo cái EmployeeDAL thui, còn mọi người làm chwusc năng nào thì tạo tên theo cú pháp <chức năng>DAL

        private string root = "http://localhost:8080/"; // Lúc này root mọi người thì cứ ghi y chang vầy nha, do mình quy định ớ.
        private string DATA ;
        
        public EmployeeDAL()
        {
            
        }
        public bool CheckLoginAsync(string U, string P, ref string Result)
        {
            string url = root + "auth/login";
            //String req_body = "{\"username\": \"admin\", \"password\": \"admin\"}";
            //JObject json = JObject.Parse(req_body);
            // DATA = @"{""username"":""admin"", ""password"":""admin""}";
            DATA = "{\"username\":\"" + U;
            DATA += "\", \"password\": \"" + P + "\"}";
            CallAPI cal = new CallAPI();
            string jsonResult = ""; // trả về JSON
            return cal.callAPI(url, DATA, "POST", ref jsonResult);
        }
        public List<User> GetAllEmployee()
        {
            // Ví dụ về getAllEmployee
            // Tui mún tạo request với url là  "http://localhost:8080/user nên tui sẽ ghi là root + "user" là do vậy
            // Lúc này mún gọi API qua server thì mọi người dùng hàm callAPI nha, tui viết sẵn hàm cho mọi người ròi
            string url = root + "user";
            CallAPI cal = new CallAPI();
            string jsonResult = "";
            cal.callAPI(url, null, "GET", ref jsonResult);
            try
            {
                // Trong project Model tui đã tạo các class đại diện cho các object, ví dụ User sẽ có object là User tương ứng với bảng User trong database
                // Vậy khi trả về kết quả (response) từ server người ta trả về file JSON làm sao có thể convert từ file JSON sang object mình muốn?
                // Mình sẽ dùng thư viện Newtonsoft.Json;
                // Sau đó sẽ dùng theo cách tui dùng nha:
                // Ví dụ: Muốn trả về 1 Object là User. 

                //JsonConvert.DeserializeObject<User>(jsonResult); // Trả vè 1 Object User

                // Còn muốn trả về 1 danh sách User:
                List<User> allUsers = JsonConvert.DeserializeObject<List<User>>(jsonResult); // Trả về danh sách Object User
                return allUsers;
            }
            catch (Exception e)
            {
                return null;
            }      
        }

        public bool AddEmployee(User user1)
        {
            string url = root + "user/add";
            CallAPI cal = new CallAPI();
            string json = JsonConvert.SerializeObject(user1);
            string jsonResult = "";
            return cal.callAPI(url, json, "POST", ref jsonResult);

        }
        public User FindEmployee(int id)
        {
            string url = root + "user/" + id;
            CallAPI cal = new CallAPI();      
            string jsonResult = "";
            cal.callAPI(url, null, "GET", ref jsonResult);
            User user1 = JsonConvert.DeserializeObject<User>(jsonResult);
            return user1;
        }
    }
}

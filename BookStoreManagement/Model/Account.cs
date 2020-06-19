using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Account
    {
        private int userId;

        private string userName;

        private string password;

        private string role;

        public Account(int id, string userName, string password, string role)
        {
            this.UserId = id;
            this.UserName = userName;
            this.Password = password;
            this.Role = role;
        }

        public int UserId { get => userId; set => userId = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
    }
}

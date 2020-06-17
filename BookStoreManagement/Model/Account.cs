using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Account
    {
        private int _userId;

        private string _userName;

        private string _password;

        public Account(int id, string userName, string password)
        {
            this.UserId = id;
            this.UserName = userName;
            this.Password = password;
        }

        public int UserId { get => _userId; set => _userId = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string Password { get => _password; set => _password = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Account
    {
        private int _userId;

        private string _userName;

        private string _password;

        private string _role;

        public Account(int id, string userName, string password, string role)
        {
            this.userId = id;
            this.userName = userName;
            this.password = password;
            this.role = role;
        }

        public int userId { get => _userId; set => _userId = value; }
        public string userName { get => _userName; set => _userName = value; }
        public string password { get => _password; set => _password = value; }
        public string role { get => _role; set => _role = value; }
    }
}

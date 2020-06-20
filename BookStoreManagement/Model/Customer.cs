using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Customer
    {
        private int _id;

        private string _firstName;

        private string _lastName;
        
        private string _phone;
        
        private string _email;
        
        private string _address;

        private bool _isFemale;
        public Customer(int id, string firstName, string lastName, string phone, string email, string address, bool isFemale)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
            this.email = email;
            this.address = address;
            this.isFemale = isFemale;
        }


        public int id { get => _id; set => _id = value; }
        public string firstName { get => _firstName; set => _firstName = value; }
        public string lastName { get => _lastName; set => _lastName = value; }
        public string phone { get => _phone; set => _phone = value; }
        public string email { get => _email; set => _email = value; }
        public string address { get => _address; set => _address = value; }
        public bool isFemale { get => _isFemale; set => _isFemale = value; }
    }
}

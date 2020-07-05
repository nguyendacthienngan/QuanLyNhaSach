using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Customer
    {
        private int _id;

        private string _firstName;

        private string _lastName;
        
        private string _phone;
        
        private string _email;
        
        private string _address;

        private bool _isFemale;

        private bool _isMember;

        public Customer(int id, string firstName, string lastName, string phone, string email, string address, bool isFemale, bool isMember)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
            this.email = email;
            this.address = address;
            this.isFemale = isFemale;
            this.isMember = isMember;
        }


        public int id { get => _id; set => _id = value; }
        public string firstName { get => _firstName; set => _firstName = value; }
        public string lastName { get => _lastName; set => _lastName = value; }
        public string phone { get => _phone; set => _phone = value; }
        public string email { get => _email; set => _email = value; }
        public string address { get => _address; set => _address = value; }
        public bool isFemale { get => _isFemale; set => _isFemale = value; }
        public bool isMember { get => _isMember; set => _isMember = value; }
    }
}

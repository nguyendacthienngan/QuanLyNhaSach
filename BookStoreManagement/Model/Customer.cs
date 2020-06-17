using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Customer
    {
        private int id;

        private string firstName;

        private string lastName;
        
        private string phone;
        
        private string email;
        
        private string address;

        private bool isFemale;
        public Customer(int id, string firstName, string lastName, string phone, string email, string address, bool isFemale)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
            this.Email = email;
            this.Address = address;
            this.IsFemal = isFemale;
        }


        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public bool IsFemal { get => isFemale; set => isFemale = value; }
    }
}

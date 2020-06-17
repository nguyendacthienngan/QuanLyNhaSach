﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class User
    {
        private int _userId;
        
        private string _firstName;
        
        private string _lastName;
        
        private string _phone;
        
        private string _email;

        private string _address;

        public User(int id, string firstName, string lastName, string phone, string email, string address)
        {
            this.UserId = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
            this.Email = email;
            this.Address = address;
        }

        public int UserId { get => _userId; set => _userId = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Email { get => _email; set => _email = value; }
        public string Address { get => _address; set => _address = value; }
    }
}

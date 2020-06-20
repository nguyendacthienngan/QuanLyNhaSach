using System;
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

        private DateTime _dateOfBirth;

        private bool _isFemale;

<<<<<<< Updated upstream
        private bool isCard;

        public User(int userId, string firstName, string lastName, string phone, string email, string address, DateTime dateOfBirth, bool isFemale, bool isCard)
        {
            this.UserId = userId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
            this.Email = email;
            this.Address = address;
            this.DateOfBirth = dateOfBirth;
            this.IsFemale = isFemale;
            this.IsCard = isCard;
        }

        public int UserId { get => userId; set => userId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public bool IsFemale { get => isFemale; set => isFemale = value; }
        public bool IsCard { get => isCard; set => value = value; }
    }
=======
        private string _idCard;
        
        public User(int userId, string firstName, string lastName, string phone, string email, string address, DateTime dateOfBirth, bool isFemale, string idCard)
        {
            this.userId = userId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
            this.email = email;
            this.address = address;
            this.dateOfBirth = dateOfBirth;
            this.isFemale = isFemale;
            this.idCard = idCard;
        }

        public int userId { get => _userId; set => _userId = value; }
        public string firstName { get => _firstName; set => _firstName = value; }
        public string lastName { get => _lastName; set => _lastName = value; }
        public string phone { get => _phone; set => _phone = value; }
        public string email { get => _email; set => _email = value; }
        public string address { get => _address; set => _address = value; }
        public DateTime dateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value; }
        public bool isFemale { get => _isFemale; set => _isFemale = value; }
        public string idCard { get => _idCard; set => _idCard = value; }
}
>>>>>>> Stashed changes
}

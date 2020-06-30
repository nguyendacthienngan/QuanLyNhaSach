using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        private int _id;

        private string _firstName;

        private string _lastName;

        private string _phone;

        private string _email;

        private string _address;

        private DateTime _dateOfBirth;

        private bool _isFemale;

        private string _idCard;

        public User(int userId, string firstName, string lastName, string phone, string email, string address, DateTime dateOfBirth, bool isFemale, string idCard)
        {
            this.id = userId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
            this.email = email;
            this.address = address;
            this.dateOfBirth = dateOfBirth;
            this.isFemale = isFemale;
            this.idCard = idCard;
        }

        public int id { get => _id; set => _id = value; }
        public string firstName { get => _firstName; set => _firstName = value; }
        public string lastName { get => _lastName; set => _lastName = value; }
        public string phone { get => _phone; set => _phone = value; }
        public string email { get => _email; set => _email = value; }
        public string address { get => _address; set => _address = value; }
        public DateTime dateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value; }
        public bool isFemale { get => _isFemale; set => _isFemale = value; }
        public string idCard { get => _idCard; set => _idCard = value; }
    }
}

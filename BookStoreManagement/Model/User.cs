using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        private int userId;
        
        private string firstName;
        
        private string lastName;
        
        private string phone;
        
        private string email;

        private string address;

        private DateTime dateOfBirth;

        private bool isFemale;

        private string idCard;
        
        public User(int userId, string firstName, string lastName, string phone, string email, string address, DateTime dateOfBirth, bool isFemale, string idCard)
        {
            this.UserId = userId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
            this.Email = email;
            this.Address = address;
            this.DateOfBirth = dateOfBirth;
            this.IsFemale = isFemale;
            this.IdCard = idCard;
        }

        public int UserId { get => userId; set => userId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public bool IsFemale { get => isFemale; set => isFemale = value; }
        public string IdCard { get => idCard; set => idCard = value; }
}
}

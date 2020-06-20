using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Book
    {
        private int _id;

        private string _bookTitle;

        private string _author;

        private int _stock;

        private float _cost;

        private float _price;

        private string _type;

        private string _description;

        public Book(int id, string bookTitle, string author, int stock, float cost, float price, string type, string description)
        {
            this.id = id;
            this.bookTitle = bookTitle;
            this.author = author;
            this.stock = stock;
            this.cost = cost;
            this.price = price;
            this.type = type;
            this.description = description;
        }

        public int id { get => _id; set => _id = value; }
        public string bookTitle { get => _bookTitle; set => _bookTitle = value; }
        public string author { get => _author; set => _author = value; }
        public int stock { get => _stock; set => _stock = value; }
        public float cost { get => _cost; set => _cost = value; }
        public float price { get => _price; set => _price = value; }
        public string type { get => _type; set => _type = value; }
        public string description { get => _description; set => _description = value; }

    }
}

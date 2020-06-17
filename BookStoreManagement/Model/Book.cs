using System;
using System.Collections.Generic;
using System.Linq;
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

        public Book(int id, string bookTitle, string author, int stock, float cost, float price, string type)
        {
            this.Id = id;
            this.BookTitle = bookTitle;
            this.Author = author;
            this.Stock = stock;
            this.Cost = cost;
            this.Price = price;
            this.Type = type;
        }

        public int Id { get => _id; set => _id = value; }
        public string BookTitle { get => _bookTitle; set => _bookTitle = value; }
        public string Author { get => _author; set => _author = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public float Cost { get => _cost; set => _cost = value; }
        public float Price { get => _price; set => _price = value; }
        public string Type { get => _type; set => _type = value; }

    }
}

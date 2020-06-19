using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Book
    {
        private int id;

        private string bookTitle;

        private string author;

        private int stock;

        private float cost;

        private float price;

        private string type;

        private string description;

        public Book(int id, string bookTitle, string author, int stock, float cost, float price, string type, string description)
        {
            this.Id = id;
            this.BookTitle = bookTitle;
            this.Author = author;
            this.Stock = stock;
            this.Cost = cost;
            this.Price = price;
            this.Type = type;
            this.Description = description;
        }

        public int Id { get => id; set => id = value; }
        public string BookTitle { get => bookTitle; set => bookTitle = value; }
        public string Author { get => author; set => author = value; }
        public int Stock { get => stock; set => stock = value; }
        public float Cost { get => cost; set => cost = value; }
        public float Price { get => price; set => price = value; }
        public string Type { get => type; set => type = value; }
        public string Description { get => description; set => description = value; }

    }
}

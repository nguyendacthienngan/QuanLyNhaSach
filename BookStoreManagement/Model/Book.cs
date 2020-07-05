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
        private int _id;

        private string _bookTitle;

        private string _author;

        private int _stock;

        private float _cost;

        private float _price;

        private string _genre;

        private string _description;

        private DateTime _releasedDate;

        private string _imageUrl;

        public Book(int id, string bookTitle, string author, int stock, float cost, float price, string genre, string description, DateTime releasedDate, string imageUrl)
        {
            this.id = id;
            this.bookTitle = bookTitle;
            this.author = author;
            this.stock = stock;
            this.cost = cost;
            this.price = price;
            this.genre = genre;
            this.description = description;
            this.releasedDate = releasedDate;
            this.imageUrl = imageUrl;
        }

        public int id { get => _id; set => _id = value; }
        public string bookTitle { get => _bookTitle; set => _bookTitle = value; }
        public string author { get => _author; set => _author = value; }
        public int stock { get => _stock; set => _stock = value; }
        public float cost { get => _cost; set => _cost = value; }
        public float price { get => _price; set => _price = value; }
        public string genre { get => _genre; set => _genre = value; }
        public string description { get => _description; set => _description = value; }
        public DateTime releasedDate { get => _releasedDate; set => _releasedDate = value; }
        public string imageUrl { get => _imageUrl; set => _imageUrl = value; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStoreMVC.Models;
namespace BookStoreMVC.Data
{
    public class BookInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            var books = new List<Book>()
            {
                new Book { BookName = "The Little Prince", Author = "Antoine de Saint-Exupéry", ProducedDate = new DateTime(1943,4,1) , Price = 45000},
                new Book { BookName = "To Kill a Mockingbird", Author = "Harper Lee", ProducedDate = new DateTime(1960,7,11) , Price = 72000},
                new Book { BookName = "How to stop worrying and start living", Author = "Dale Carnegie", ProducedDate = new DateTime(1948,0,0), Price = 45600},
                new Book { BookName = "Men Are from Mars, Women Are from Venus", Author = "John Gray", ProducedDate = new DateTime(1992,1,1), Price = 112800},
                new Book { BookName = "Coffee with Tony", Author = "Tony Morning", ProducedDate = new DateTime(2014,0,0) , Price = 53499},

            };
            books.ForEach(b => context.Books.Add(b));
            context.SaveChanges();
        }
    }
}
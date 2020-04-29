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
            IList<Book> books = new List<Book>();
            books.Add(new Book()
            {
                BookName = "The Little Prince",
                Author = "Antoine de Saint-Exupéry",
                ProducedDate = new DateTime(2015, 4, 1),
                Price = 45000
            });
            books.Add(new Book()
            {
                BookName = "How to stop worrying and start living",
                Author = "Dale Carnegie",
                ProducedDate = new DateTime(2003, 11, 1),
                Price = 45600
            });
            books.Add(new Book()
            {
                BookName = "Men Are from Mars, Women Are from Venus",
                Author = "John Gray",
                ProducedDate = new DateTime(2002, 1, 1),
                Price = 112800
            });
            books.Add(new Book()
            {
                BookName = "Coffee with Tony",
                Author = "Tony Morning",
                ProducedDate = new DateTime(2014, 3, 1),
                Price = 53499
            });
            foreach (Book book in books)
            context.Books.Add(book);
            base.Seed(context);
        }
    }
}
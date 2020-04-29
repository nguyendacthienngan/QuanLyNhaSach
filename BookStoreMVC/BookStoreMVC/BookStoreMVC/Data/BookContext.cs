using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStoreMVC.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;

namespace BookStoreMVC.Data
{
    public class BookContext : DbContext
    {
        public BookContext()
            : base("BookContext")
        {
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
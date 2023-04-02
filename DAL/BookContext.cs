using BookStoreApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace BookStoreApplication.DAL
{
    public class BookContext : DbContext
    {
        public BookContext() : base("name=BookContext")
        {
            Database.SetInitializer(new BookInitializer());
        }

        public virtual DbSet<Book> Books { get; set; }

        public class BookInitializer : DropCreateDatabaseIfModelChanges<BookContext>
        {
            protected override void Seed(BookContext context)
            {
                context.Books.Add(new Book { Name = "The Great Gatsby", Author = "F. Scott Fitzgerald" });
                context.Books.Add(new Book { Name = "To Kill a Mockingbird", Author = "Harper Lee" });
                context.Books.Add(new Book { Name = "1984", Author = "George Orwell" });
                context.SaveChanges();
            }
        }
    }
}
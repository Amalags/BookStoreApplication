using BookStoreApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApplication.DAL
{
    public class BookInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            var books = new List<Book>
            {
            new Book{Name="Book1",Author="Alexander"},
            new Book{Name="Book2",Author="Alonso"},
            new Book{Name="Book3",Author="Alexander"},
            new Book{Name="Book4",Author="Barzdukas"},
            new Book{Name="Book5",Author="Alonso"},
            };

            books.ForEach(b => context.Books.Add(b));
            context.SaveChanges();
        }
    }
}
using BookStoreApplication.DAL;
using BookStoreApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStoreApplication.Controllers
{
    public class BookController : Controller
    {
        private BookContext _dbContext = new BookContext();

        public ActionResult Index()
        {
            var books = _dbContext.Books.ToList();
            ViewBag.DataSource = books;
            return View(books);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Books.Add(book);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(book);
        }
    }
}
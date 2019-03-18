using LibraryReport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryReport.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext();
        public ActionResult Index()
        {
            var books = db.Books;
            ViewBag.Books = books;
            return View();
        }
        [HttpGet]
        public ActionResult Read(int id)
        {
            ViewBag.BookId = id;
            return View();
        }
        [HttpPost]
        public string Read (Borrow borrow)
        {
            borrow.Date = DateTime.Now;
            db.Borrows.Add(borrow);
            db.SaveChanges();
            return borrow.Person + ", дякую, що скористались послугами нашої бібліотеки.";
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
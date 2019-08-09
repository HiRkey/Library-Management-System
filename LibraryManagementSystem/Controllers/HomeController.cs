using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagementSystem.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();


        public ActionResult Index()
        {
            return View();
        }


        public ActionResult BookSearch(string q)
        {
            var books = GetBooks(q);
            return PartialView(books);
        }


        public ActionResult QuickSearch(string term)
        {
            var books = GetBooks(term).Select(a => new { value = a.Title });
            return Json(books, JsonRequestBehavior.AllowGet);
        }

        private List<Book> GetBooks(string searchString)
        {
            return db.Books.Where(a => a.Title.Contains(searchString)).ToList();
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
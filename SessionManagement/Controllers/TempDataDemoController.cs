using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SessionManagement.Models;

// Temp Data will allow you to pass data from one action to another. 

namespace SessionManagement.Controllers
{
    public class TempDataDemoController : Controller
    {
        // GET: TempDataDemo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowTempData()
        {
            Book book = new Book()
                            {
                                Id = 301,
                                BookName = "Python",
                                Author = "Savich",
                                ISBN = "2154kldk"
                            };
            TempData["BookData"] = book;
            return RedirectToAction("ShowTempData2");
        }
        public ActionResult ShowTempData2()
        {
            Book book = TempData["BookData"] as Book;

            return this.View(book);
        }
    }
}
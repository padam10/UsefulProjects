using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SessionManagement.Models;

// TempData you can pass the data between the actions but it gets destroyed after the susequent request. 
//with the help of the session the data is available everywhere but you need to make sure to dispose 
// it when you are done using it. 
// 

namespace SessionManagement.Controllers
{
    public class SessionDemoController : Controller
    {
        // GET: SessionDemo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BookView()
        { 
            Book book = new Book()
                            {
                                Id= 254,
                                Author = "Gates",
                                BookName = "Msdn",
                                ISBN = "2254uyt"
                            };
            Session["BookInfo"] = book;

            return RedirectToAction("BookViewSession");
        }
        
        public ActionResult BookViewSession()
        {
            Book book = Session["BookInfo"] as Book;

            return this.View(book);
        }
    }
}
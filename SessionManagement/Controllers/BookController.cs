using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SessionManagement.Models;


namespace SessionManagement.Controllers
{
    using SessionManagement.Models;

    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            //http://localhost:53358/Book/index to view in the browser
            ViewData["Message"] = "Message from ViewData";

            return this.View();
            
        }

        public ActionResult ViewBagDemo()
        {
            ViewBag.Message = "Message from ViewBag";

            return this.View();
        }
        
        

        public ActionResult ShowBooks()
        {
            Book book = new Book()
                            {
                                Id = 1,
                                BookName = "Asp.net",
                                Author = "Dino",
                                ISBN = "ABC24567CD"
                            };
            return this.View(book);
        }



        // use of viewmodel to extract the data
        public ActionResult ShowBooks2()
        {
            Book book = new Book()
                            {
                                Id = 2,
                                BookName = "Intro to MVC",
                                Author = "Galloway",
                                ISBN = "3215EH84"
                            };
            Message message = new Message()
                                  {
                                      MessageText = "This is a test message",
                                      MessageFrom = "Padam"
                                  };

            ShowBookAndMessageViewModel viewModel = new ShowBookAndMessageViewModel()
                                                        {
                                                            Book = book,
                                                            Message = message
                                                        };
            return View(viewModel);
        }

       
    }
}
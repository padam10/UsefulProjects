using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QureryStringDemo.Controllers
{
    public class HomeController : Controller
    {

        // When you run it type: http://localhost:51395/?name=Padam&course=mvc in the browser
        // and it will be able to display name in in the browser
        // but this is not used frequently
        // parameters with / are used more frequently and good for searching. 

        public string Index(string name, string course)
        {
            return "Hello World: " + name + " Course is : " + course ;
        }
    }
}
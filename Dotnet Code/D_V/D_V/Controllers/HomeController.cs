using D_V.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace D_V.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            ViewData["messag"] = "thisav os msg";
            
            string[] a = { "apple","jeary","banana"};
            ViewData["fruit"] = a;

            ViewData["list"] = new List<string>()
            {
                "banana",
                "mango",
                "graps"
            };

            Employee am = new Employee();
            {
                am.id = 1;
                am.name = "shri";
                am.age = 22;

            }

            ViewData["emp"] = am;
            return View();
        }
	}
}
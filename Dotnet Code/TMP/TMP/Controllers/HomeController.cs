using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TMP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TempData["msg"] = "hii shri";
            string []a = { "ram","shyam"};
            TempData["aa"] = a;
            return View();
        }

        public ActionResult About()
        {
            

            return View();
        }

       
    }
}
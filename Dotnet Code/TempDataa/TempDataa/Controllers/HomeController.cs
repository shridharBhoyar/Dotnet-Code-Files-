using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TempDataa.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            TempData["msg"] = "hii shri";

            string[] a = { "aa","bb","cc"};
            TempData["msgarray"] = a;

            var aa = new List<string>()
            {
                "shri",
                "rahul",
                "sagar"
            };
            TempData["array"]=aa;

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
       
	}
}
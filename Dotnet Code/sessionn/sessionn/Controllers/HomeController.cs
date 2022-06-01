using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sessionn.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Session["msg"]="hii shri";

            string[]a={"ram","shyam",};
            Session["rray"] = a;

            var ab = new List <string>
            {
                "a",
                "b",
                "c"
            };
            Session["list"] = ab;
            return View();
        }

        public ActionResult About()
        {
            

            return View();
        }

        public ActionResult Info()
        {


            return View();
        }

    }
}
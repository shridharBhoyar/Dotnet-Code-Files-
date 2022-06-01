using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dayfirst_asp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public string Index()
        {
            return "my nam is shri";
        }
        public string name()
        {
            return "wellcome";
        }

        public string surnam(int a)
        {

            return "surnam"+a;
        }

	}
}
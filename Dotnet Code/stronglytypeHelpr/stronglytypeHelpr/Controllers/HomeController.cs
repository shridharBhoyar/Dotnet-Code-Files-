using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using stronglytypeHelpr.Models;

namespace stronglytypeHelpr.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index(Employee e)
        {
            return View();
        }
	}
}
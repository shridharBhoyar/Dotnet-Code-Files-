using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAnotation.Models;

namespace DataAnotation.Controllers
{
    public class HomeController : Controller
    {
         
        // GET: /Home/
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Index(employee e)
        {

            return View();
        }
	}
}
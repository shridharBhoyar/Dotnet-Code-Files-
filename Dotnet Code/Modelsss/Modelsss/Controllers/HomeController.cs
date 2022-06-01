using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Modelsss.Models;


namespace Modelsss.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {


            var a = gtemployee();
            return View(a);
        }

        private Employee gtemployee()
        {
            return new Employee()
            {
                id = 2,
                age = 22
            };
        }
	}
}
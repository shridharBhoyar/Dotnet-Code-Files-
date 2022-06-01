using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using modelss.Models;

namespace modelss
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            var data = getemp();
            return View(data);
        }

        private employee getemp()
        {
            return new employee()
            {
                id = 1,
                stander = 12,
                age = 22
            };
        }
	}
}
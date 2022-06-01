using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Models;

namespace Models.Controllers
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
                id=11,
                name="shri",
                age=22
            };
        }

        
	}
}
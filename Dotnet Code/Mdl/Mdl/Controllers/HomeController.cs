using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mdl.Models;

namespace Mdl.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            var a = gtemp();
           
            return View(a);
        }
        private Employee gtemp()
        {
            return new Employee()
            {
                 id=1,
                 age=22            };
        }
	}
}
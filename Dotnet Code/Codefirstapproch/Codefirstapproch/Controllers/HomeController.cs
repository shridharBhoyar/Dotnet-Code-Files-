using Codefirstapproch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Codefirstapproch.Controllers
{
    public class HomeController : Controller
    {
        stdcontex db = new stdcontex();
        // GET: /Home/
        public ActionResult Index()
        {
            var data = db.stuents.ToList();
            return View(data);
        }
	}
}
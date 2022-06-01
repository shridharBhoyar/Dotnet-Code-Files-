using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBagg.Models;

namespace ViewBagg.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            ViewBag.msg = "hii shri";
            string[] bb = { "shri","hunaram","bhoyar"};
            ViewBag.arr = bb;
            var aa = new List<string>()
            {
                "shri",
                "rahul",
                "manish"
            };
            ViewBag.mm = aa;
            var a = getemp();
            return View(a);
        }

        private Employeee getemp()
        {
            return new Employeee()
            {
                id = 1,
                name="shri",
                age=22
            };
        }
	}
}
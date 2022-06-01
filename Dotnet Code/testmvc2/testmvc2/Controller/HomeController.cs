using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testmvc2.Models;

namespace testmvc2.Controllers
{
    public class HomeController : Controller
    {
        practiceEntities db = new practiceEntities();
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(studentData a)
        {

            db.studentDatas.Add(a);
            db.SaveChanges();
            return View();
        }
	}
}
using DatabaseFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseFirst.Controllers
{
    public class HomeController : Controller
    {
        mystudentEntities db = new mystudentEntities(); 
        // GET: /Home/
        public ActionResult Index()
        {
            var data = db.studentDatas.ToList();
            return View(data);
        }
	}
}
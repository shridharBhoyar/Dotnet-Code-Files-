using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using demo.Models;
using System.Data.Entity;

namespace demo.Controllers
{
    public class HomeController : Controller
    {
        practiceEntities1 db = new practiceEntities1();
        // GET: /Home/
        public ActionResult Index()
        {
          var data=  db.employee_tbl.ToList();
            return View(data);
        }


        public ActionResult Delete(int id)
        {
            var row = db.employee_tbl.Where(model => model.emp_id == id).FirstOrDefault();

            return View(row);
        }


        [HttpPost]
        public ActionResult Delete(employee_tbl s)
        {
            db.Entry(s).State = EntityState.Deleted;
            db.SaveChanges();
            return View();
        }
	}
}
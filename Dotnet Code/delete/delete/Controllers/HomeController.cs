using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using delete.Models;
using System.Data.Entity;

namespace delete.Controllers
{
    public class HomeController : Controller
    {

        practiceEntities1 db = new practiceEntities1();
        //
        // GET: /Home/
        public ActionResult Index()
        {
           var data =db.employeeDatas.ToList();
            return View(data);
        }

        public ActionResult Delete(int id)
        {
            var row = db.employeeDatas.Where( model => model.emp_id==id).FirstOrDefault();
            db.Entry(row).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        //[HttpPost]
        //public ActionResult Delete(employeeData e)
        //{
        //    db.Entry(e).State = EntityState.Deleted;
        //   var a= db.SaveChanges();
        //    if (a > 0)
        //    {
        //        ViewBag.msgde = "data deleted";
        //    }
        //    else
        //    {
        //        ViewBag.msgde = "data not deleted";
        //    }
        //    return View();
        //}
	}
}
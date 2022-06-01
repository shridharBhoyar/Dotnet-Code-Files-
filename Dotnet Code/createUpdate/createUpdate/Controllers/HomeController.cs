using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using createUpdate.Models;
using System.Data.Entity;

namespace createUpdate.Controllers
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

        public ActionResult Create()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult Create(studentData s)
        {
            db.studentDatas.Add(s);
           var a= db.SaveChanges();
            if(a>0)
            {
                ViewBag.msg = "data inserted";
            }
            else
            {
                ViewBag.msg = "data not inserted";
            }
            return View();

            
        }

        public ActionResult Edit(int id)
        {
            var row = db.studentDatas.Where(model => model.id == id).FirstOrDefault();
          
            return View(row);
        }

        [HttpPost]
        public ActionResult Edit(studentData s)
        {
            db.Entry(s).State = EntityState.Modified;
            var a = db.SaveChanges();
            if (a > 0)
            {
                ViewBag.msgup = "data updated";
            }
            else
            {
                ViewBag.msgup = "data not updated";
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            var row=db.studentDatas.Where(model => model.id == id).FirstOrDefault();
            return View(row);
        }

        [HttpPost]
         public ActionResult Delete(studentData s)
        {
            db.Entry(s).State=EntityState.Deleted;
            var a= db.SaveChanges();
             if (a > 0)
            {
                ViewBag.msgde = "data deleted";
            }
            else
            {
                ViewBag.msgde = "data not deleted";
            }
            return View();
        }


        public ActionResult Details(int id)
        {
            var row=db.studentDatas.Where(model=>model.id==id).FirstOrDefault();

            return View(row);
        }
	 
	}
}
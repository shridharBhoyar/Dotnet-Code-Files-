using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using update.Models;
using System.Data.Entity;

namespace update.Controllers
{
    public class HomeController : Controller
    {
        projectEntities db = new projectEntities();
        // GET: /Home/


        public ActionResult studentlist()
        {
            var data = db.students.ToList();
            return View(data);
        }



        public ActionResult Edit(int id)
        {
          var row=db.students.Where(a => a.id == id).FirstOrDefault();
            return View(row);
        }


        [HttpPost]
        public ActionResult Edit(int id , student s)
        {
            var std = db.students.FirstOrDefault(a=>a.id==id);


            std.name = s.name;
            std.age = std.age - s.age;
            db.SaveChanges();

           

           // db.Entry(s).State = EntityState.Modified;
          //db.SaveChanges();
            return View();
        }



	}
}
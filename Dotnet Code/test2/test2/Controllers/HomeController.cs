using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test2.Models;
using test2.DTO;

namespace test2.Controllers
{
    public class HomeController : Controller
    {
        practiceEntities db = new practiceEntities();
        //
        // GET: /Home/
        public ActionResult Index()
        {
            var studanttt = new studentData();
            var employeee = new employeeData();

            var mul = new multiclass()
            {
                std=studanttt,
                emp=employeee
            };
            return View(mul);
        }





        [HttpPost]
        public ActionResult Index( multiclass m)
        {
       

            var studanttt = new studentData()
            {
              
                std_nam=m.std.std_nam,
                std_last_name= m.std.std_last_name,
                std_age=m.std.std_age,
              
            };



            var employeee = new employeeData()
            {
             
               emp_name=m.emp.emp_name,
               emp_last_name=m.emp.emp_last_name,
               emp_age=m.emp.emp_age

            };
           


            db.studentDatas.Add(studanttt);
            db.employeeDatas.Add(employeee);
            db.SaveChanges();


            //s.id = m.std.id;
            //s.std_nam = m.std.std_nam;
            //s.std_last_name = m.std.std_last_name;
            //s.std_age = m.std.std_age;
            //db.SaveChanges();
          
            return View();
        }
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Models;
using test.DTO;

namespace test.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            var employeee = new employee()
            {
                emp_id=1,
                emp_name="shri",
                emp_age=22
                 
            };

            var stdanttt = new student()
            {
                std_id=1,
                std_name="tushar",           
                std_age=11
            };


            var mul = new multiclass()
            {
                emp=employeee,
                std=stdanttt
            };
            return View(mul);
        }
	}
}
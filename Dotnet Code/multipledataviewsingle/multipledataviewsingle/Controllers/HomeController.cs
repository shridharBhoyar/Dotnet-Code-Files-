using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using multipledataviewsingle.Models;

namespace multipledataviewsingle.Controllers
{
    public class HomeController : Controller
    {

        practiceEntities db = new practiceEntities();
        //
        // GET: /Home/
        public ActionResult Index()
        {
            
            List<studentData> std = db.studentDatas.ToList();
            List<employeeData> emp = db.employeeDatas.ToList();

            var data = from a in std
                       join e in emp on a.id equals e.emp_id into table1
                       from e in table1.DefaultIfEmpty()
                       select new multipleclass { studentdataa = a, employeedataa = e };
            return View(data);
        }

        [HttpPost]
        public ActionResult Index(multipleclass s)
        {
            db.studentDatas.Add(s.studentdataa);
            return View();
        }
	}
}
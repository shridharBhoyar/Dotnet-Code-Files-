using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testmvc.Models;

namespace testmvc.Controllers
{
    public class abcController : Controller
    {

        practiceEntities db = new practiceEntities();
        //
        // GET: /abc/
        public ActionResult Create()
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
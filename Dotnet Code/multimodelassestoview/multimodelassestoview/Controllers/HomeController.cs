using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using multimodelassestoview.Models;
using multimodelassestoview.viewmodel;

namespace multimodelassestoview.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            practiceEntities obj = new practiceEntities();
            var mymodel=new multipledata();
            mymodel.studentdataa = obj.studentDatas.ToList();
            mymodel.employeedataa = obj.employeeDatas.ToList();


            return View(mymodel);
        }
	}
}
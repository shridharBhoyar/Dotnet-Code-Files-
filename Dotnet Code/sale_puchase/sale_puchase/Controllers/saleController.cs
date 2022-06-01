using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sale_puchase.Models;

namespace sale_puchase.Controllers
{
    public class saleController : Controller
    {
        mvc_projectEntities db = new mvc_projectEntities();
        // GET: /sale/
        [HttpGet]
        public ActionResult seleproduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult seleproduct(sale1 s)
        {
            db.sale1.Add(s);
            db.SaveChanges();
            return RedirectToAction("displaystock", "stock");
        }


	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sale_puchase.Models;

namespace sale_puchase.Controllers
{
    public class purchaseController : Controller
    {

        mvc_projectEntities db = new mvc_projectEntities();
        //
        // GET: /purchase/
        [HttpGet]
        public ActionResult createproduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult createproduct(purchase p)
        {
            db.purchases.Add(p);
            db.SaveChanges();

            return RedirectToAction("displaystock", "stock");
        }
	}
}
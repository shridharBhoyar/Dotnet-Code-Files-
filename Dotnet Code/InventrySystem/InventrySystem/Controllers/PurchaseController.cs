using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventrySystem.Controllers
{
    public class PurchaseController : Controller
    {
        //
        // GET: /Purchase/
        public ActionResult PurchaseInventry()
        {
            return View();
        }
	}
}
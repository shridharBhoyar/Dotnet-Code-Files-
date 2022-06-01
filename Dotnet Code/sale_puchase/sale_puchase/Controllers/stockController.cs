using sale_puchase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sale_puchase.Controllers
{
    public class stockController : Controller
    {
        //
        // GET: /stock/

        mvc_projectEntities db = new mvc_projectEntities();

        [HttpGet]
        public ActionResult displaystock()
        {
            var data=db.stocks.ToList();
            return View(data);
        }

       
	}
}
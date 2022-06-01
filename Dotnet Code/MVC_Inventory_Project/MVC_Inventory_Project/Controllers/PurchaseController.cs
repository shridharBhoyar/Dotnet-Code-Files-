using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Inventory_Project.Models;
using System.Data.Entity;

namespace MVC_Inventory_Project.Controllers
{
    public class PurchaseController : Controller
    {


        projectEntities1 db = new projectEntities1();


        // GET: /Purchase/
        public ActionResult PurchaseInventory()
        {
            var data = db.Purchases.ToList();
            return View(data);

            
        }


        

        public ActionResult StockInventory()
        {
            var data=db.Stocks.ToList();
            return View(data);
        }



       
       


           
	}
}
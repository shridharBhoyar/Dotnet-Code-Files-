using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Inventory_Full_Project.Models;
using MVC_Inventory_Full_Project.DTO;
using System.Data.Entity;

namespace MVC_Inventory_Full_Project.Controllers
{
    public class StockController : Controller
    {
        projectEntities db = new projectEntities();
        // GET: /Stock/
        public ActionResult StockList()
        {
           var data= db.Stocks.ToList();
            return View(data);
        }


        //delete stock record
        public ActionResult Delete(int id)
        {
            var row = db.Stocks.Where(model => model.Produc_id == id).FirstOrDefault();
            db.Entry(row).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("StockList");
        }
	}
}
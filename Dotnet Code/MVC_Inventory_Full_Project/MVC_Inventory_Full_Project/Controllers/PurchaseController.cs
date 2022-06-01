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
    public class PurchaseController : Controller
    {

        projectEntities db = new projectEntities();

        // GET: /Purchase/
        public ActionResult PurchaseInventory()
        {
            return View();
        }


        [HttpPost]
        public ActionResult PurchaseInventory(Purchase s)
        {
            db.Purchases.Add(s);
            Stock sk = new Stock()
            {
                Product_Name = s.Product_Name,
                Produc_Quantity = s.Produc_Quantity,
                Produc_Price = s.Produc_Price,
                Produc_Date = s.Produc_Date
            };


            db.Stocks.Add(sk);
            db.SaveChanges();

            return View();
        }


        //list of product
        public ActionResult PurchaseList()
        {
            var data=db.Purchases.ToList();
            return View(data);
        }


        //delete purchase data

        public ActionResult Delete(int id)
        {
            var row = db.Purchases.Where(model => model.Produc_id == id).FirstOrDefault();
            db.Entry(row).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("PurchaseList");
        }
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Inventory_Project.Models;



namespace MVC_Inventory_Project.Controllers
{
    public class SaleController : Controller
    {
        projectEntities1 db = new projectEntities1();

       


        // GET: /Sale/
        public ActionResult saleInventory()
        {

            var per = perurchesedata();
            var sld = saledata();
            var std = stockdata();

            multiclass mul = new multiclass();
            mul.permul = per;
            mul.spdmul = sld;
            mul.stmul = std;
    
         
            return View(mul);
            
        }


        public List<Purchase> perurchesedata()
        {
            return db.Purchases.ToList();
        }

        public List<saleProduct> saledata()
        {
            return db.saleProducts.ToList();
        }

        public List<Stock> stockdata()
        {
            return db.Stocks.ToList();
        }


        // Select Process---------------------------------------------------------
        
        public ActionResult Select(int id)
        {
            var row = db.Purchases.Where(model => model.Produc_id ==id).FirstOrDefault();
        
            return View(row);

        }



        [HttpPost]
        public ActionResult Select(int Produc_id, Purchase p)
        {
            var row = db.Purchases.Where(a => a.Produc_id == Produc_id).FirstOrDefault();

            row.Product_Name = p.Product_Name;
            row.Produc_Quantity = row.Produc_Quantity - p.Produc_Quantity;
            row.Produc_Price = p.Produc_Price;
            row.Produc_Date = p.Produc_Date;

         
           
            db.SaveChanges();
            return RedirectToAction("saleInventory");
        }



	}
}
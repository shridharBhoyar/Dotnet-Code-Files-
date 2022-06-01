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
    public class SaleController : Controller
    {

        projectEntities db = new projectEntities();

        // GET: /Sale/

        public ActionResult saleInventory()
        {
            return View();
        }


        [HttpPost]
        public ActionResult saleInventory(saleProduct s)
        {
            db.saleProducts.Add(s);
            db.SaveChanges();
            return View();
        }


        //sale List
        public ActionResult SaleList()
        {
            var data= db.saleProducts.ToList();
            return View(data);
        }


        //delete sale data
        public ActionResult Delete(int id)
        {
            var row = db.saleProducts.Where(model => model.SaleProduct_id == id).FirstOrDefault();
            db.Entry(row).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("SaleList");
        }

        //Costumer list
        public ActionResult CustomerList()
        {
            var data = db.saleProducts.ToList();
            return View(data);
        }


	}
}
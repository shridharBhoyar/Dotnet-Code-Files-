//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_Inventory_Project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class saleProduct
    {
        public int SaleProduct_id { get; set; }
        public string Customer_Name { get; set; }
        public string Gender { get; set; }
        public string Customer_Mobile_No { get; set; }
        public string Customer_Address { get; set; }
        public string SaleProduct_Name { get; set; }
        public int SaleProduct_Quantity { get; set; }
        public int SaleProduct_Price { get; set; }
        public Nullable<System.DateTime> SaleProduct_Date { get; set; }
    }
}

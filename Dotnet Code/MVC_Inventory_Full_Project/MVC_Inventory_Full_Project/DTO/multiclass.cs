using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_Inventory_Full_Project.Models;

namespace MVC_Inventory_Full_Project.DTO
{
    public class multiclass
    {
        public Purchase purchases { get; set; }
        public saleProduct sales { get; set; }
        public Stock stocks { get; set; }
    }

}
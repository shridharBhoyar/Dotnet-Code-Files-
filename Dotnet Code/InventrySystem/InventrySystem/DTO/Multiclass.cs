using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InventrySystem.Models;


namespace InventrySystem.DTO
{
    public class Multiclass
    {
        public Purchase prchases { get; set; }
        public Sale sales { get; set; }
    }
}
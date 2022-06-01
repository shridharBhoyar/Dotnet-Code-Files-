using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Codefirstapproch.Models
{
    public class stdcontex : DbContext
    {
        public DbSet<stuent> stuents{get;set;}
        
    }
}
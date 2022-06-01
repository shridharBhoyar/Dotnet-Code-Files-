using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Entityframwork.Model
{
    class DatabaseContex1 : DbContext
    {
        public DbSet<Employee> Emplployees { get; set; }
    }
}

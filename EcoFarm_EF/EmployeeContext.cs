using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoFarm_EF
{
    class EmployeeContext : DbContext
    {
        public EmployeeContext():base("DBConnection")
        {

        }

        public DbSet<Employees> Employees { get; set; }
    }
}

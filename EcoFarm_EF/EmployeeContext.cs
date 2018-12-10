using EcoFarm_EF.Migrations;
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
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<EmployeeContext, Configuration>());
        }

        public DbSet<Employees> Employees { get; set; }
        public DbSet<Positions> Positions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

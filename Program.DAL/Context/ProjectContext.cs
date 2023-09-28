using Microsoft.EntityFrameworkCore;
using Program.DAL.Mapping;
using Program.DAL.NewFolder;
using Program.DAL.SeedData;
using Program.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.DAL.Context
{
    public class ProjectContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<WashingProcess> WashingProcesses { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseLazyLoadingProxies();
                optionsBuilder.UseSqlServer(@"Server = DESKTOP-9OHK71U; Database = CarWashDB; Trusted_Connection = True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new CustomerMapping().Configure(modelBuilder.Entity<Customer>());

            new EmployeeMapping().Configure(modelBuilder.Entity<Employee>());

            new MaterialMapping().Configure(modelBuilder.Entity<Material>());

            new MaterialWashingProcessMapping().Configure(modelBuilder.Entity<MaterialWashingProcess>());

            new SupplierMapping().Configure(modelBuilder.Entity<Supplier>());

            new VehicleMapping().Configure(modelBuilder.Entity<Vehicle>());

            new WashingProcessMapping().Configure(modelBuilder.Entity<WashingProcess>());


        }
    }
}

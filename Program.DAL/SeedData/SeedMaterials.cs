using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Program.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.DAL.SeedData
{
    public class SeedMaterials : IEntityTypeConfiguration<Material>
    {
        public void Configure(EntityTypeBuilder<Material> builder)
        {
            builder.HasData
                (
                    new Material { ID = 1, SupplierID = 1, MaterialName = "Car wash brush", MaterialPrice = 50, Stock = 200 },
                    new Material { ID = 2, SupplierID = 3, MaterialName = "High-pressure washer", MaterialPrice = 250, Stock = 8 },
                    new Material { ID = 3, SupplierID = 2, MaterialName = "Foam cannon", MaterialPrice = 35, Stock = 200 },
                    new Material { ID = 4, SupplierID = 2, MaterialName = "Buckets", MaterialPrice = 21, Stock = 80 },
                    new Material { ID = 5, SupplierID = 5, MaterialName = "Water hoses", MaterialPrice = 8, Stock = 25 },
                    new Material { ID = 6, SupplierID = 1, MaterialName = "Upholstery cleaners", MaterialPrice = 15, Stock = 55 },
                    new Material { ID = 7, SupplierID = 4, MaterialName = "Wheel and tire brushes", MaterialPrice = 15, Stock = 150 },
                    new Material { ID = 8, SupplierID = 3, MaterialName = "Vacuum cleaners", MaterialPrice = 5, Stock = 200 },
                    new Material { ID = 9, SupplierID = 4, MaterialName = "Glass cleaner", MaterialPrice = 6, Stock = 177 },
                    new Material { ID = 10, SupplierID = 2, MaterialName = "Cleaning towels", MaterialPrice = 3, Stock = 250 }
                );
        }
    }
}

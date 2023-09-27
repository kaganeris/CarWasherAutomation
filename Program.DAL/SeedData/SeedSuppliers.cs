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
    public class SeedSuppliers : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasData
                (
                    new Supplier { ID = 1, CompanyName = "Breitenberg",ContactName = "Roob",TitleofContact = "Manager" },
                    new Supplier { ID = 2, CompanyName = "Johnston and Sons", ContactName = "Gutkowski",TitleofContact = "Salesman" },
                    new Supplier { ID = 3, CompanyName = "Stroman Group", ContactName = "Merlyn",TitleofContact = "Manager" },
                    new Supplier { ID = 4, CompanyName = "Boehm LLC", ContactName = "Ashley",TitleofContact = "Owner" },
                    new Supplier { ID = 5, CompanyName = "West and Sons", ContactName = "Tom",TitleofContact = "Manager" }
                );
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Program.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.DAL.NewFolder
{
    public class SeedEmployees : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData
                (
                    new Employee { ID = 1, FirstName = "Unknown", LastName = "Unknown", Title = "Unknown", Address = "Unknown" },
                    new Employee { ID = 2, FirstName = "Kağan", LastName = "Eriş", Title = "Washer", Address = "Aydın/Türkiye" },
                    new Employee { ID = 3, FirstName = "Mehmet Mücahid", LastName = "Bilge", Title = "Washer", Address = "Bursa/Türkiye" },
                    new Employee { ID = 4, FirstName = "Ali Furkan", LastName = "Terzi", Title = "Washer", Address = "Ankara/Türkiye" },
                    new Employee { ID = 5, FirstName = "İsmail", LastName = "Tosun", Title = "Washer", Address = "İzmir/Türkiye" },
                    new Employee { ID = 6, FirstName = "Hakan", LastName = "Varyemez", Title = "Washer", Address = "İstanbul/Türkiye" },
                    new Employee { ID = 7, FirstName = "Metin", LastName = "Tekin", Title = "Washer", Address = "Mersin/Türkiye" }
                );
        }
    }
}

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
    public class SeedVehicles : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasData
                (
                    new Vehicle { ID = 1, Brand = "Volkswagen", ProductionDate = new DateTime(2014, 01, 01), Model = "Golf", Plate = "09 ZR 401", BodyType = DATA.Enums.BodyType.Hatchback, CustomerID = 1 },
                    new Vehicle { ID = 2, Brand = "Peugeot", ProductionDate = new DateTime(2019, 01, 01), Model = "3008", Plate = "45 KA 4045", BodyType = DATA.Enums.BodyType.SUV, CustomerID = 1 },
                    new Vehicle { ID = 3, Brand = "Fiat", ProductionDate = new DateTime(2014, 01, 01), Model = "Egea Cross", Plate = "34 RT 2401", BodyType = DATA.Enums.BodyType.SUV, CustomerID = 2 },
                     new Vehicle { ID = 4, Brand = "Opel", ProductionDate = new DateTime(2007, 01, 01), Model = "Corsa", Plate = "35 TR 1985", BodyType = DATA.Enums.BodyType.Hatchback, CustomerID = 3 },
                      new Vehicle { ID = 5, Brand = "Toyota", ProductionDate = new DateTime(2016, 01, 01), Model = "Corolla", Plate = "10 KA 3000", BodyType = DATA.Enums.BodyType.Sedan, CustomerID = 4 },
                      new Vehicle { ID = 6, Brand = "Volvo", ProductionDate = new DateTime(2020, 01, 01), Model = "V90 Cross", Plate = "06 BG 732", BodyType = DATA.Enums.BodyType.StationVagon, CustomerID = 5 },
                       new Vehicle { ID = 7, Brand = "Toyota", ProductionDate = new DateTime(2016, 01, 01), Model = "Hilux", Plate = "07 UJ 121", BodyType = DATA.Enums.BodyType.Pickup, CustomerID = 6 },
                       new Vehicle { ID = 8, Brand = "Ford", ProductionDate = new DateTime(2020, 01, 01), Model = "Tourneo", Plate = "03 ACC 665", BodyType = DATA.Enums.BodyType.Minivan, CustomerID = 7 },
                       new Vehicle { ID = 9, Brand = "Citroen", ProductionDate = new DateTime(2019, 01, 01), Model = "Jumper", Plate = "46 RFV 321", BodyType = DATA.Enums.BodyType.Panelvan, CustomerID = 8 },
                       new Vehicle { ID = 10, Brand = "BMW", ProductionDate = new DateTime(2014, 01, 01), Model = "420D M Sport", Plate = "34 TG 221", BodyType = DATA.Enums.BodyType.Coupe, CustomerID = 9 }
                );
        }
    }
}

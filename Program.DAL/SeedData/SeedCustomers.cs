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
    public class SeedCustomers : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData
                (
                    new Customer
                    {
                        ID = 1,
                        Name = "Mustafa Tez",
                        IsSubscriber = false,
                        SubscribeType = DATA.Enums.SubscribeType.None,
                        Vehicles =
                        {
                            new Vehicle { ID = 1,Brand = "Volkswagen",ProductionDate = Convert.ToDateTime(2014/01/01),Model = "Golf",Plate = "09 ZR 401",BodyType = DATA.Enums.BodyType.Hatchback},
                            new Vehicle { ID = 2,Brand = "Peugeot",ProductionDate = Convert.ToDateTime(2019/01/01),Model = "3008",Plate = "45 KA 4045",BodyType = DATA.Enums.BodyType.SUV}
                        }
                    },
                    new Customer
                    {
                        ID = 2,
                        Name = "Mert Demirci",
                        IsSubscriber = true,
                        SubscribeType = DATA.Enums.SubscribeType.Classic,
                        SubscribeDate = Convert.ToDateTime(2023/08/21),
                        Vehicles =
                        {
                            new Vehicle { ID = 3,Brand = "Fiat",ProductionDate = Convert.ToDateTime(2014/01/01),Model = "Egea Cross",Plate = "34 RT 2401",BodyType = DATA.Enums.BodyType.SUV}
                        }
                    },
                    new Customer
                    {
                        ID = 3,
                        Name = "Levent Adnan",
                        IsSubscriber = true,
                        SubscribeType = DATA.Enums.SubscribeType.Classic,
                        SubscribeDate = Convert.ToDateTime(2023 / 09 / 21),
                        Vehicles =
                        {
                            new Vehicle { ID = 4,Brand = "Opel",ProductionDate = Convert.ToDateTime(2007/01/01),Model = "Corsa",Plate = "35 TR 1985",BodyType = DATA.Enums.BodyType.Hatchback}
                        }
                    },
                    new Customer
                    {
                        ID = 4,
                        Name = "Havva Temel",
                        IsSubscriber = false,
                        SubscribeType = DATA.Enums.SubscribeType.None,
                        Vehicles =
                        {
                            new Vehicle { ID = 5,Brand = "Toyota",ProductionDate = Convert.ToDateTime(2016/01/01),Model = "Corolla",Plate = "10 KA 3000",BodyType = DATA.Enums.BodyType.Sedan}
                        }
                    },
                    new Customer
                    {
                        ID = 5,
                        Name = "İdris Bahadır",
                        IsSubscriber = true,
                        SubscribeType = DATA.Enums.SubscribeType.Premium,
                        SubscribeDate = Convert.ToDateTime(2022 / 09 / 21),
                        Vehicles =
                        {
                            new Vehicle { ID = 6,Brand = "Volvo",ProductionDate = Convert.ToDateTime(2020/01/01),Model = "V90 Cross",Plate = "06 BG 732",BodyType = DATA.Enums.BodyType.StationVagon}
                        }
                    },
                    new Customer
                    {
                        ID = 6,
                        Name = "Okan Şahin",
                        IsSubscriber = true,
                        SubscribeType = DATA.Enums.SubscribeType.Basic,
                        SubscribeDate = Convert.ToDateTime(2023 / 09 / 05),
                        Vehicles =
                        {
                            new Vehicle { ID = 7,Brand = "Toyota",ProductionDate = Convert.ToDateTime(2016/01/01),Model = "Hilux",Plate = "07 UJ 121",BodyType = DATA.Enums.BodyType.Pickup}
                        }
                    },
                    new Customer
                    {
                        ID = 7,
                        Name = "Turgay Mert",
                        IsSubscriber = true,
                        SubscribeType = DATA.Enums.SubscribeType.Basic,
                        SubscribeDate = Convert.ToDateTime(2023 / 09 / 25),
                        Vehicles =
                        {
                            new Vehicle { ID = 8,Brand = "Ford",ProductionDate = Convert.ToDateTime(2020/01/01),Model = "Tourneo",Plate = "03 ACC 665",BodyType = DATA.Enums.BodyType.Minivan}
                        }
                    },
                    new Customer
                    {
                        ID = 8,
                        Name = "Gözde Emrah",
                        IsSubscriber = true,
                        SubscribeType = DATA.Enums.SubscribeType.Premium,
                        SubscribeDate = Convert.ToDateTime(2023 / 09 / 10),
                        Vehicles =
                        {
                            new Vehicle { ID = 9,Brand = "Citroen",ProductionDate = Convert.ToDateTime(2019/01/01),Model = "Jumper",Plate = "46 RFV 321",BodyType = DATA.Enums.BodyType.Panelvan}
                        }
                    },
                    new Customer
                    {
                        ID = 9,
                        Name = "Rıdvan Demir",
                        IsSubscriber = false,
                        SubscribeType = DATA.Enums.SubscribeType.None,
                        Vehicles =
                        {
                            new Vehicle { ID = 10,Brand = "BMW",ProductionDate = Convert.ToDateTime(2014/01/01),Model = "420D M Sport",Plate = "34 TG 221",BodyType = DATA.Enums.BodyType.Coupe}
                        }
                    }
                );
        }
    }
}

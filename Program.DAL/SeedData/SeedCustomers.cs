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
                        SubscribeType = DATA.Enums.SubscribeType.None
                    },
                    new Customer
                    {
                        ID = 2,
                        Name = "Mert Demirci",
                        IsSubscriber = true,
                        SubscribeType = DATA.Enums.SubscribeType.Classic,
                        SubscribeDate = new DateTime(2023,08,21),
                        SubscribeEndingDate = new DateTime(2023,10,21)
                    },
                    new Customer
                    {
                        ID = 3,
                        Name = "Levent Adnan",
                        IsSubscriber = true,
                        SubscribeType = DATA.Enums.SubscribeType.Classic,
                        SubscribeDate = new DateTime(2023 , 09 , 21),
                        SubscribeEndingDate = new DateTime(2023, 10, 3)
                    },
                    new Customer
                    {
                        ID = 4,
                        Name = "Havva Temel",
                        IsSubscriber = false,
                        SubscribeType = DATA.Enums.SubscribeType.None
                    },
                    new Customer
                    {
                        ID = 5,
                        Name = "İdris Bahadır",
                        IsSubscriber = true,
                        SubscribeType = DATA.Enums.SubscribeType.Premium,
                        SubscribeDate = new DateTime(2022 , 09 , 21),
                        SubscribeEndingDate = new DateTime(2023, 10, 6)
                    },
                    new Customer
                    {
                        ID = 6,
                        Name = "Okan Şahin",
                        IsSubscriber = true,
                        SubscribeType = DATA.Enums.SubscribeType.Basic,
                        SubscribeDate = new DateTime(2023 , 09 , 05),
                        SubscribeEndingDate = new DateTime(2023, 11, 21)
                    },
                    new Customer
                    {
                        ID = 7,
                        Name = "Turgay Mert",
                        IsSubscriber = true,
                        SubscribeType = DATA.Enums.SubscribeType.Basic,
                        SubscribeDate = new DateTime(2023, 09, 25),
                        SubscribeEndingDate = new DateTime(2023, 10, 01)
                    },
                    new Customer
                    {
                        ID = 8,
                        Name = "Gözde Emrah",
                        IsSubscriber = true,
                        SubscribeType = DATA.Enums.SubscribeType.Premium,
                        SubscribeDate = new DateTime(2023, 09, 10),
                        SubscribeEndingDate = new DateTime(2023, 12, 7)
                    },
                    new Customer
                    {
                        ID = 9,
                        Name = "Rıdvan Demir",
                        IsSubscriber = false,
                        SubscribeType = DATA.Enums.SubscribeType.None
                    }
                );
        }
    }
}

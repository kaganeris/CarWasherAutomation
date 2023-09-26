using Program.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.DATA.Entities
{
    public class Customer : BaseEntity
    {
        public Customer()
        {
            CreatedDate = DateTime.Now;
            Vehicles = new List<Vehicle>();
        }
        public string Name { get; set; }
        public bool IsSubscriber { get; set; }

        public SubscribeType SubscribeType { get; set; } = SubscribeType.None;
        public DateTime? SubscribeDate { get; set; }
        public DateTime? SubscribeEndingDate { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}

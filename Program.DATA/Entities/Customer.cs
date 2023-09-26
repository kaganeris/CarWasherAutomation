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
        public string Name { get; set; }
        public bool IsSubscriber { get; set; }

        private SubscribeType subscribeType;

        public SubscribeType SubscribeType
        {
            get { return subscribeType; }
            set 
            { 
                
            }
        }
        public DateTime SubscribeDate { get; set; }
        public DateTime SubscribeEndingDate { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}

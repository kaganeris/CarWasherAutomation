using Program.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.DATA.Entities
{
    public class Vehicle : BaseEntity
    {
        //
        public int CustomerID { get; set; }
        public string? Brand { get; set; }
        public DateTime? ProductionDate { get; set; }
        public string? Model { get; set; }
        public BodyType BodyType { get; set; }
        public List<WashingProcess> WashingProcess { get; set; }
        public Customer Customer { get; set; }
    }
}

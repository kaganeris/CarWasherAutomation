using Program.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.DATA.Entities
{
    public class WashingProcess : BaseEntity
    {
        public WashingProcess()
        {
            MaterialWashingProcesses = new List<MaterialWashingProcess>();
        }
        public int VehicleID { get; set; }
        public int EmployeeID { get; set; }
        public bool IsQueue { get; set; }

        private decimal basePrice = 100;

        public decimal WashingPrice { get; set; }
       

        public decimal Discount { get; set; }
        

        public double? VehiclePollution { get; set; }
        public double WaterConsumption { get; set; }
        public ProcessType ProcessType { get; set; }
        public List<MaterialWashingProcess> MaterialWashingProcesses { get; set; }
        public Vehicle Vehicle { get; set; }
        public Employee Employee { get; set; }

    }
}

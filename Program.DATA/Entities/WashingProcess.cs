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
        public int MaterialID { get; set; }
        public bool IsQueue { get; set; }

        private decimal basePrice = 100;

        private decimal washingPrice;

        public decimal WashingPrice
        {
            get { return washingPrice; }
            set
            {
                switch (Vehicle.BodyType)
                {
                    case BodyType.Sedan:
                        washingPrice = basePrice * 1.2M;
                        break;
                    case BodyType.Hatchback:
                        washingPrice = basePrice * 1;
                        break;
                    case BodyType.SUV:
                        washingPrice = basePrice * 1.9M;
                        break;
                    case BodyType.StationVagon:
                        washingPrice = basePrice * 1.8M;
                        break;
                    case BodyType.Pickup:
                        washingPrice = basePrice * 2M;
                        break;
                    case BodyType.Minivan:
                        washingPrice = basePrice * 2.1M;
                        break;
                    case BodyType.Panelvan:
                        washingPrice = basePrice * 2.1M;
                        break;
                    case BodyType.Coupe:
                        washingPrice = basePrice * 1.1M;
                        break;
                    default:
                        break;
                }
                switch (ProcessType)
                {
                    case ProcessType.Interior:
                        washingPrice = washingPrice * 1.2M;
                        break;
                    case ProcessType.Exterior:
                        washingPrice = washingPrice * 1;
                        break;
                    case ProcessType.Full:
                        washingPrice = washingPrice * 1.7M;
                        break;
                    default:
                        break;
                }

                washingPrice = washingPrice * (decimal)(1 - discount);
            }
        }
        private double discount = 1;

        public double Discount
        {
            get { return discount; }
            set
            {
                if (Vehicle.Customer.IsSubscriber == true)
                {
                    if (Vehicle.Customer.SubscribeType == SubscribeType.Basic)
                        discount = 0.1;
                    else if (Vehicle.Customer.SubscribeType == SubscribeType.Classic)
                        discount = 0.25;
                    else if (Vehicle.Customer.SubscribeType == SubscribeType.Premium)
                        discount = 0.4;
                }
            }
        }

        public double VehiclePollution { get; set; }
        public double WaterConsumption { get; set; }
        public ProcessType ProcessType { get; set; }
        public List<MaterialWashingProcess> MaterialWashingProcesses { get; set; }
        public Vehicle Vehicle { get; set; }
        public Employee Employee { get; set; }

    }
}

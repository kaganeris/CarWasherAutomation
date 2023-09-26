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
            Material = new List<Material>();
        }
        public int VehicleID { get; set; }
        public int EmployeeID { get; set; }
        public int MaterialID { get; set; }
        public bool IsQueue { get; set; }

        private decimal basePrice= 100;

        private decimal washingPrice;

        public decimal WashingPrice
        {
            get { return washingPrice; }
            set 
            { 
                if(Vehicle.BodyType == BodyType.Sedan)
                {
                    washingPrice = basePrice * 1.2M;
                }
                else if(Vehicle.BodyType == BodyType.Hatchback)
                {
                    washingPrice = basePrice * 1;
                }
                else if (Vehicle.BodyType == BodyType.SUV)
                {
                    washingPrice = basePrice * 1.9M;
                }
                else if (Vehicle.BodyType == BodyType.StationVagon)
                {
                    washingPrice = basePrice * 1.8M;
                }
                else if (Vehicle.BodyType == BodyType.Pickup)
                {
                    washingPrice = basePrice * 2M;
                }
                else if (Vehicle.BodyType == BodyType.Minivan)
                {
                    washingPrice = basePrice * 2.1M;
                }
                else if (Vehicle.BodyType == BodyType.Panelvan)
                {
                    washingPrice = basePrice * 2.1M;
                }
                else if (Vehicle.BodyType == BodyType.Coupe)
                {
                    washingPrice = basePrice * 1.1M;
                }

                if(ProcessType == ProcessType.Full)
                {
                    washingPrice = washingPrice * 1.7M;
                }
                else if (ProcessType == ProcessType.Exterior)
                {
                    washingPrice = washingPrice * 1;
                }
                else if (ProcessType == ProcessType.Interior)
                {
                    washingPrice = washingPrice * 1.1M;
                }
                washingPrice = washingPrice * (decimal)(1-discount);
            }
        }
        private double discount = 1;

        public double Discount
        {
            get { return discount; }
            set 
            { 
                if(Vehicle.Customer.IsSubscriber == true)
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
        public List<Material> Material { get; set; }
        public Vehicle Vehicle { get; set; }
        public Employee Employee { get; set; }

    }
}

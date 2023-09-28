using Microsoft.EntityFrameworkCore;
using Program.DAL.Context;
using Program.DATA.Entities;
using Program.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Business.Repositories
{
    public class VehicleRepository
    {
        ProjectContext db;
        public VehicleRepository()
        {
            db = new ProjectContext();
        }
        public void Add(Vehicle vehicle)
        {
            db.Vehicles.Add(vehicle);
            db.SaveChanges();
        }
        public void Update(Vehicle vehicle)
        {
            vehicle.ModifiedDate = DateTime.Now;
            db.Vehicles.Update(vehicle);
            db.SaveChanges();
        }
        public void Delete(Vehicle vehicle)
        {
            vehicle.DeletedDate = DateTime.Now;
            vehicle.IsActive = false;
            db.Vehicles.Add(vehicle);
            db.SaveChanges();
        }

        public List<Vehicle> GetVehicles()
        {
            return db.Vehicles
                .Include(x=>x.Customer)
                .Where(x=>x.IsActive==true)
                .ToList();
        }
        public decimal GetPrice(Vehicle vehicle,string ProcessType)
        {
            decimal washingPrice =0, basePrice = 100;
            switch (vehicle.BodyType)
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
                case "Interior":
                    washingPrice = washingPrice * 1.2M;
                    break;
                case "Exterior":
                    washingPrice = washingPrice * 1;
                    break;
                case "Full":
                    washingPrice = washingPrice * 1.7M;
                    break;
                default:
                    break;
            }
            
            washingPrice = washingPrice * (1 - GetDiscount(vehicle.Customer));
            return washingPrice;
        }

        public List<Vehicle> SearchVehicles(List<Vehicle> vehicleList, string text)
        {
            return vehicleList
               .Where(x=> x.Customer.Name.ToLower().Contains(text.ToLower()) || x.Plate.StartsWith(text))
               .ToList();
        }

        public int GetWaterConsumption(WashingProcess wp)
        {
            Vehicle vehicle = db.Vehicles.Where(x=>x.ID==(wp.VehicleID)).FirstOrDefault();
            if (wp.ProcessType == ProcessType.Interior) return 0;
            else
            {
                if (vehicle.BodyType == BodyType.Coupe) return 35;
                else if (vehicle.BodyType == BodyType.Hatchback) return 45;
                else if (vehicle.BodyType == BodyType.Sedan) return 60;
                else if (vehicle.BodyType == BodyType.Minivan) return 75;
                else if (vehicle.BodyType == BodyType.Panelvan) return 85;
                else if (vehicle.BodyType == BodyType.StationVagon) return 65;
            }
            return 0;
        }
        public decimal GetDiscount(Customer customer)
        {
            
            if (customer.IsSubscriber == true)
            {
                if (customer.SubscribeType == SubscribeType.Basic)
                    return 0.1M;
                else if (customer.SubscribeType == SubscribeType.Classic)
                    return 0.25M;
                else if (customer.SubscribeType == SubscribeType.Premium)
                    return 0.4M;
            }
            return 0;
        }
    }
}

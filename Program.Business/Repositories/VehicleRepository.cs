using Program.DAL.Context;
using Program.DATA.Entities;
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
    }
}

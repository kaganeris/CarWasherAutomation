using Microsoft.EntityFrameworkCore;
using Program.DAL.Context;
using Program.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Program.Business.Repositories
{
    public class WashingProcessRepository
    {
        ProjectContext db;
        public WashingProcessRepository()
        {
            db = new ProjectContext();
        }
        public void Add(WashingProcess wp)
        {
            db.WashingProcesses.Add(wp);
            db.SaveChanges();
        }
        public void Update(WashingProcess wp)
        {
            wp.ModifiedDate = DateTime.Now;
            db.WashingProcesses.Update(wp);
            db.SaveChanges();
        }
        public void Delete(WashingProcess wp)
        {
            wp.DeletedDate = DateTime.Now;
            wp.IsActive = false;
            db.WashingProcesses.Add(wp);
            db.SaveChanges();
        }
        public List<WashingProcess> FindInWashingProcesses(Expression<Func<WashingProcess, bool>> where)
        {
            return db.WashingProcesses.Where(where).ToList(); 
        }

        public double WaterConsOfDay(DateTime dateTime)
        {
            var result =
                db.WashingProcesses
                .Where(x => x.IsActive == true && x.CreatedDate.Date == dateTime.Date)
                .GroupBy(x => new { x.CreatedDate.Date })
                .Select(x => new { TotalConsumption = x.Sum(y => y.WaterConsumption) }).FirstOrDefault();

            if (result == null) return 0;
            else return result.TotalConsumption;
        }
        public List<WashingProcess> GetAllQueueVehicles()
        {
            return db.WashingProcesses.Include(x => x.Vehicle.Customer).AsNoTracking().Where(x => x.IsQueue == true).ToList();
        }
    }
}

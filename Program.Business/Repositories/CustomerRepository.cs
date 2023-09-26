using Castle.Core.Resource;
using Microsoft.EntityFrameworkCore;
using Program.DAL.Context;
using Program.DATA.Entities;
using Program.DATA.Enums;

namespace Program.Business.Repositories
{
    public class CustomerRepository
    {
        ProjectContext db;
        public CustomerRepository()
        {
            db = new ProjectContext();
        }
        public void Add(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
        }
        public void Update(Customer customer)
        {
            customer.ModifiedDate = DateTime.Now;
            db.Customers.Update(customer);
            db.SaveChanges();
        }
        public void Delete(Customer customer)
        {
            customer.DeletedDate = DateTime.Now;
            customer.IsActive = false;
            db.Customers.Add(customer);
            db.SaveChanges();
        }
        public SubscribeType CheckSubscribeType(Customer customer)
        {
            int VisitTimesLastSixMonths = 
                db.WashingProcesses
                .Include(x=>x.Vehicle)
                .Where(x=>x.Vehicle.CustomerID==customer.ID && x.CreatedDate>DateTime.Now.AddMonths(-6))
                .Count();

            int VisitTimesLastThreeMonths =
                db.WashingProcesses
                .Include(x => x.Vehicle)
                .Where(x => x.Vehicle.CustomerID == customer.ID && x.CreatedDate > DateTime.Now.AddMonths(-3))
                .Count();
        }
        public int VisitTimes (int month)
        {
            return db.WashingProcesses
            .Include(x => x.Vehicle)
            .Where(x => x.Vehicle.CustomerID == customer.ID && x.CreatedDate > DateTime.Now.AddMonths(-month))
            .Count();
        }

    }
}
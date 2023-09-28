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
        public void CheckSubscribeType(Customer customer)
        {
            if (VisitTimes(6, customer) > 15) customer.SubscribeType = SubscribeType.Premium;
            else if (VisitTimes(3, customer) > 7) customer.SubscribeType = SubscribeType.Classic;
            else if (VisitTimes(1, customer) > 3) customer.SubscribeType = SubscribeType.Basic;
            else customer.SubscribeType = SubscribeType.None;
            if(customer.SubscribeType == SubscribeType.None) customer.IsSubscriber = false;
            else customer.IsSubscriber = true;
        }
        public int VisitTimes(int month, Customer customer)
        {
            return db.WashingProcesses
            .Include(x => x.Vehicle)
            .Where(x => x.Vehicle.CustomerID == customer.ID && x.CreatedDate > DateTime.Now.AddMonths(-month))
            .Count();
        }

    }
}
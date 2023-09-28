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
        public void CheckSubscribeType(Customer customer, out string returnMessage)
        {
            returnMessage = "";
            if (customer.SubscribeEndingDate < DateTime.Now) customer.SubscribeType = SubscribeType.None;
            if (VisitTimes(6, customer) > 15)
            {
                customer.SubscribeType = SubscribeType.Premium;
                customer.SubscribeEndingDate = DateTime.Now.AddMonths(3);
                customer.SubscribeDate = DateTime.Now;
                returnMessage = "Congrats! You have gained Premium Subscription for 3 Months.";
            }
            else if (VisitTimes(3, customer) > 7 && customer.SubscribeType != SubscribeType.Premium)
            {
                customer.SubscribeType = SubscribeType.Classic;
                customer.SubscribeEndingDate = DateTime.Now.AddMonths(2);
                customer.SubscribeDate = DateTime.Now;
                returnMessage = "Congrats! You have gained Classic Subscription for 2 Months.";
            }
            else if (VisitTimes(1, customer) > 3 && customer.SubscribeType != SubscribeType.Premium && customer.SubscribeType != SubscribeType.Classic)
            {
                customer.SubscribeType = SubscribeType.Basic;
                customer.SubscribeEndingDate = DateTime.Now.AddMonths(2);
                customer.SubscribeDate = DateTime.Now;
                returnMessage = "Congrats! You have gained Basic Subscription for 1 Month.";
            }
            else customer.SubscribeType = SubscribeType.None;
            if(customer.SubscribeType == SubscribeType.None) customer.IsSubscriber = false;
            else customer.IsSubscriber = true;
            Update(customer);
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
using Program.DAL.Context;
using Program.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Business.Repositories
{
    public class SupplierRepository
    {
        ProjectContext db;
        public SupplierRepository()
        {
            db = new ProjectContext();
        }
        public void Add(Supplier supplier)
        {
            db.Suppliers.Add(supplier);
            db.SaveChanges();
        }
        public void Update(Supplier supplier)
        {
            supplier.ModifiedDate = DateTime.Now;
            db.Suppliers.Update(supplier);
            db.SaveChanges();
        }
        public void Delete(Supplier supplier)
        {
            supplier.DeletedDate = DateTime.Now;
            supplier.IsActive = false;
            db.Suppliers.Add(supplier);
            db.SaveChanges();
        }
    }
}

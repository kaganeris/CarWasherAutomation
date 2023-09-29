using Microsoft.EntityFrameworkCore;
using Program.DAL.Context;
using Program.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Business.Repositories
{
    public class EmployeeRepository
    {
        ProjectContext db;
        public EmployeeRepository()
        {
            db = new ProjectContext();
        }
        public void Add(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
        }
        public void Update(Employee employee)
        {
            employee.ModifiedDate = DateTime.Now;
            db.Employees.Update(employee);
            db.SaveChanges();
        }
        public void Delete(Employee employee)
        {
            employee.DeletedDate = DateTime.Now;
            employee.IsActive = false;
            db.Employees.Add(employee);
            db.SaveChanges();
        }
        public List<Employee> GetAllEmployees()
        {
            return db.Employees.AsNoTracking().Where(x => x.FirstName != "Unknown").ToList();
        }
    }
}

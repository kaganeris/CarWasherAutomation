using Program.DAL.Context;
using Program.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Business.Repositories
{
    public class MaterialRepository
    {
        ProjectContext db;
        public MaterialRepository()
        {
            db = new ProjectContext();
        }
        public void Add(Material material)
        {
            db.Materials.Add(material);
            db.SaveChanges();
        }
        public void Update(Material material)
        {
            material.ModifiedDate = DateTime.Now;
            db.Materials.Update(material);
            db.SaveChanges();
        }
        public void Delete(Material material)
        {
            material.DeletedDate = DateTime.Now;
            material.IsActive = false;
            db.Materials.Add(material);
            db.SaveChanges();
        }
    }
}

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
        public List<Material> GetAllMaterials()
        {
            return db.Materials.ToList();
        }
        public Material GetMaterialById(int materialId)
        {
            return db.Materials.FirstOrDefault(m => m.ID == materialId);
        }
        public void AddMaterial(Material material)
        {
            db.Materials.Add(material);
            db.SaveChanges();
        }
        public void UpdateMaterialStock(int materialId, int newStock)
        {
            var material = db.Materials.FirstOrDefault(m => m.ID == materialId);

            if (material != null)
            {
                material.Stock = newStock;
                db.SaveChanges();
            }
        }
        public void ReduceStock(int materialID)
        {
            Material material = db.Materials.FirstOrDefault(m => m.ID == materialID);
            material.Stock--;
            material.ModifiedDate = DateTime.Now;
            db.Materials.Update(material);
            db.SaveChanges();
        }
    }
}

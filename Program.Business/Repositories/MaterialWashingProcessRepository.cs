using Program.DAL.Context;
using Program.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Business.Repositories
{
    public class MaterialWashingProcessRepository
    {
        ProjectContext db;
        public MaterialWashingProcessRepository()
        {
            db = new ProjectContext();
        }
        public void Add(MaterialWashingProcess materialWashingProcess)
        {
            db.MaterialWashingProcesses.Add(materialWashingProcess);
            db.SaveChanges();
        }
        public void Update(MaterialWashingProcess materialWashingProcess)
        {
            db.MaterialWashingProcesses.Update(materialWashingProcess);
            db.SaveChanges();
        }
        public void Delete(MaterialWashingProcess materialWashingProcess)
        {
            db.MaterialWashingProcesses.Add(materialWashingProcess);
            db.SaveChanges();
        }
    }
}

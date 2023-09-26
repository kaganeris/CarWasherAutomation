using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.DATA.Entities
{
    public class Material : BaseEntity
    {
        public Material()
        {
            MaterialWashingProcesses = new List<MaterialWashingProcess>();
        }
        public int SupplierID { get; set; }
        public string MaterialName { get; set; }
        public decimal MaterialPrice { get; set; }
        public int Stock { get; set; }
        public List<MaterialWashingProcess> MaterialWashingProcesses { get; set; }
        public Supplier Supplier { get; set; }
    }
}

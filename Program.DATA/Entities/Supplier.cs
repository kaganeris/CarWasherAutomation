using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.DATA.Entities
{
    public class Supplier : BaseEntity
    {
        public Supplier()
        {
            Materials = new List<Material>();
        }
        public string ContactName { get; set; }
        public string CompanyName { get; set; }
        public string? TitleofContact { get; set; }

        public List<Material> Materials { get; set; }
    }
}

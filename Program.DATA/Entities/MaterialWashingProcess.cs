using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.DATA.Entities
{
    public class MaterialWashingProcess
    {
        public int ID { get; set; }
        public int MaterialID { get; set; }
        public int WashingProcessID { get; set; }

        public Material Material { get; set; }
        public WashingProcess WashingProcess { get; set; }
    }
}

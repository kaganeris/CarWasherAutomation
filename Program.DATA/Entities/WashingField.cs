using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.DATA.Entities
{
    public class WashingField : BaseEntity
    {
        public string Name { get; set; }
        public WashingProcess CurrentWashingProcess { get; set; }

    }
}

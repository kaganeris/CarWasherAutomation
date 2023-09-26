using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Program.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.DAL.Mapping
{
    public class MaterialWashingProcessMapping : IEntityTypeConfiguration<MaterialWashingProcess>
    {
        public void Configure(EntityTypeBuilder<MaterialWashingProcess> builder)
        {
            builder.HasKey(x => x.ID);
        }
    }
}

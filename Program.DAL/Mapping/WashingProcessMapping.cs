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
    public class WashingProcessMapping : IEntityTypeConfiguration<WashingProcess>
    {
        public void Configure(EntityTypeBuilder<WashingProcess> builder)
        {
            builder.HasKey(x => x.ID);

            builder.HasMany(x => x.MaterialWashingProcesses).WithOne(x => x.WashingProcess).HasForeignKey(x => x.WashingProcessID);


        }
    }
}

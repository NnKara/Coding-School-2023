using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Configuration
{
    public class PetReportConfig : IEntityTypeConfiguration<Model.PetReport>
    {
        public void Configure(EntityTypeBuilder<PetReport> builder)
        {

            builder.ToTable("PetReport");
            builder.HasKey(petreport => petreport.PetReportID);
            builder.Property(petreport => petreport.PetReportID).ValueGeneratedOnAdd();
        }
    }
}

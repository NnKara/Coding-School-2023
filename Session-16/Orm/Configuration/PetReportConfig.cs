using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Configuration {
    public class PetReportConfig : IEntityTypeConfiguration<PetReport> {
        public void Configure(EntityTypeBuilder<PetReport> builder) {
            builder.ToTable("PetReport");
            builder.HasKey(petReport => petReport.PetReportID);
        }
    }
}

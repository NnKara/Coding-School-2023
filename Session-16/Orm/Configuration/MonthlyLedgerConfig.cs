using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Configuration {
    public class MonthlyLedgerConfig : IEntityTypeConfiguration<MonthlyLedger> {
        public void Configure(EntityTypeBuilder<MonthlyLedger> builder) {

            builder.ToTable("MonthlyLedger");
            builder.HasKey(monthlyLedger => monthlyLedger.MonthlyLedgerID);
            builder.Property(monthlyLdeger => monthlyLdeger.Income).HasPrecision(10, 2);
            builder.Property(monthlyLdeger => monthlyLdeger.Expenses).HasPrecision(10, 2);
            builder.Property(monthlyLdeger => monthlyLdeger.Total).HasPrecision(10, 2);
        }
    }
}

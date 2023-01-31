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
    public class MonthlyLedgerConfig : IEntityTypeConfiguration<MonthlyLedger>
    {
        public void Configure(EntityTypeBuilder<MonthlyLedger> builder)
        {
            builder.ToTable("MonthlyLedger");
            builder.HasKey(monthlyledger => monthlyledger.MonthlyLedgerID);
            builder.Property(monthlyledger => monthlyledger.MonthlyLedgerID).ValueGeneratedOnAdd();           
            builder.Property(monthlyledger => monthlyledger.Income).HasPrecision(10,5);           
            builder.Property(monthlyledger => monthlyledger.Expenses).HasPrecision(10,5);           
            builder.Property(monthlyledger => monthlyledger.Total).HasPrecision(10,5);           
        }
    }
}

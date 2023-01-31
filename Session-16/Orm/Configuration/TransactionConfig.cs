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
    public class TransactionConfig : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transaction");
            builder.HasKey(transaction => transaction.TransactionID);
            builder.Property(transaction => transaction.PetFoodPrice).HasPrecision(10, 5);
            builder.Property(transaction => transaction.TotalPrice).HasPrecision(10, 5);
            builder.Property(transaction => transaction.PetPrice).HasPrecision(10, 5);
            builder.Property(transaction => transaction.TransactionDate).HasMaxLength(20);


        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Configuration
{
    public class PetFoodConfig : IEntityTypeConfiguration<PetFood>
    {
        public void Configure(EntityTypeBuilder<PetFood> builder)
        {
            builder.ToTable("PetFood");
            builder.HasKey(petfood => petfood.PetFoodID);
            builder.Property(petfood => petfood.Cost).HasPrecision(10, 5);
            builder.Property(petfood => petfood.Price).HasPrecision(10, 5);

            builder.HasOne(petfood => petfood.Transaction)
                .WithOne(transaction => transaction.PetFood)
                .HasForeignKey<PetFood>(petfood => petfood.TransactionID).OnDelete(DeleteBehavior.ClientSetNull); 
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;
using System;
using System.Linq;

namespace Orm.Configuration
{
    public class PetConfig : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.ToTable("Pet");
            builder.HasKey(pet => pet.PetID);
            builder.Property(pet => pet.Breed).HasMaxLength(15);
            builder.Property(pet => pet.Price).HasPrecision(10, 5);
            builder.Property(pet => pet.Cost).HasPrecision(10, 5);
            builder.HasOne(pet => pet.Transaction)
                .WithOne(transaction => transaction.Pet)
                .HasForeignKey<Pet>(pet => pet.TransactionID).OnDelete(DeleteBehavior.ClientSetNull);
    
        }
    }
}

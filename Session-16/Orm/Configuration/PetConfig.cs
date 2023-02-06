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
            builder.Property(pet => pet.Breed).HasMaxLength(50);
            builder.Property(pet => pet.Price).HasPrecision(10, 2);
            builder.Property(pet => pet.Cost).HasPrecision(10, 2);


    
        }
    }
}

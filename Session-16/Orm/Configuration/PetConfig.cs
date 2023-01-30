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
            builder.Property(pet=>pet.PetID).ValueGeneratedOnAdd();
            builder.Property(pet => pet.Breed).HasMaxLength(15);
        }
    }
}

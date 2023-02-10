﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using PetShop.Model;

namespace PetShop.EF.Configurations
{
    public class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            // Table Name
            builder.ToTable("Pets");

            // Primary Key
            builder.HasKey(t => t.PetID);
            builder.Property(t => t.PetID).ValueGeneratedOnAdd();

            // Properties
            builder.Property(t => t.Breed).HasMaxLength(50).IsRequired();
            builder.Property(t => t.AnimalType).IsRequired();
            builder.Property(t => t.PetStatus).IsRequired();
            builder.Property(t => t.Price).HasPrecision(10, 2).IsRequired();
            builder.Property(t => t.Cost).HasPrecision(10, 2).IsRequired();

            // Relations
        }
    }
}

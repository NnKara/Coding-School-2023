using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Configurations {
    public class ItemConfiguration:IEntityTypeConfiguration<Item> {
        public void Configure(EntityTypeBuilder<Item> builder) {


            //Table Name
            builder.ToTable("Items");

            //PrimaryKey

            builder.HasKey(item => item.ItemID);
            builder.Property(item => item.ItemID).ValueGeneratedOnAdd();

            //Properties
            builder.Property(item => item.Code).HasMaxLength(50).IsRequired();
            builder.HasIndex(item => item.Code).IsUnique();
            builder.Property(item => item.Description).HasMaxLength(50).IsRequired();
            builder.Property(item => item.ItemType).IsRequired();
            builder.Property(item => item.Cost).HasPrecision(10, 2).IsRequired();
            builder.Property(item => item.Price).HasPrecision(10, 2).IsRequired();


        }
    }
}
    


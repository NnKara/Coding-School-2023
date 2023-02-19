using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Configurations {
    public class TransactionLineConfiguration:IEntityTypeConfiguration<TransactionLine> {
        public void Configure(EntityTypeBuilder<TransactionLine> builder) {


            //Table Name
            builder.ToTable("TransactionLines");


            //Primary Key
            builder.HasKey(trasLine => trasLine.TransactionLineID);
            builder.Property(trasLine => trasLine.TransactionLineID).ValueGeneratedOnAdd();


            //Propertys
            builder.Property(trasLine => trasLine.Quantity).IsRequired();
            builder.Property(trasLine => trasLine.ItemPrice).HasPrecision(10, 2).IsRequired();
            builder.Property(trasLine => trasLine.NetValue).HasPrecision(10, 2).IsRequired();
            builder.Property(trasLine => trasLine.DiscountPercent).HasPrecision(10, 2).IsRequired();
            builder.Property(trasLine => trasLine.DiscountValue).HasPrecision(10, 2).IsRequired();
            builder.Property(trasLine => trasLine.TotalValue).HasPrecision(10, 2).IsRequired();

            //Relations

            builder.HasOne(trasLine => trasLine.Transaction)
                   .WithMany(trasLine => trasLine.TransactionLines)
                   .HasForeignKey(trasLine => trasLine.TransactionID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.Item)
                    .WithMany(t => t.TransactionLines)
                    .HasForeignKey(t => t.ItemID)
                    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

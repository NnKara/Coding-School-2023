using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Configurations {
    public class TransactionConfiguration:IEntityTypeConfiguration<Transaction> {


        public void Configure(EntityTypeBuilder<Transaction> builder) {


            //Table Name
            builder.ToTable("Transactions");

            //Primary Key
            builder.HasKey(tras => tras.TransactionID);
            builder.Property(tras => tras.TransactionID).ValueGeneratedOnAdd();

            //Properties
            builder.Property(tras => tras.Date).IsRequired();
            builder.Property(tras => tras.PaymentMethod).IsRequired();
            builder.Property(tras => tras.TotalValue).HasPrecision(10, 2).IsRequired();


            //Relations
            builder.HasOne(tras => tras.Customer)
                .WithMany(tras => tras.Transactions)
                .HasForeignKey(tras => tras.TransactionID)
                .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne(tras => tras.Employee)
                .WithMany(tras => tras.Transactions)
                .HasForeignKey(tras => tras.TransactionID)
                .OnDelete(DeleteBehavior.Restrict);
            
            
            

        }
    }
}

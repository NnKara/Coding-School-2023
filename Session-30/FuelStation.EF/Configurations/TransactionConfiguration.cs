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
            builder.HasOne(t => t.Customer)
                .WithMany(t => t.Transactions)
                .HasForeignKey(t => t.CustomerID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.Employee)
                .WithMany(t => t.Transactions)
                .HasForeignKey(t => t.EmployeeID)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}

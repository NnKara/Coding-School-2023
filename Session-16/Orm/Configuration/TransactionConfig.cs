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


            builder.HasOne(transaction => transaction.Customer)
                    .WithMany(customer => customer.Transactions)
                    .HasForeignKey(transaction => transaction.CustomerID);

            builder.HasOne(transaction => transaction.Employee)
                .WithMany(employee => employee.Transactions)
                .HasForeignKey(transaction => transaction.EmployeeID);

            builder.HasOne(transaction => transaction.Pet)
                .WithMany(pet => pet.Transactions)
                .HasForeignKey(transaction => transaction.PetID);

            //builder.HasOne(transaction=>transaction.PetReport)
            //    .WithMany(petReport=>petReport.Transactions)
            //    .HasForeignKey(transaction=>transaction.PetReportID);
            
            //builder.HasOne(transaction=>transaction.MonthlyLedger)
            //    .WithMany(monthlyLedger=>monthlyLedger.Transactions)
            //    .HasForeignKey(transaction=>transaction.MonthlyLedgerID);

        }
    }
}

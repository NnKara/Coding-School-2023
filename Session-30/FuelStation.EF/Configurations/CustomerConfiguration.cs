using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Configurations {
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer> {
        public void Configure(EntityTypeBuilder<Customer> builder) {
            //Table Name
            builder.ToTable("Customers");

            //Primary Key

            builder.HasKey(cust => cust.CustomerID);
            builder.Property(cust => cust.CustomerID).ValueGeneratedOnAdd();

            //Properties
            builder.Property(cust => cust.CustomerName).HasMaxLength(50).IsRequired();
            builder.Property(cust => cust.CustomerSurname).HasMaxLength(100).IsRequired();

            builder.Property(cust => cust.CardNumber).HasMaxLength(50).IsRequired();
            builder.HasIndex(cust => cust.CardNumber).IsUnique();
        }
    }
}

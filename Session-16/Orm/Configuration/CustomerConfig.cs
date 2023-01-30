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
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");
            builder.HasKey(customer => customer.CustomerID);
            builder.Property(customer => customer.CustomerID).ValueGeneratedOnAdd();
            builder.Property(customer => customer.CustomerName).HasMaxLength(15);
            builder.Property(customer=>customer.CustomerSurname).HasMaxLength(15);
            builder.Property(customer=>customer.Phone).HasMaxLength(10);
            builder.Property(customer => customer.TIN).HasMaxLength(9);
        }
    }
}

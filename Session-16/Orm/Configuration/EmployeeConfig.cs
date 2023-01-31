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
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");
            builder.HasKey(employee => employee.EmployeeID);
            builder.Property(employee => employee.EmployeeName).HasMaxLength(10);
            builder.Property(employee => employee.EmployeeSurname).HasMaxLength(10);
            builder.Property(employee => employee.SallaryPerMonth).HasPrecision(10,5);
            builder.HasOne(employee => employee.Transaction)
                .WithOne(transaction => transaction.Employee)
                .HasForeignKey<Employee>(employee => employee.TransactionID).OnDelete(DeleteBehavior.ClientSetNull); 
        }
    }
}

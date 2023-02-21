using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Configurations {
    public class EmployeeConfiguration:IEntityTypeConfiguration<Employee> {
        public void Configure(EntityTypeBuilder<Employee> builder) {


            //Table Name
            builder.ToTable("Employees");

            //Primary Key
            builder.HasKey(emp => emp.EmployeeID);
            builder.Property(emp => emp.EmployeeID).ValueGeneratedOnAdd();

            //Properties
            builder.Property(emp => emp.EmployeeName).HasMaxLength(50).IsRequired();
            builder.Property(emp => emp.EmployeeSurname).HasMaxLength(100).IsRequired();
            builder.Property(emp => emp.SalaryPerMonth).IsRequired();
            builder.Property(emp => emp.EmployeeType).IsRequired();
            builder.Property(emp => emp.HireDateStart).IsRequired();
            builder.Property(emp => emp.HireDateEnd);


        }
    }
}

    

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using PetShop.Model;

namespace PetShop.EF.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            // Table Name
            builder.ToTable("Employees");

            // Primary Key
            builder.HasKey(t => t.EmployeeID);
            builder.Property(t => t.EmployeeID).ValueGeneratedOnAdd();

            // Properties
            builder.Property(t => t.EmployeeName).HasMaxLength(50).IsRequired();
            builder.Property(t => t.EmployeeSurname).HasMaxLength(100).IsRequired();
            builder.Property(t => t.SalaryPerMonth).IsRequired();
            builder.Property(t => t.EmployeeType).IsRequired();

            // Relations
        }
    }
}

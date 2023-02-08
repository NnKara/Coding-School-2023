using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using PetShop.Model;

namespace PetShop.EF.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            // Table Name
            builder.ToTable("Customers");

            // Primary Key
            builder.HasKey(t => t.CustomerID);
            builder.Property(t => t.CustomerID).ValueGeneratedOnAdd();

            // Properties
            builder.Property(t => t.CustomerName).HasMaxLength(50).IsRequired();
            builder.Property(t => t.CustomerSurname).HasMaxLength(100).IsRequired();
            builder.Property(t => t.Phone).HasMaxLength(15).IsRequired();
            builder.Property(t => t.TIN).HasMaxLength(30).IsRequired();

            // Relations

        }
    }
}

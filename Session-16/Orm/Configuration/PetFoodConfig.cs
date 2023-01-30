using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Configuration
{
    public class PetFoodConfig : IEntityTypeConfiguration<PetFood>
    {
        public void Configure(EntityTypeBuilder<PetFood> builder)
        {
            builder.ToTable("PetFood");
            builder.HasKey(petfood => petfood.PetID);
            builder.Property(petfood=>petfood.PetID).ValueGeneratedOnAdd();               
        }
    }
}

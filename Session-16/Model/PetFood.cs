using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PetFood
    {
        public Guid PetFoodID { get; set; }
        public Pet.AnimalType PetFoodType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public Transaction Transaction { get; set; } = null!;
        public Guid TransactionID { get; set; }
        public Guid PetID { get; set; }
        public Pet Pet { get; set; }

        public PetFood()
        {
            PetFoodID= Guid.NewGuid();
        }

    }
}

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
        public AnimalType PetFoodType { get; set; }

        public decimal Price { get; set; }
        public decimal Cost { get; set; }

    }
}

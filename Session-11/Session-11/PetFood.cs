using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11
{
    internal class PetFood:Pet
    {
        public Guid PetFoodID { get; set; } 
        public AnimalTypeEnum AnimalType { get; set; }
        public double PetFoodPrice { get; set; }
        public double PetFoodCost { get; set; }

        public PetFood()
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11
{
    public class PetFood:Pet
    {
        public Guid PetFoodID { get; set; } 
        public AnimalTypeEnum AnimalType { get; set; }

        public double PetFoodPrice { get; set; }
        public double PetFoodCost { get; set; }

            
        public PetFood(Guid petFoodID,AnimalTypeEnum animalType, double petFoodPrice, double petFoodCost) {
            PetFoodID= petFoodID;   
            AnimalType= animalType;
            PetFoodPrice = petFoodPrice;    
            PetFoodCost = petFoodCost;  
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11 {
    public class Stock {
        public double PetFoodQty { get; set; }
        public int PetsNumber { get; set; }
        public Stock() { }
        public Stock(double petFoodQty) {
            PetFoodQty = petFoodQty;
        }
        public Stock(int petsNumber) {
            PetsNumber = petsNumber;
        }
        public Stock(double petFoodQty, int petsNumber) {
            PetFoodQty = petFoodQty;
            PetsNumber = petsNumber;
        }

        public double GetPetFoodStock() {
            return PetFoodQty;
        }

        public double GetPetsNumberStock() {
            return PetsNumber;
        }
    }
}

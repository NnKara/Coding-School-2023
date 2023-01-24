using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11 {
    public class Stock {
        public double PetFoodQty { get; set; }
        public int PetsNumber { get; set; }
        public Stock() {
            PetFoodQty = 30;
            PetsNumber = 15;
        }
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

            return PetsNumber;
        }

        public double AddPetFoodToStock(double petFoodQuantity) {
            PetFoodQty = GetPetFoodStock() + petFoodQuantity;
            return PetFoodQty;
        }
        public double RemovePetFoodFromStock(double petFoodQuantity) {
            PetFoodQty = GetPetFoodStock() - petFoodQuantity;
            return PetFoodQty;
        }

        public int AddPetsToStock(int petNumber) {
            PetsNumber = GetPetsNumberStock() + petNumber;  
            return PetsNumber;  
        }

        public int RemovePetsFromStock(int petNumber) {
            PetsNumber = GetPetsNumberStock() - petNumber;
            return PetsNumber;
        }
    }
}


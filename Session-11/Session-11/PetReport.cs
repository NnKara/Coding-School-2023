using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11 {
    public class PetReport :Pet {
        public int Year { get; set; }
        public int Month { get; set; }
        public AnimalTypeEnum AnimalType { get; set; }
        public double TotalSold { get; set; }

        public PetReport(int year,int month, AnimalTypeEnum animalType, double totalSold) {
            Year = year;
            Month = month;
            AnimalType = animalType;    
            TotalSold = totalSold;            
        }

        public string ShowPetReport () {
            string result = $"Year: {Year} Month: {Month} Animal Type: {AnimalType} Total Sold: {TotalSold}";
            return result; 
        }

        public void CreatePetReport(List<Transaction> transactions, List<Pet> pets) {
            
            foreach(Transaction transcation in transactions) {
                foreach(Pet pet in pets) {
                    switch (pet.AnimalType) {
                        case AnimalTypeEnum.Bird:
                            break;
                        case AnimalTypeEnum.Cat:
                            break;
                        case AnimalTypeEnum.Dog:
                            break;
                        case AnimalTypeEnum.None:
                            break;
                        default:
                            break;
                    }
                }
                
            }
        }


    }

}

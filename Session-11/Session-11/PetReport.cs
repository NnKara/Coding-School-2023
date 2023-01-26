using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11 {
    public class PetReport : Pet {
        public int Year { get; set; }
        public int Month { get; set; }
        public AnimalTypeEnum AnimalType { get; set; }
        public int TotalSold { get; set; }

        public PetReport(int year,int month, AnimalTypeEnum animalType, int totalSold) {
            Year = year;
            Month = month;
            AnimalType = animalType;    
            TotalSold = totalSold;            
        }

        public string ShowPetReport (AnimalTypeEnum animalType, int totalSold) {
            string result = $"Year: {Year} Month: {Month} Animal Type: {animalType} Total Sold: {totalSold}";
            return result; 
        }

        
        public List<string> CreatePetReport(List<Transaction> transactions, List<Pet> pets) {
            int totalSoldBird = 0;
            int totalSoldDog = 0;
            int totalSoldCat = 0;
            foreach (Transaction transaction in transactions) {
                foreach(Pet pet in pets) {
                    switch (pet.AnimalType) {
                        case AnimalTypeEnum.Bird:
                            totalSoldBird++;
                            break;
                        case AnimalTypeEnum.Cat:
                            totalSoldCat++;
                            break;
                        case AnimalTypeEnum.Dog:
                            totalSoldDog++;
                            break;                       
                        default:
                            MessageBox.Show("Invalid Animal Type");
                            break;
                    }
                }                
            }
            List<string> petReport = new List<String>();
            petReport.Add(ShowPetReport(AnimalTypeEnum.Bird, totalSoldBird));
            petReport.Add(ShowPetReport(AnimalTypeEnum.Cat, totalSoldCat)); 
            petReport.Add(ShowPetReport(AnimalTypeEnum.Dog, totalSoldDog));
            return petReport;
        }
    }
}

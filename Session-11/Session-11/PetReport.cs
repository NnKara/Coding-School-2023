using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Session_11.Pet;

namespace Session_11 {
    public class PetReport {
        public DateTime Year { get; set; }
        public DateTime Month { get; set; }
        public AnimalTypeEnum AnimalType { get; set; }
        public double TotalSold { get; set; }

        public PetReport(DateTime year,DateTime month, AnimalTypeEnum animalType, double totalSold) {
            Year = year;
            Month = month;
            AnimalType = animalType;    
            TotalSold = totalSold;            
        }

        public string ShowPetReport () {
            string result = $"Year: {Year} Month: {Month} Animal Type: {AnimalType} Total Sold: {TotalSold}";
            return result; 
        }
    }
}

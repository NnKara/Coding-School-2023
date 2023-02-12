using PetShop.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Model {
    public class PetReport {

        public int Year { get; set; }
        public int Month { get; set; }

        public AnimalType AnimalType { get; set; }
        public decimal TotalSold { get; set; }


    }
}

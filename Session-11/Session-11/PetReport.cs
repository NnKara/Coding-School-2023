﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11 {
    public class PetReport {
        public DateOnly Year { get; set; }
        public DateOnly Month { get; set; }
        public Enum AnimalType { get; set; }
        public double totalSold { get; set; }

        public PetReport() {
                
        }

        public PetReport(DateOnly year,DateOnly month,double totalSolds) {
            year = Year;
            month = Month;
            totalSolds= totalSold;

        }
    }
}
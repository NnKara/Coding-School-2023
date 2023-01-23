﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Session_11 {
    internal class Transaction {
        public Guid TransactionID { get; set; }
        public DateOnly TransactionDate { get; set; }
        public Guid CustomerID { get; set; }
        public Guid EmployeeID { get; set; }
        public Guid PetID { get; set; }
        public double PetPrice { get; set; }
        public Guid PetFoodID { get; set; }
        public double PetFoodQty { get; set; }
        public double PetFoodPrice { get; set; }
        public double TotalPrice { get; set; }

        public Transaction(DateOnly transactionDate, Guid customerID, Guid employeeID, Guid petID, double petPrice, Guid petFoodID, double petFoodQty, double petFoodPrice, double totalPrice) {
            TransactionID = new Guid();
            TransactionDate = transactionDate;
            CustomerID = customerID;
            EmployeeID = employeeID;
            PetID = petID;
            PetPrice = petPrice;
            PetFoodID = petFoodID;
            PetFoodQty = petFoodQty;
            PetFoodPrice = petFoodPrice;
            TotalPrice = totalPrice;
        }
    }

}

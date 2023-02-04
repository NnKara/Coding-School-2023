﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Transaction
    {
        public Guid TransactionID { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal PetPrice { get; set; }
        public int PetFoodQty { get; set; }
        public decimal PetFoodPrice { get; set; }
        public decimal TotalPrice { get; set; }

        //relations
        public Pet Pet { get; set; } = null!;
        public Guid PetID { get; set; }
        public Customer Customer { get; set; } =null!;
        public Guid CustomerID { get; set; }
        public Employee Employee { get; set; } = null!;
        public Guid EmployeeID { get; set; }

        public Transaction() {
            TransactionID = Guid.NewGuid();
            TransactionDate = DateTime.Now;
        }

        public Transaction(Guid transactionID, DateTime transactionDate, decimal petPrice, int petFoodQty, decimal petFoodPrice, decimal totalPrice, Pet pet, Guid petID, Customer customer, Guid customerID, Employee employee, Guid employeeID) {
            TransactionID = transactionID;
            TransactionDate = transactionDate;
            PetPrice = petPrice;
            PetFoodQty = petFoodQty;
            PetFoodPrice = petFoodPrice;
            TotalPrice = totalPrice;
            Pet = pet;
            PetID = petID;
            Customer = customer;
            CustomerID = customerID;
            Employee = employee;
            EmployeeID = employeeID;
        }
        public int SetQty(int quantity) {

            Transaction tras = new Transaction();
               int qty= tras.PetFoodQty=quantity;
                return qty;
            }


        }
    }

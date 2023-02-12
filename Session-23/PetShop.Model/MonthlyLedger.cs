using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Model {
    public class MonthlyLedger {

        public MonthlyLedger() {
            Transactions = new List<Transaction>();
        }

        public MonthlyLedger(int year, int month, decimal income, decimal expenses, decimal total) {
            Year = year;
            Month = month;
            Income = income;
            Expenses = expenses;
            Total = total;
            Transactions = new List<Transaction>();
        }

        public int Year { get; set; }
        public int Month { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Total { get; set; }

        List<Transaction> Transactions { get; set; } 
    }
}







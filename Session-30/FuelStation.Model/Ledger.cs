using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FuelStation.Model {
    public class Ledger {
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Total { get; set; }

        public Ledger(int year, int month, decimal income, decimal expenses, decimal total) {
            Year = year;
            Month = month;
            Income = income;
            Expenses = expenses;
            Total = total;
            Transactions = new List<Transaction>();
        }




        //Relations

        public List<Transaction> Transactions = new();
    }
}

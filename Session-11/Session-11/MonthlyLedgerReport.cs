using DevExpress.Data;
using DevExpress.XtraGantt.Scheduling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11 {
    public class MonthlyLedgerReport {
        public int Year;

        public int Month;
        public MonthlyLedger MonthlyLedger { get; set; }
        public List<Transaction> Transactions { get; set; }
        public Settings Settings { get; set; }
        public MonthlyLedgerReport(List<Transaction> transactions, Settings settings) {
            Year = DateTime.Today.Month;
            Month = DateTime.Today.Year;
            Transactions = transactions;    
            Settings = settings;                
        }

        public void CreateMonthlyLedgerReport(List<Transaction> transactions){          
            int year = DateTime.Today.Year;
            int month = DateTime.Today.Month;
            Settings settings = new Settings(); 
            double income = CalculateIncome(transactions, settings);
            double expenses = CalculateExpenses(transactions, settings);
            
            MonthlyLedger monthlyLedger = new MonthlyLedger(year, month, income, expenses);
            monthlyLedger.ShowMonthlyLedger();


        }

        private double CalculateExpenses(List<Transaction> transactions, Settings settings) {
            
            double sumExpenses = 0;
            for (int i = 0; i < transactions.Count -1; i++) {
                sumExpenses += (transactions[i].PetFoodPrice * transactions[i].PetFoodQty) + transactions[i].PetPrice + settings.Rent + settings.StaffSalary;
                
            }
            return sumExpenses;

        }

        private double CalculateIncome(List<Transaction> transactions, Settings settings) {
            throw new NotImplementedException();
        }
    }
}

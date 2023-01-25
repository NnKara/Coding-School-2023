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
            double income = CalculateIncome(transactions);
            double expenses = CalculateExpenses(transactions);                   
            MonthlyLedger monthlyLedger = new MonthlyLedger(year, month, income, expenses);
            monthlyLedger.ShowMonthlyLedger();


        }           

        private double CalculateExpenses(List<Transaction> transactions) {
            PetFood petFood = new PetFood();
            Settings settings = new Settings();
            Pet pet = new Pet();
            double sumExpenses = 0;
            foreach (Transaction transaction in transactions) {
                sumExpenses += settings.Rent + (transaction.PetFoodQty * petFood.PetFoodCost) + settings.StaffSalary + pet.Cost;
            }
            return sumExpenses;
        }

        private double CalculateIncome(List<Transaction> transactions) {
            PetFood petFood = new PetFood();
            Settings settings = new Settings();
            Pet pet = new Pet();
            double sumIncome = 0;
            foreach (Transaction transaction in transactions) {
                sumIncome += ((transaction.PetFoodQty - 1) * transaction.PetFoodPrice) + pet.Price;
            }
            return sumIncome;
        }

      
    }
}

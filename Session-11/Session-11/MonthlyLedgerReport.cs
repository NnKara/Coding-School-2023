using DevExpress.Data;
using DevExpress.Office.Utils;
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

        public void CreateMonthlyLedgerReportCurrent(List<Transaction> transactions){          
            int year = DateTime.Today.Year;
            int month = DateTime.Today.Month;
            Settings settings = new Settings();             
            List<Transaction> transactionsListByCurrentMonthAndYear = FilterTransactions(transactions, year, month);
            
            //double income = CalculateIncome(transactions);
            //double expenses = CalculateExpenses(transactions);

            double income = CalculateIncome(transactionsListByCurrentMonthAndYear);
            double expenses = CalculateExpenses(transactionsListByCurrentMonthAndYear);
            MonthlyLedger monthlyLedger = new MonthlyLedger(year, month, income, expenses);
            monthlyLedger.ShowMonthlyLedger();
        }

        private List<Transaction> FilterTransactions(List<Transaction> transactions, int year, int month) {
            List<Transaction> filteredTransactions = new List<Transaction>();

            foreach(Transaction transaction in transactions) { 
                if(CheckYear(transaction, year) && CheckMonth(transaction, month)) {
                    filteredTransactions.Add(transaction);  
                }
            }
            return filteredTransactions;    
        }

        private bool CheckMonth(Transaction transaction, int month) {
            if (transaction.TransactionDate.Month == month) {
                return true;
            }
            return false;
        }

        private bool CheckYear(Transaction transaction, int year) {
            if(transaction.TransactionDate.Year== year) {
                return true;
            }
            return false;   
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

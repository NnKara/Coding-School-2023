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

        public MonthlyLedger CreateMonthlyLedgerReportCurrent(List<Transaction> transactions){          
            int year = DateTime.Today.Year;
            int month = DateTime.Today.Month;                         
            List<Transaction> transactionsListByCurrentMonthAndYear = FilterTransactions(transactions, year, month); 
            double income = CalculateIncome(transactionsListByCurrentMonthAndYear);
            double expenses = CalculateExpenses(transactionsListByCurrentMonthAndYear);
            MonthlyLedger monthlyLedger = new MonthlyLedger(year, month, income, expenses);
            string result = monthlyLedger.ShowMonthlyLedger(); // if we show it in simple textbox
            return monthlyLedger;
        }


        public List<MonthlyLedger> CreateWholeYearLedgerReport(List<Transaction> transactions) {
            List<MonthlyLedger> ledgerPerMonth = new List<MonthlyLedger>();
            List<string> ledgerStringPerMonth = new List<string>();  // if we don't show it in a grid

            int currentYear = DateTime.Today.Year;


            for (int month = 1; month <= 12; month++) {
                List<Transaction> transactionsByMonth = FilterTransactions(transactions, currentYear, month);
                double income = CalculateIncome(transactionsByMonth);
                double expenses = CalculateExpenses(transactionsByMonth);
                MonthlyLedger monthlyLedger = new MonthlyLedger(currentYear, month, income, expenses);
                string result = monthlyLedger.ShowMonthlyLedger();
                ledgerStringPerMonth.Add(result);  // if we show it in simple textbox 
                ledgerPerMonth.Add(monthlyLedger);
            }

            return ledgerPerMonth;
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
            Pet pet = new Pet();
            double sumIncome = 0;
            foreach (Transaction transaction in transactions) {
                sumIncome += ((transaction.PetFoodQty - 1) * transaction.PetFoodPrice) + pet.Price;
            }
            return sumIncome;
        }

      
    }
}

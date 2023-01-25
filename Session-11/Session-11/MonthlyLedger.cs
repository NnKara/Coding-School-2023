//using DevExpress.CodeParser;
//using DevExpress.XtraRichEdit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Session_11
{
    public class MonthlyLedger {
        public int Year { get; set; }        
        public int Month { get; set; }
        public double Income { get; set; }
        public double Expenses { get; set; }
        public double Total { get; set; }        

        public MonthlyLedger(int year, int month, double income, double expenses) {
            Year = year;    
            Month = month;  
            Income = income;    
            Expenses = 2000 + expenses;    // at initialization only rent is an expense, so Expenses = rent + expenses
            Total = income - (2000 + expenses);
        }

        public MonthlyLedger(int year, int month, double income, double expenses, int rent) {
            Year = year;
            Month = month;
            Income = income;
            Expenses = rent + expenses;    
            Total = income - (rent + expenses);
        }

        public string ShowMonthlyLedger() {
            string result = $"Year: {Year} Month: {Month} Income: {Income} Expenses: {Expenses} Total Profit: {Total}";
            return result;
        }
    }
}

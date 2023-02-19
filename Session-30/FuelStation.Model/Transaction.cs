using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model {
    public class Transaction {
        public int TransactionID { get; set; }
        public DateTime Date { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        public decimal TotalValue { get; set; }

        public Transaction(DateTime date, PaymentMethod paymentMethod, decimal totalValue) {
            Date = date;
            PaymentMethod = paymentMethod;
            TotalValue = totalValue;
            TransactionLines = new List<TransactionLine>();
        }





        //Relations

        public int EmployeeID { get; set; }
        public Employee Employee { get; set; } = null!;

        public int CustomerID { get; set; }
        public Customer Customer { get; set; } = null!;

        public List<TransactionLine> TransactionLines { get; set; } = new();

        //public List<Item> Items { get; set; } = new();
    }
}

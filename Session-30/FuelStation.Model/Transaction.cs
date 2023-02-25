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


        public Transaction() {
        }

        public Transaction(PaymentMethod paymentMethod, decimal totalValue,DateTime date) {
            PaymentMethod= paymentMethod;
            TotalValue = totalValue;
            Date = date;
        }





        //Relations

        public int EmployeeID { get; set; }
        public Employee Employee { get; set; } = null!;

        public int CustomerID { get; set; }
        public Customer Customer { get; set; } = null!;

        public List<TransactionLine> TransactionLines { get; set; } = new();
    }
}

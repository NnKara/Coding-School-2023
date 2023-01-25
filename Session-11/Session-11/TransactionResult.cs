using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11 {
    public class TransactionResult {
        public DateTime TransactionDate { get; set; }
        public List<Transaction> Transactions { get; set; }
        public Customer TransactionCustomer { get; set; }
        public double TotalPrice { get; set; } 

        public TransactionResult() {
            Transactions = new List<Transaction>();
        }  

        public void SetTotalPrice() {
            TotalPrice = Transactions.Sum( x => x.TotalPrice); 
        }


    }
}

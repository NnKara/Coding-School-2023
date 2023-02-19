using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FuelStation.Model {
    public class Customer {

        public Customer(string customerName,string customerSurname,string cartdNumber) {
            CustomerName= customerName;
            CustomerSurname= customerSurname;
            CardNumber= cartdNumber;
            Transactions= new List<Transaction>();
        }
        public int CustomerID { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerSurname { get; set; }

        public string? CardNumber { get; set; }


        public Customer() {
            Transactions = new List<Transaction>();
        }


        //Relations
        public List<Transaction> Transactions { get; set; }
    }
}

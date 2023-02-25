using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FuelStation.Model {
    public class Customer {

        public Customer(string customerName,string customerSurname) {
            CustomerName= customerName;
            CustomerSurname= customerSurname;
            CardNumber= GenerateCardNumber();
            Transactions= new List<Transaction>();
        }
        public int CustomerID { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerSurname { get; set; }

        [MaxLength(50)]
        public string? CardNumber { get; set; }


        public Customer() {
            Transactions = new List<Transaction>();
        }


        private string GenerateCardNumber() {
            string prefix = "A";
            Guid guid = Guid.NewGuid();
            string cardNumber = prefix + guid.ToString("N").Substring(0, 15);
            return cardNumber;
        }

        public List<Transaction> Transactions { get; set; }
    }
}

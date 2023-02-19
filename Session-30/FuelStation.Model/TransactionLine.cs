using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model {
    public class TransactionLine {
        public int TransactionLineID { get; set; }

        public int Quantity { get; set; }

        public decimal ItemPrice { get; set; }

        public decimal NetValue { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal TotalValue { get; set; }

        public TransactionLine( int quantity, decimal itemPrice, decimal netValue, decimal discountPercent, decimal discountValue, decimal totalValue) {
            Quantity = quantity;
            ItemPrice = itemPrice;
            NetValue = netValue;
            DiscountPercent = discountPercent;
            DiscountValue = discountValue;
            TotalValue = totalValue;
        }



        //Relations
        public int TransactionID { get; set; }
        public Transaction Transaction { get; set; } = null!;

        public int ItemID { get; set; }

        public Item Item { get; set; } = null!;
    }
}

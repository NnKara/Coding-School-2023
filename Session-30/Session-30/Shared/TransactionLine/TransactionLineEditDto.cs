using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_30.Shared
{
    public class TransactionLineEditDto {
        public int TransactionLineID { get; set; }

        public int Quantity { get; set; }

        public decimal ItemPrice { get; set; }

        public decimal NetValue { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal TotalValue { get; set; }



        //Relations
        public int TransactionID { get; set; }
        public Transaction Transaction { get; set; } = null!;

        public int ItemID { get; set; }

        public Item Item { get; set; } = null!;
    }
}

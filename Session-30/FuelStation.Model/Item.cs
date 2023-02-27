using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FuelStation.Model {
    public class Item {
        public int ItemID { get; set; }

        public string? Code { get; set; }

        //[Required]
        public string? Description { get; set; }

        //[Required]
        public ItemType ItemType { get; set; }
        //[Required]
        //[DataType(DataType.Currency)]
        public decimal Cost { get; set; }
        //[Required]
        //[DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public Item() {
            TransactionLines = new List<TransactionLine>();
        }

        public Item(string? code, string? description, ItemType itemType, decimal cost, decimal price) {
            Code = code;
            Description = description;
            ItemType = itemType;
            Cost = cost;
            Price = price;
            TransactionLines = new List<TransactionLine>();
        }

        public List<TransactionLine> TransactionLines { get; set; } = new();
    }
}

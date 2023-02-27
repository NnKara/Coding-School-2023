using FuelStation.Model;
using Session_30.Shared.ItemDto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_30.Shared
{
    public class TransactionLineEditDto {
        public TransactionLineEditDto()
        {
        }

        public TransactionLineEditDto(int quantity, decimal itemPrice, decimal netValue, decimal discountPercent, decimal discountValue, decimal totalValue)
        {
            Quantity = quantity;
            ItemPrice = itemPrice;
            NetValue = netValue;
            DiscountPercent = discountPercent;
            DiscountValue = discountValue;
            TotalValue = totalValue;
        }

        public int TransactionLineID { get; set; }


        [Required]
        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "€{0:#,##0.00}")]
        public decimal ItemPrice { get; set; }


        [Required]
        [DisplayFormat(DataFormatString = "€{0:#,##0.00}")]
        public decimal NetValue { get; set; }

        [Required]
        [Range(0, 100)]
        public decimal DiscountPercent { get; set; }

        [DisplayFormat(DataFormatString = "€{0:#,##0.00}")]
        public decimal DiscountValue { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "€{0:#,##0.00}")]
        public decimal TotalValue { get; set; }

        public int TransactionID { get; set; }

        public Transaction? Transaction { get; set; } = null!;

        public int ItemID { get; set; }
        public Item? Item { get; set; } = null!;

    }
}

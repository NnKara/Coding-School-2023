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
    public class TransactionLineListDto {

        public int TransactionLineID { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "€{0:#,##0.00}")]
        public decimal ItemPrice { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "€{0:#,##0.00}")]
        public decimal NetValue { get; set; }

        [Required]
        [Range(0, 100)]
        [DisplayFormat(DataFormatString = "{0}%")]
        public decimal DiscountPercent { get; set; }


        [DisplayFormat(DataFormatString = "€{0:#,##0.00}")]
        public decimal DiscountValue { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "€{0:#,##0.00}")]
        public decimal TotalValue { get; set; }

        public int TransactionID { get; set; }

        public int ItemID { get; set; }

        public Item? Item { get; set; } = null!;

    }
}

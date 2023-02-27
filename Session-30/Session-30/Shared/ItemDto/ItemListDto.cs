using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_30.Shared.ItemDto
{
    public class ItemListDto {
    
        public int ItemID { get; set; }


        [MaxLength(20, ErrorMessage = "Maximum 20 characters")]
        public string Code { get; set; } = null!;

        [Required(ErrorMessage = "Description is required.")]
        [MaxLength(50, ErrorMessage = "Maximum 50 characters")]
        public string Description { get; set; } = null!;

        [Required(ErrorMessage = "Item Type is required.")]
        [Range(1, 3, ErrorMessage = "You must choose a type!")]
        public ItemType? ItemType { get; set; }


        [Required(ErrorMessage = "Cost is required.")]
        [DisplayFormat(DataFormatString = "€{0:#,##0.00}")]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Cost must be a valid number")]
        public decimal Cost { get; set; }


        [Required(ErrorMessage = "Price is required.")]

        [DisplayFormat(DataFormatString = "€{0:#,##0.00}")]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Price must be a valid number")]
        public decimal Price { get; set; }

        public List<TransactionLine> TransactionLines { get; set; } = new();

    }
}

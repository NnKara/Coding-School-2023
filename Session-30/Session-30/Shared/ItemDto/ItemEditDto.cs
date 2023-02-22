using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_30.Shared.ItemDto
{
    public class ItemEditDto {

        public int ItemID { get; set; }

        [Required(ErrorMessage = "Field is required.")]
        [MaxLength(20, ErrorMessage = "Maximum 20 characters")]
        public string? Code { get; set; }


        [Required(ErrorMessage = "Field is required.")]
        [MaxLength(50, ErrorMessage = "Maximum 50 characters")]
        public string? Description { get; set; }


        [Required(ErrorMessage = "Field is required.")]
        [Range(1, 3, ErrorMessage = "You must choose a type!")]
        public ItemType ItemType { get; set; }


        [Required(ErrorMessage = "Field is required.")]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Price must be a valid number")]
        public decimal Cost { get; set; }

        [Required(ErrorMessage = "Field is required.")]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Price must be a valid number")]
        public decimal Price { get; set; }

        public List<TransactionLineListDto> TransactionLines { get; set; } = new List<TransactionLineListDto>();
    }
}

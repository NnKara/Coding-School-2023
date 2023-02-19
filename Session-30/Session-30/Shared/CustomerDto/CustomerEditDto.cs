using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_30.Shared.CustomerDto
{
    public class CustomerEditDto {

        public int CustomerID { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(15, ErrorMessage = "Maximum 15 characters")]
        [RegularExpression(@"^[a-zA-ZΑ-Ωα-ω\u0386-\u03CE\s]+$", ErrorMessage = "Name can only contain letters")]
        public string? CustomerName { get; set; }

        [Required(ErrorMessage = "Surname is required.")]
        [MaxLength(15, ErrorMessage = "Maximum 15 characters")]
        [RegularExpression(@"^[a-zA-ZΑ-Ωα-ω\u0386-\u03CE\s]+$", ErrorMessage = "Name can only contain letters")]
        public string? CustomerSurname { get; set; }

        [Required(ErrorMessage = "Card Number is required.")]
        [RegularExpression("^A\\d{8}$", ErrorMessage = "Card Number must start with 'A' and have 8 digits.")]
        public string? CardNumber { get; set; }

        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}

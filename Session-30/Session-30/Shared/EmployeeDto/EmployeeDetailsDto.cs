using FuelStation.Model;
using Session_30.Shared.TransactionDto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_30.Shared.EmployeeDto
{
    public class EmployeeDetailsDto {

        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(15, ErrorMessage = "Maximum 15 characters")]
        [RegularExpression(@"^[a-zA-ZΑ-Ωα-ω\u0386-\u03CE\s]+$", ErrorMessage = "Name can only contain letters")]
        public string? EmployeeName { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(15, ErrorMessage = "Maximum 15 characters")]
        [RegularExpression(@"^[a-zA-ZΑ-Ωα-ω\u0386-\u03CE\s]+$", ErrorMessage = "Surname can only contain letters")]
        public string? EmployeeSurname { get; set; }


        [Required]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "€{0:#,##0.00}")]
        public int SalaryPerMonth { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime HireDateStart { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime HireDateEnd { get; set; }

        [Required]

        public EmployeeType EmployeeType { get; set; }

        //Changed
        public List<TransactionDetailsDto> Transactions { get; set; } = new();
    }
}

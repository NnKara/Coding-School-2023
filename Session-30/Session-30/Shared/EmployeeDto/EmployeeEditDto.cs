using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_30.Shared.EmployeeDto
{
    public class EmployeeEditDto {

        public int EmployeeID { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(15, ErrorMessage = "Maximum 15 characters")]
        [RegularExpression(@"^[a-zA-ZΑ-Ωα-ω\u0386-\u03CE\s]+$", ErrorMessage = "Name can only contain letters")]
        public string? EmployeeName { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(15, ErrorMessage = "Maximum 15 characters")]
        [RegularExpression(@"^[a-zA-ZΑ-Ωα-ω\u0386-\u03CE\s]+$", ErrorMessage = "Surname can only contain letters")]
        public string? EmployeeSurname { get; set; }

        [Required(ErrorMessage = "Field is required.")]
        public int SalaryPerMonth { get; set; }

     
        public DateTime HireDateStart { get; set; }


        public DateTime HireDateEnd { get; set; }


        [Required(ErrorMessage = "Field is required.")]
        [Range(1, 3, ErrorMessage = "You must choose a type!")]
        public EmployeeType EmployeeType { get; set; }

        public List<Transaction> Transactions { get; set; } = new();
    }
}

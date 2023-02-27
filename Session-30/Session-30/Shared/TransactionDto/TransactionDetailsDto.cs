using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_30.Shared.TransactionDto
{
    public class TransactionDetailsDto
{
        public int TransactionID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        [Range(1, 2, ErrorMessage = "You must choose a Payment Method!")]
        public PaymentMethod PaymentMethod { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "€{0:#,##0.00}")]
        public decimal TotalValue { get; set; }



        public int EmployeeID { get; set; }
        public Employee? Employee { get; set; }

        public int CustomerID { get; set; }

        public List<TransactionLineEditDto>? TransactionLines { get; set; } = new();
    }
}

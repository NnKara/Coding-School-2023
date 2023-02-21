using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_30.Shared
{
    public class TransactionEditDto {
        public int TransactionID { get; set; }
        public DateTime Date { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        public decimal TotalValue { get; set; }

        public int EmployeeID { get; set; }
        public Employee Employee { get; set; } = null!;

        public int CustomerID { get; set; }
        public Customer Customer { get; set; } = null!;

        public List<TransactionLineEditDto> TransactionLines { get; set; }=new List<TransactionLineEditDto>();
    }
}

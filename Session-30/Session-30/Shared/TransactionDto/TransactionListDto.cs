using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_30.Shared
{
    public class TransactionListDto {

        public int TransactionID { get; set; }
        public DateTime Date { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        public decimal TotalValue { get; set; }
        public int EmployeeID { get; set; }

        public int CustomerID { get; set; }

        public List<TransactionLineListDto> TransactionLines { get; set; } = new();
    }
}

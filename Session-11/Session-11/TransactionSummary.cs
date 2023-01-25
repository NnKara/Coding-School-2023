using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11
{
    public class TransactionSummary
    {

        public Guid TransactionID { get; set; }
        public Guid EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public Guid CustomerID { get; set; }
        public string CustomerName { get; set; }
        public double PetPrice { get; set; }
        public double PetFoodPrice { get; set; }
        public Guid PetID { get; set; }
        public DateTime TransactionDateTime { get; set; }
        public Guid PetFoodID { get; set; }

    }
}

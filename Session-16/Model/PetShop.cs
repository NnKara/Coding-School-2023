using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class PetShop {

        public Guid PetShopId { get; set; }

        public List<Transaction> TransactionList { get; set; }
        public List<Pet> PetList { get; set; }

        public List<PetFood> PetFoodList { get; set; }
        public List<MonthlyLedger> MonthlyLedgerList { get; set; }
        public List<PetReport> PetReportList { get; set; }
        public List<Employee> EmployeeList { get; set; }
        public List<Customer> CustomerList { get; set; }

        public PetShop() { 
            PetShopId = Guid.NewGuid();
            TransactionList = new List<Transaction>();
            PetList = new List<Pet>();
            CustomerList = new List<Customer>();
            EmployeeList = new List<Employee>();
            MonthlyLedgerList= new List<MonthlyLedger>();
            PetReportList = new List<PetReport>();
        }
    }
}

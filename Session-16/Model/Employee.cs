using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employee
    {
        public enum EmployeeWorkType
        {
            MANAGER,
            STAFF
        }
        public Guid EmployeeID { get; set; }

        public string EmployeeName { get; set; } = null!;

        public string EmployeeSurname { get; set; } = null!;

        public decimal SallaryPerMonth { get; set; }

        public EmployeeWorkType EmployeeType { get; set; }

        public Transaction Transaction { get; set; } = null!;
        public Guid TransactionID { get; set; }

        public Employee() 
        {
            EmployeeID= Guid.NewGuid();
        }
        
    }
}

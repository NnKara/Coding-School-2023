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

        public string EmployeeName { get; set; }

        public string EmployeeSurname { get; set; } 

        public decimal SallaryPerMonth { get; set; }

        public EmployeeWorkType EmployeeType { get; set; }

        public List<Transaction> Transactions { get; set; } 


        public Employee() 
        {
            EmployeeID= Guid.NewGuid();
            Transactions= new List<Transaction>();
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FuelStation.Model {
    public class Employee {
        public int EmployeeID { get; set; }
        public string? EmployeeName { get; set; }
        public string? EmployeeSurname { get; set; }

        public int SalaryPerMonth { get; set; }
        public DateTime HireDateStart { get; set; }
        public DateTime HireDateEnd { get; set; }

        public EmployeeType EmployeeType { get; set; }

        public Employee() {
            Transactions = new List<Transaction>();
        }

        public Employee( string? employeeName, string? employeeSurname, int salaryPerMonth, DateTime hireDateStart, DateTime hireDateEnd, EmployeeType employeeType) {
            EmployeeName = employeeName;
            EmployeeSurname = employeeSurname;
            SalaryPerMonth = salaryPerMonth;
            HireDateStart = hireDateStart;
            HireDateEnd = hireDateEnd;
            EmployeeType = employeeType;
            Transactions = new List<Transaction>();
        }




        //Relations

        public List<Transaction> Transactions { get; set; }=new List<Transaction>();
    }
}

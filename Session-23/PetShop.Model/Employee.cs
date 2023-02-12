using PetShop.Model.Enums;
using System.ComponentModel;

namespace PetShop.Model
{
    public class Employee
    {
        public Employee() {
            Transactions = new List<Transaction>();
        }

        public Employee(string name, string surname, EmployeeType employeeType, int salaryPerMonth)
        {
            EmployeeName = name;
            EmployeeSurname = surname;
            EmployeeType = employeeType;
            SalaryPerMonth = salaryPerMonth;
            Transactions = new List<Transaction>();
        }

        public int EmployeeID { get; set; }

        [DisplayName("Name")]
        public string EmployeeName { get; set; }

        [DisplayName("Surname")]
        public string EmployeeSurname { get; set; }

        [DisplayName("Type")]
        public EmployeeType EmployeeType { get; set; }

        [DisplayName("Salary")]
        public int SalaryPerMonth { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; }
    }
}

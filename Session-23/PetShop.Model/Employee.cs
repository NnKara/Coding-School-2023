using PetShop.Model.Enums;

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
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public int SalaryPerMonth { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; }
    }
}

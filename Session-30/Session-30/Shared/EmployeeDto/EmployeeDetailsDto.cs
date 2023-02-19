using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_30.Shared.EmployeeDto
{
    public class EmployeeDetailsDto {

        public int EmployeeID { get; set; }
        public string? EmployeeName { get; set; }
        public string? EmployeeSurname { get; set; }

        public int SalaryPerMonth { get; set; }
        public DateTime HireDateStart { get; set; }
        public DateTime HireDateEnd { get; set; }

        public EmployeeType EmployeeType { get; set; }

        public List<Transaction> Transactions { get; set; } = new();
    }
}

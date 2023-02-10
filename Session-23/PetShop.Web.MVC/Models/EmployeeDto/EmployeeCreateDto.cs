using PetShop.Model;
using PetShop.Model.Enums;

namespace PetShop.Web.MVC.Models.EmployeeDto {
    public class EmployeeCreateDto {



        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public int SalaryPerMonth { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; }
    }
}

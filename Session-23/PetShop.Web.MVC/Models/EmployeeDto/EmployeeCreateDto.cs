using PetShop.Model;
using PetShop.Model.Enums;
using System.ComponentModel;

namespace PetShop.Web.MVC.Models.EmployeeDto {
    public class EmployeeCreateDto {


        [DisplayName("Employee")]
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
        public List<Transaction> Transactions { get; set; }=new List<Transaction>();
    }
}

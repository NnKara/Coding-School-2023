using PetShop.Model;
using PetShop.Model.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PetShop.Web.MVC.Models.EmployeeDto {
    public class EmployeeDtoEdit {

        [DisplayName("Employee")]
        public int EmployeeID { get; set; }




        [DisplayName("Name")]
        [MaxLength(15, ErrorMessage = "Maximum 15 characters")]
        [RegularExpression(@"^[a-zA-ZΑ-Ωα-ω\u0386-\u03CE\s]+$", ErrorMessage = "Name can only contain letters")]
        public string EmployeeName { get; set; }




        [DisplayName("Surname")]
        [MaxLength(15, ErrorMessage = "Maximum 15 characters")]
        [RegularExpression(@"^[a-zA-ZΑ-Ωα-ω\u0386-\u03CE\s]+$", ErrorMessage = "Surname can only contain letters")]
        public string EmployeeSurname { get; set; }




        [DisplayName("Type")]
        public EmployeeType EmployeeType { get; set; }




        [DisplayName("Salary")]
        public int SalaryPerMonth { get; set; }





        // Relations
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}

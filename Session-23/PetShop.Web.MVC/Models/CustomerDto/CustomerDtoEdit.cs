using PetShop.Model;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PetShop.Web.MVC.Models.CustomerDto {
    public class CustomerDtoEdit {

        [DisplayName("Customer")]
        public int CustomerDtoID { get; set; }



        [DisplayName("Name")]
        [MaxLength(15, ErrorMessage = "Maximum 15 characters")]
        [RegularExpression(@"^[a-zA-ZΑ-Ωα-ω\u0386-\u03CE\s]+$", ErrorMessage = "Name can only contain letters")]
        public string CustomerDtoName { get; set; }



        [DisplayName("Surname")]
        [MaxLength(15, ErrorMessage = "Maximum 15 characters")]
        [RegularExpression(@"^[a-zA-ZΑ-Ωα-ω\u0386-\u03CE\s]+$", ErrorMessage = "Surname can only contain letters")]
        public string CustomerDtoSurname { get; set; }



        [DisplayName("Phone")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone format is not valid.")]
        public string PhoneDto { get; set; }



        [DisplayName("TIN")]
        [RegularExpression(@"^\d{8}$", ErrorMessage = "TIN format is not valid.")]
        public string TINDto { get; set; }





        // Relations
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}

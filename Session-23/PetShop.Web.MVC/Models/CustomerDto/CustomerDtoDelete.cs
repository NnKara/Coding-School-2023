using PetShop.Model;

namespace PetShop.Web.MVC.Models.CustomerDto {
    public class CustomerDtoDelete {
        public int CustomerDtoID { get; set; }
        public string CustomerDtoName { get; set; }
        public string CustomerDtoSurname { get; set; }
        public string PhoneDto { get; set; }
        public string TINDto { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; }
    }
}

using PetShop.Model;
using System.ComponentModel;

namespace PetShop.Web.MVC.Models.CustomerDto {
    public class CustomerDtoCreate {



        [DisplayName("Customer")]
        public int CustomerDtoID { get; set; }
        [DisplayName("Name")]
        public string CustomerDtoName { get; set; }
        [DisplayName("Surname")]
        public string CustomerDtoSurname { get; set; }
        [DisplayName("Phone")]
        public string PhoneDto { get; set; }
        [DisplayName("TIN")]
        public string TINDto { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; }=new List<Transaction>();
    }
}

using PetShop.Model;

namespace PetShop.Web.MVC.Models.CustomerDto {
    public class CustomerDtoCreate {
        private string customerName;
        private string customerSurname;
        private string tIN;
        private string phone;

        public CustomerDtoCreate(string customerName, string customerSurname, string tIN, string phone) {
            this.customerName = customerName;
            this.customerSurname = customerSurname;
            this.tIN = tIN;
            this.phone = phone;
        }

        public int CustomerDtoID { get; set; }
        public string CustomerDtoName { get; set; }
        public string CustomerDtoSurname { get; set; }
        public string PhoneDto { get; set; }
        public string TINDto { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; }
    }
}

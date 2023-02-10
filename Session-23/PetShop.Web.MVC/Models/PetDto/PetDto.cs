using PetShop.Model;
using PetShop.Model.Enums;

namespace PetShop.Web.MVC.Models.PetDto {
    public class PetDto {
        public int PetID { get; set; }
        public string Breed { get; set; }
        public AnimalType AnimalType { get; set; }
        public PetStatus PetStatus { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; }
    }
}

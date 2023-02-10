using PetShop.Model;
using PetShop.Model.Enums;

namespace PetShop.Web.MVC.Models.PetFoodDto {
    public class PetFoodDtoCreate {
        public int PetFoodID { get; set; }
        public AnimalType AnimalType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; }
    }
}

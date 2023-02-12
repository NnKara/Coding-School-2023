using PetShop.Model;
using PetShop.Model.Enums;

namespace PetShop.Web.MVC.Models.PetFoodDto {
    public class PetFoodDtoDelete {
        public int PetFoodID { get; set; }
        public AnimalType AnimalType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }


    }
}

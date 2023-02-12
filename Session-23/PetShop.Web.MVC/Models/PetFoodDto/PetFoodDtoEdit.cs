using PetShop.Model;
using PetShop.Model.Enums;
using System.ComponentModel;

namespace PetShop.Web.MVC.Models.PetFoodDto {
    public class PetFoodDtoEdit {

        [DisplayName("Pet")]
        public int PetFoodID { get; set; }

        [DisplayName("Type")]
        public AnimalType AnimalType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}

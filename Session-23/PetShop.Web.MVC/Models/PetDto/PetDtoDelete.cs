using PetShop.Model;
using PetShop.Model.Enums;
using System.ComponentModel;

namespace PetShop.Web.MVC.Models.PetDto {
    public class PetDtoDelete {

        [DisplayName("Pet")]
        public int PetID { get; set; }
        public string Breed { get; set; }

        [DisplayName("Type")]
        public AnimalType AnimalType { get; set; }

        [DisplayName("Status")]
        public PetStatus PetStatus { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

    }
}

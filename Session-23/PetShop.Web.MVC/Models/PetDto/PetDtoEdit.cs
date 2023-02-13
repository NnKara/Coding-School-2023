using PetShop.Model;
using PetShop.Model.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PetShop.Web.MVC.Models.PetDto {
    public class PetDtoEdit {

        [DisplayName("Pet")]
        public int PetID { get; set; }


        [MaxLength(20, ErrorMessage = "Maximum 20 characters")]
        [RegularExpression(@"^[a-zA-ZΑ]+$", ErrorMessage = "Breed can only contain letters")]
        public string Breed { get; set; }



        [DisplayName("Type")]
        public AnimalType AnimalType { get; set; }




        [DisplayName("Status")]
        public PetStatus PetStatus { get; set; }


        public decimal Price { get; set; }


        public decimal Cost { get; set; }




        // Relations
        public List<Transaction> Transactions { get; set; }=new List<Transaction>();
    }
}

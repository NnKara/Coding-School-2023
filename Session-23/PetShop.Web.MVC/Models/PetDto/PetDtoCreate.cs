using PetShop.Model;
using PetShop.Model.Enums;
using System.ComponentModel;

namespace PetShop.Web.MVC.Models.PetDto {
    public class PetDtoCreate {

        [DisplayName("Pet")]
        public int PetID { get; set; }
        public string Breed { get; set; }
        [DisplayName("Animal Type")]
        public AnimalType AnimalType { get; set; }
        [DisplayName("Pet Status")]
        public PetStatus PetStatus { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; }=new List<Transaction>();
    }
}

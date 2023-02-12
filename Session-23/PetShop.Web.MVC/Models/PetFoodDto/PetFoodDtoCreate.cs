using PetShop.Model;
using PetShop.Model.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PetShop.Web.MVC.Models.PetFoodDto {
    public class PetFoodDtoCreate {

        [DisplayName("Pet Food")]
        public int PetFoodID { get; set; }




        [DisplayName("Animal Type")]
        public AnimalType AnimalType { get; set; }



        public decimal Price { get; set; }



        public decimal Cost { get; set; }




        // Relations
        public List<Transaction> Transactions { get; set; }= new List<Transaction>();
    }
}

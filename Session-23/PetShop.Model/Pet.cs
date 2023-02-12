using PetShop.Model.Enums;
using System.ComponentModel;

namespace PetShop.Model
{
    public class Pet
    {
        public Pet() {
            Transactions = new List<Transaction>();
        }

        public Pet(string breed, AnimalType animalType, PetStatus petStatus, decimal price, decimal cost)
        {
            Breed = breed;
            AnimalType = animalType;
            PetStatus = petStatus;
            Price = price;
            Cost = cost;

            Transactions = new List<Transaction>();
        }

        public int PetID { get; set; }
        public string Breed { get; set; }

        [DisplayName("Type")]
        public AnimalType AnimalType { get; set; }

        [DisplayName("Status")]
        public PetStatus PetStatus { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; }
    }
}

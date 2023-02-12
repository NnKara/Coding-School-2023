using PetShop.Model.Enums;
using System.ComponentModel;

namespace PetShop.Model
{
    public class PetFood
    {
        public PetFood() {
            Transactions=new List<Transaction>();
        }

        public PetFood(AnimalType animalType, decimal price, decimal cost)
        {
            AnimalType = animalType;
            Price = price;
            Cost = cost;

            Transactions = new List<Transaction>();
        }

        public int PetFoodID { get; set; }

        [DisplayName("Type")]
        public AnimalType AnimalType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PetFood
    {
        public Guid PetFoodID { get; set; }
        public AnimalType AnimalType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public List<Transaction> Transactions { get; set; }


        public PetFood()
        {
            PetFoodID= Guid.NewGuid();
            Transactions=new List<Transaction>();
        }

       

    }
}

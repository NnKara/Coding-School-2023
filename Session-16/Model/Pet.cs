using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pet
    {
   
        public Guid PetID { get; set; }
        public string Breed { get; set; } = null!;
        public AnimalType AnimalType { get; set; }
        public PetStatus PetStatus { get; set; } 
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        public List<Transaction> Transactions { get; set; } 


        public Pet()
        {
            PetID = Guid.NewGuid();
            Transactions=new List<Transaction>();
        }

    }
}

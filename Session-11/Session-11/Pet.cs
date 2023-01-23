using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11
{
    public class Pet
    {
        public enum AnimalTypeEnum
        {
            Bird,
            Cat,
            Dog
        }
        public enum PetStatusEnum
        {
            OK,
            Unhealthy,
            Recovering
        }
        public Guid PetID { get; set; }
        public string Breed { get; set; }
         public AnimalTypeEnum AnimalType { get; set; }
        public PetStatusEnum Status { get; set; }
        public double Price { get; set; }
        public double Cost { get; set; }

        public Pet(){
            PetID = Guid.NewGuid();           
        }

      


    }
}

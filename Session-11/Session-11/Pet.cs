using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11
{
    public class Pet
    {
        enum AnimalTypeEnum
        {
            Bird,
            Cat,
            Dog
        }
        enum PetStatusEnum
        {
            OK,
            Unhealthy,
            Recovering
        }
        public Guid PetID { get; set; }
        public string Breed { get; set; }
        AnimalTypeEnum AnimalType { get; set; }
        PetStatusEnum Status { get; set; }
        public int Price { get; set; }
        public int Cost { get; set; }

        public Pet(){
            PetID = Guid.NewGuid();           
        }


    }
}

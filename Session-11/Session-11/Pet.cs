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
            Dog,
            None
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
            if(AnimalType== AnimalTypeEnum.Bird)
            {
                Price = 10;
                Cost= 2;
            }
            else if(AnimalType==AnimalTypeEnum.Cat)
            {
                Price = 20;

                Cost= 3;
            }
            else
            {
                Price = 15;
                Cost= 4;
            }
        }

      


    }
}

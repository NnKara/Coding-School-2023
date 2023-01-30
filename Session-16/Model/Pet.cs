using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pet
    {
        public enum AnimalType
        {
            Bird,
            Cat,
            Dog
        }

        public enum AnimalStatus
        {
            OK,
            UNHEALTHY,
            RECOVERING
        }

        public Guid PetID { get; set; }
        public string Breed { get; set; }
        public AnimalType PetType { get; set; }
        public AnimalStatus PetStatus { get; set; } 
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

    }
}

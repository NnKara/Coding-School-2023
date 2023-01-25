using DevExpress.XtraScheduler.Outlook.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11 {
    public class Pet {
        public enum AnimalTypeEnum {
            Bird,
            Cat,
            Dog,
            None
        }
        public enum PetStatusEnum {
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

        public string AnimalBreed {
            get {
                return String.Format("{0} {1}",AnimalType,Breed);
            }
        }

        public Pet() {
            PetID=Guid.NewGuid();
        }
    
            public Pet(Guid petID, string breed, AnimalTypeEnum animalType, PetStatusEnum status, double price, double cost) {
                PetID = petID;
                Breed = breed;
                AnimalType = animalType;
                Status = status;
                Price = price;
                Cost = cost;
            }
        }
    }


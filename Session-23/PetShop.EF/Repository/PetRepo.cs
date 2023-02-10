using PetShop.EF.Context;
using PetShop.Model;
using PetShop.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Repository {
    public class PetRepo : EntityInterface<Pet> {
        public void Add(Pet entity) {
            using var petShopContext = new PetShopDbContext();
            var existingPet = petShopContext.Pets.FirstOrDefault(p => p.Breed == entity.Breed);
            if (entity.PetID != 0) {
                throw new ArgumentException("Given entity should not have ID set", nameof(entity));
            }

                petShopContext.Add(entity);
                petShopContext.SaveChanges();
            
        }

        public void Delete(int id) {
            using var petShopContext = new PetShopDbContext();
            var dbPet = petShopContext.Pets.Where(pet => pet.PetID == id).SingleOrDefault();
            if (dbPet is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            petShopContext.Remove(dbPet);
            petShopContext.SaveChanges();
        }

        public IList<Pet> GetAll() {
            using var petShopContext = new PetShopDbContext();
            return petShopContext.Pets.ToList();
        }

        public Pet? GetByID(int id) {
            using var petShopContext = new PetShopDbContext();
            var dbPet= petShopContext.Pets.Where(pet => pet.PetID == id).SingleOrDefault();
            if (dbPet is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            } else {
                return dbPet;
            }
        }

        public void Update(int id, Pet entity) {
            using var petShopContext = new PetShopDbContext();
            var dbPet = petShopContext.Pets.Where(pet => pet.PetID == id).SingleOrDefault();
            if (dbPet is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            dbPet.PetStatus = entity.PetStatus;
            dbPet.AnimalType = entity.AnimalType;
            dbPet.Price = entity.Price;
            dbPet.Cost = entity.Cost;
            dbPet.Breed = entity.Breed;
            petShopContext.SaveChanges();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Model;
using Orm.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Repository
{
    public class PetRepo : EntityInterface<Pet>
    {
        public void Add(Pet entity)
        {
            using var petShopContext = new PetShopContext();
            var existingPet = petShopContext.Pets.FirstOrDefault(p => p.Breed == entity.Breed);
            if (existingPet == null) {
                petShopContext.Add(entity);
                petShopContext.SaveChanges();
            }
        }

        public void Delete(Guid id)
        {
            using var petShopContext = new PetShopContext();
            var dbPet = petShopContext.Pets.Where(pet => pet.PetID == id).SingleOrDefault();
            if (dbPet is null)
                return;
            petShopContext.Remove(dbPet);
            petShopContext.SaveChanges();
        }

        public IList<Pet> GetAll()
        {
            using var petShopContext = new PetShopContext();
            return petShopContext.Pets.Where(pet=>pet.PetStatus!=PetStatus.UNHEALTHY).ToList();
        }

        public Pet? GetById(Guid id)
        {
            using var petShopContext = new PetShopContext();
            return petShopContext.Pets.Where(pet => pet.PetID == id).SingleOrDefault();
        }

        public void Update(Guid id, Pet entity)
        {
            using var petShopContext = new PetShopContext();
            var dbPet = petShopContext.Pets.Where(pet => pet.PetID == id).SingleOrDefault();
            if (dbPet is null)
                return;
            dbPet.PetStatus = entity.PetStatus;
            dbPet.AnimalType = entity.AnimalType;
            dbPet.Price = entity.Price;
            dbPet.Cost = entity.Cost;
            dbPet.Breed = entity.Breed;          
            petShopContext.SaveChanges();
        }
    }
}

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
    public class PetFoodRepo : EntityInterface<PetFood>
    {

        public void Add(PetFood entity)
        {
            using var petShopContext = new PetShopContext();
            petShopContext.Add(entity);
            petShopContext.SaveChanges();
            
        }

        public void Delete(Guid id)
        {
            using var petShopContext = new PetShopContext();
            var dbPetFood = petShopContext.PetFoods.Where(petfood => petfood.PetFoodID == id).SingleOrDefault();
            if (dbPetFood is null)
                return;
            petShopContext.Remove(dbPetFood);
            petShopContext.SaveChanges();
        }

        public IList<PetFood> GetAll()
        {
            using var petShopContext = new PetShopContext();
            return petShopContext.PetFoods.ToList();
        }

        public PetFood? GetById(Guid id)
        {
            using var petShopContext = new PetShopContext();
            return petShopContext.PetFoods.Where(petfood => petfood.PetFoodID == id).SingleOrDefault();
        }

        public void Update(Guid id, PetFood entity)
        {
            using var petShopContext = new PetShopContext();
            var dbPetFood = petShopContext.PetFoods.Where(petfood => petfood.PetFoodID == id).SingleOrDefault();
            if (dbPetFood is null)
                return;
            dbPetFood.Price= entity.Price;
            dbPetFood.AnimalType= entity.AnimalType;
            dbPetFood.Cost= entity.Cost;
            petShopContext.SaveChanges();
        }
    }
}

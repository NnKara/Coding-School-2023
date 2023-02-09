using PetShop.EF.Context;
using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Repository {
    public class PetFoodRepo : EntityInterface<PetFood> {
        public void Add(PetFood entity) {

                using var petShopContext = new PetShopDbContext();
            if (entity.PetFoodID != 0) {
                throw new ArgumentException("Given entity should not have ID set", nameof(entity));
            }
            petShopContext.Add(entity);
                petShopContext.SaveChanges();
            }

        public void Delete(int id) {
            using var petShopContext = new PetShopDbContext();
            var dbPetFood = petShopContext.PetFoods.Where(petfood => petfood.PetFoodID == id).SingleOrDefault();
            if (dbPetFood is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            petShopContext.Remove(dbPetFood);
            petShopContext.SaveChanges();
        }

        public IList<PetFood> GetAll() {
            using var petShopContext = new PetShopDbContext();
            return petShopContext.PetFoods.ToList();
        }

        public PetFood? GetByID(int id) {
            using var petShopContext = new PetShopDbContext();
            var dbPetFood= petShopContext.PetFoods.Where(petfood => petfood.PetFoodID == id).SingleOrDefault();
            if (dbPetFood is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            } else {
                return dbPetFood;
            }
        }

        public void Update(int id, PetFood entity) {
            using var petShopContext = new PetShopDbContext();
            var dbPetFood = petShopContext.PetFoods.Where(petfood => petfood.PetFoodID == id).SingleOrDefault();
            if (dbPetFood is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            dbPetFood.Price = entity.Price;
            dbPetFood.AnimalType = entity.AnimalType ;
            dbPetFood.Cost = entity.Cost;
            petShopContext.SaveChanges();
        }
    }
}

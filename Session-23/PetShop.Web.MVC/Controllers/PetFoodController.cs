using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repository;
using PetShop.Model;
using PetShop.Web.MVC.Models.PetDto;
using PetShop.Web.MVC.Models.PetFoodDto;
using System.Drawing;

namespace PetShop.Web.MVC.Controllers {
    public class PetFoodController : Controller {

        private readonly EntityInterface<PetFood> _petFoodRepo;

        public PetFoodController(EntityInterface<PetFood> petFoodRepo) {
            _petFoodRepo = petFoodRepo;
        }
        // GET: PetFoodController
        public ActionResult PetFood() {
            var petFoods = _petFoodRepo.GetAll();
            return View(model: petFoods);
        }

        // GET: PetFoodController/Details/5
        public ActionResult Details(int id) {
            if (id == null) {
                return NotFound();
            }

            var dbFoodPet = _petFoodRepo.GetByID(id);
            if (dbFoodPet == null) {
                return NotFound();
            }

            var viewPetFood = new PetFoodDto {              
                AnimalType = dbFoodPet.AnimalType,               
                Cost = dbFoodPet.Cost,
                Price = dbFoodPet.Price,
                PetFoodID = dbFoodPet.PetFoodID,
                Transactions = dbFoodPet.Transactions.ToList()
            };
            return View(model: viewPetFood);
        }

        // GET: PetFoodController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: PetFoodController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PetFood petFood) {
            if (!ModelState.IsValid) {
                return View();
            }

            var dbPetFood = new PetFood( petFood.AnimalType,petFood.Cost, petFood.Price);
            _petFoodRepo.Add(dbPetFood);
            return RedirectToAction("PetFood");
        }

        // GET: PetFoodController/Edit/5
        public ActionResult Edit(int id) {
            var dbPetFood = _petFoodRepo.GetByID(id);
            if (dbPetFood == null) {
                return NotFound();
            }

            var viewPetFood = new PetFoodDtoEdit {
                Cost = dbPetFood.Cost,
                Price = dbPetFood.Price,
                AnimalType = dbPetFood.AnimalType,
                PetFoodID = dbPetFood.PetFoodID,
                Transactions = dbPetFood.Transactions.ToList()
            };
            return View(model: viewPetFood);
        }

        // POST: PetFoodController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PetDtoEdit petFood) {
            var dbPetFood = _petFoodRepo.GetByID(id);
            if (dbPetFood == null) {
                return NotFound();
            }
            dbPetFood.Cost = petFood.Cost;
            dbPetFood.Price = petFood.Price;
            dbPetFood.AnimalType = petFood.AnimalType;
            _petFoodRepo.Update(id, dbPetFood);
            return RedirectToAction(nameof(PetFood));
        }

        // GET: PetFoodController/Delete/5
        public ActionResult Delete(int id) {
            var dbPetFood = _petFoodRepo.GetByID(id);
            if (dbPetFood == null) {
                return NotFound();
            }

            var viewPetFood = new PetFoodDtoDelete {
              
                Cost = dbPetFood.Cost,
                Price = dbPetFood.Price,
                AnimalType = dbPetFood.AnimalType,
                PetFoodID = dbPetFood.PetFoodID,
            };
            return View(model: viewPetFood);
        }

        // POST: PetFoodController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            _petFoodRepo.Delete(id);
            return RedirectToAction(nameof(PetFood));
        }
    }
}

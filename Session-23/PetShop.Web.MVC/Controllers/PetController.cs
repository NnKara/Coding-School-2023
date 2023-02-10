using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repository;
using PetShop.Model;
using PetShop.Web.MVC.Models.CustomerDto;
using PetShop.Web.MVC.Models.EmployeeDto;
using PetShop.Web.MVC.Models.PetDto;

namespace PetShop.Web.MVC.Controllers {
    public class PetController : Controller {

        private readonly EntityInterface<Pet> _petRepo;

        public PetController(EntityInterface<Pet> petRepo) {
            _petRepo = petRepo;
        }
    
        // GET: PetController
        public ActionResult Pet() {
            var pets=_petRepo.GetAll();
            return View(model: pets);
        }

        // GET: PetController/Details/5
        public ActionResult Details(int id) {
            if (id == null) {
                return NotFound();
            }

            var dbPet = _petRepo.GetByID(id);
            if (dbPet == null) {
                return NotFound();
            }

            var viewPet = new PetDto {
               
                Breed= dbPet.Breed,
                AnimalType= dbPet.AnimalType,
                PetStatus= dbPet.PetStatus,
                Cost= dbPet.Cost,
                Price= dbPet.Price,
                PetID= dbPet.PetID,
                Transactions = dbPet.Transactions.ToList()
            };
            return View(model: viewPet);
        }

        // GET: PetController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: PetController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Pet pet) {

            if (!ModelState.IsValid) {
                return View();
            }

            var dbPet=new Pet(pet.Breed,pet.AnimalType,pet.PetStatus,pet.Cost,pet.Price);
            _petRepo.Add(dbPet);
            return RedirectToAction("Pet");
        }

        // GET: PetController/Edit/5
        public ActionResult Edit(int id) {
            var dbPet = _petRepo.GetByID(id);
            if (dbPet == null) {
                return NotFound();
            }

            var viewPet = new PetDtoEdit {
                Breed = dbPet.Breed,
                Cost = dbPet.Cost,
                Price = dbPet.Price,
                AnimalType = dbPet.AnimalType,
                PetStatus = dbPet.PetStatus,
                PetID= dbPet.PetID,
                Transactions = dbPet.Transactions.ToList()
            };
            return View(model: viewPet);

        }

        // POST: PetController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PetDtoEdit pet) {
            var dbPet = _petRepo.GetByID(id);
            if (dbPet == null) {
                return NotFound();
            }

            dbPet.Breed = pet.Breed;
            dbPet.Cost = pet.Cost;
            dbPet.Price = pet.Price;
            dbPet.AnimalType= pet.AnimalType;
            dbPet.PetStatus= pet.PetStatus;
            _petRepo.Update(id, dbPet);
            return RedirectToAction(nameof(Pet));


        }

        // GET: PetController/Delete/5
        public ActionResult Delete(int id) {
            var dbPet = _petRepo.GetByID(id);
            if (dbPet == null) {
                return NotFound();
            }

            var viewPet = new PetDtoDelete {
                Breed = dbPet.Breed,
                Cost = dbPet.Cost,
                Price = dbPet.Price,
                AnimalType = dbPet.AnimalType,
                PetStatus = dbPet.PetStatus,
                PetID = dbPet.PetID,
            };
            return View(model: viewPet);
        }

        // POST: PetController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            _petRepo.Delete(id);
            return RedirectToAction(nameof(Pet));
        }
    }
}

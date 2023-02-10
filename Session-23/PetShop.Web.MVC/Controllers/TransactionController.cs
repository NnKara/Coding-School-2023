using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repository;
using PetShop.Model;
using PetShop.Web.MVC.Models.PetFoodDto;
using PetShop.Web.MVC.Models.TransactionDto;

namespace PetShop.Web.MVC.Controllers {
    public class TransactionController : Controller {
        private readonly EntityInterface<Transaction> _transactionRepo;

        public TransactionController(EntityInterface<Transaction> transactionRepo) {
            _transactionRepo = transactionRepo;
        }
        // GET: TransactionController
        public ActionResult Transaction() {
            var tras = _transactionRepo.GetAll();
            return View(model: tras);
        }

        // GET: TransactionController/Details/5
        public ActionResult Details(int id) {
            if (id == null) {
                return NotFound();
            }

            var dbTransaction = _transactionRepo.GetByID(id);
            if (dbTransaction == null) {
                return NotFound();
            }

            var viewTras = new TransactionDto {
               Customer=dbTransaction.Customer,
               Employee=dbTransaction.Employee,
               Pet=dbTransaction.Pet,
               PetFood=dbTransaction.PetFood,
               PetFoodPrice=dbTransaction.PetFoodPrice,
               PetFoodQty=dbTransaction.PetFoodQty,
               TotalPrice=dbTransaction.TotalPrice,
               Date=dbTransaction.Date

            };
            return View(model: viewTras);
        }

        // GET: TransactionController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: TransactionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TransactionDtoCreate tras) {
            if (!ModelState.IsValid) {
                return View();
            }

            var dbTras = new Transaction(tras.PetPrice,tras.PetFoodQty,tras.PetFoodPrice,tras.TotalPrice);
            _transactionRepo.Add(dbTras);
            return RedirectToAction("Transaction");
        }

        // GET: TransactionController/Edit/5
        public ActionResult Edit(int id) {
            var dbTras = _transactionRepo.GetByID(id);
            if (dbTras == null) {
                return NotFound();
            }

            var viewTras = new TransactionDtoEdit {
                PetPrice=dbTras.PetPrice,
                PetFoodPrice=dbTras.PetFoodPrice,
                PetFood=dbTras.PetFood,
                PetFoodQty=dbTras.PetFoodQty,
                TotalPrice=dbTras.TotalPrice,
                Date=dbTras.Date,
                Customer=dbTras.Customer,
                Employee=dbTras.Employee,
                Pet=dbTras.Pet,
                TransactionID=dbTras.TransactionID                             
            };
            return View(model: viewTras);
        }

        // POST: TransactionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TransactionDtoEdit tras) {
            var dbTras = _transactionRepo.GetByID(id);
            if (dbTras == null) {
                return NotFound();
            }
            dbTras.PetPrice = tras.PetPrice;
            dbTras.PetFoodPrice = tras.PetFoodPrice;
            dbTras.TotalPrice = tras.TotalPrice;
            dbTras.Date = tras.Date;
            dbTras.Customer = tras.Customer;
            dbTras.Employee = tras.Employee;
            dbTras.Pet = tras.Pet;
            dbTras.PetFood= tras.PetFood;
            dbTras.PetFoodQty = tras.PetFoodQty;
            _transactionRepo.Update(id, dbTras);
            return RedirectToAction(nameof(PetFood));
        }

        // GET: TransactionController/Delete/5
        public ActionResult Delete(int id) {
            var dbTras = _transactionRepo.GetByID(id);
            if (dbTras == null) {
                return NotFound();
            }

            var viewTras = new TransactionDtoDelete {
                Employee= dbTras.Employee,
                Customer= dbTras.Customer,
                Pet= dbTras.Pet,
                PetFood= dbTras.PetFood,
                PetPrice= dbTras.PetPrice,
                Date= dbTras.Date,
                PetFoodQty= dbTras.PetFoodQty,
                TotalPrice= dbTras.TotalPrice,
                TransactionID=dbTras.TransactionID
            };
            return View(model: viewTras);
        }

        // POST: TransactionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            _transactionRepo.Delete(id);
            return RedirectToAction(nameof(Transaction));
        }
    }
}

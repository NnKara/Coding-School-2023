using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repository;
using PetShop.Model;
using PetShop.Web.MVC.Models.PetFoodDto;
using PetShop.Web.MVC.Models.TransactionDto;
using System.Drawing;

namespace PetShop.Web.MVC.Controllers {
    public class TransactionController : Controller {
        private readonly EntityInterface<Transaction> _transactionRepo;
        private readonly EntityInterface<Customer> _customerRepo;
        private readonly EntityInterface<Employee> _employeeRepo;
        private readonly EntityInterface<Pet> _petRepo;
        private readonly EntityInterface<PetFood> _petFoodRepo;

        public TransactionController(EntityInterface<Transaction> transactionRepo,EntityInterface<Customer> customerRepo, 
                                     EntityInterface<Pet> petRepo,
                                     EntityInterface<Employee> employeeRepo,
                                     EntityInterface<PetFood> petFoodRepo)
        {
            _transactionRepo = transactionRepo;
            _customerRepo = customerRepo;
            _petFoodRepo = petFoodRepo;
            _employeeRepo=employeeRepo;
            _petRepo = petRepo;
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
                CustomerID = dbTransaction.CustomerID,
                EmployeeID = dbTransaction.EmployeeID,
                PetID = dbTransaction.PetID,
                PetPrice = dbTransaction.PetPrice,
                PetFoodID = dbTransaction.PetFoodID,
                PetFoodPrice = dbTransaction.PetFoodPrice,
                PetFoodQty = dbTransaction.PetFoodQty,
                TotalPrice = dbTransaction.TotalPrice,
                Date = dbTransaction.Date
            };
            return View(model: viewTras);
        }

        // GET: TransactionController/Create
        public ActionResult Create() {
            var newTras = new TransactionDtoCreate();
            var customers = _customerRepo.GetAll();
            var employees = _employeeRepo.GetAll();
            var pets = _petRepo.GetAll();
            var petFoods = _petFoodRepo.GetAll();

            foreach (var customer in customers) {
                newTras.Customers.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(customer.CustomerSurname, customer.CustomerID.ToString()));
            } 
            foreach (var employee in employees) {
                newTras.Employees.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(employee.EmployeeSurname, employee.EmployeeID.ToString()));
            } 
            foreach (var pet in pets) {
                newTras.Pets.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(pet.Breed, pet.PetID.ToString()));
                //TODO
                newTras.PetPrice = pet.Price;
            } 


            foreach (var petFood in petFoods) {
                newTras.PetFoods.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(petFood.AnimalType.ToString(),petFood.PetFoodID.ToString()));
            }       

            
            return View(model: newTras);
        }


        // POST: TransactionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TransactionDtoCreate tras) {

            //if (!ModelState.IsValid) {
            //    return View();
            //}

            var dbTras = new Transaction(tras.PetPrice,tras.PetFoodQty,tras.PetFoodPrice,tras.TotalPrice);
            dbTras.CustomerID= tras.CustomerID;
            dbTras.EmployeeID= tras.EmployeeID;
            dbTras.PetFoodID= tras.PetFoodID;
            dbTras.PetID= tras.PetID;
            dbTras.TotalPrice = (tras.PetFoodQty * tras.PetPrice) + tras.PetFoodPrice;
            
            _transactionRepo.Add(dbTras);
            return RedirectToAction("Transaction");
        }

        // GET: TransactionController/Edit/5
        public ActionResult Edit(int id) {
            var dbTras = _transactionRepo.GetByID(id);
            if (dbTras == null) {
                return NotFound();
            }

            var trasDto = new TransactionDtoEdit {
                PetPrice=dbTras.PetPrice,
                PetFoodPrice=dbTras.PetFoodPrice,
                PetFood=dbTras.PetFood,
                PetFoodQty=dbTras.PetFoodQty,
                TotalPrice=dbTras.TotalPrice,
                Date=dbTras.Date,
                CustomerID=dbTras.CustomerID,
                EmployeeID=dbTras.EmployeeID,
                PetID=dbTras.PetID,
                TransactionID=dbTras.TransactionID                             
            };
            var customers = _customerRepo.GetAll();
            var employees=_employeeRepo.GetAll();
            var pets=_petRepo.GetAll();
            var petFoods=_petFoodRepo.GetAll();
            foreach (var customer in customers) {
               trasDto.Customers.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(customer.CustomerSurname,customer.CustomerID.ToString()));   
            }
            foreach (var employee in employees) {
                trasDto.Employees.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(employee.EmployeeSurname, employee.EmployeeID.ToString()));
            }
            foreach (var pet in pets) {
                trasDto.Pets.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(pet.Breed, pet.PetID.ToString()));           
            }


            foreach (var petFood in petFoods) {
                trasDto.PetFoods.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(petFood.AnimalType.ToString(), petFood.PetFoodID.ToString()));
            }
            return View(model: trasDto);
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
            dbTras.CustomerID = tras.CustomerID;
            dbTras.EmployeeID = tras.EmployeeID;
            dbTras.PetID = tras.PetID;
            dbTras.PetFoodID= tras.PetFoodID;
            dbTras.PetFoodQty = tras.PetFoodQty;
            _transactionRepo.Update(id, dbTras);
            return RedirectToAction(nameof(Transaction));
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

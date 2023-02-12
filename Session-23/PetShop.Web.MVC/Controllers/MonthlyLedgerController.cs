using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Context;
using PetShop.EF.Repository;
using PetShop.Model;

namespace PetShop.Web.MVC.Controllers {
    public class MonthlyLedgerController : Controller {

        private readonly EntityInterface<Transaction> _transactionRepo;
        private readonly EntityInterface<Customer> _customerRepo;
        private readonly EntityInterface<Employee> _employeeRepo;
        private readonly EntityInterface<Pet> _petRepo;
        private readonly EntityInterface<PetFood> _petFoodRepo;

        public MonthlyLedgerController(EntityInterface<Transaction> transactionRepo,
                                        EntityInterface<Customer> customerRepo,
                                        EntityInterface<Employee> employeeRepo,
                                        EntityInterface<Pet> petRepo,
                                        EntityInterface<PetFood> petFoodRepo) {

            _transactionRepo = transactionRepo;
            _customerRepo = customerRepo;
            _employeeRepo = employeeRepo;
            _petRepo = petRepo;
            _petFoodRepo = petFoodRepo;
        }


        // GET: MonthlyLedger
        public ActionResult MonthlyLedger() {

            var monthlyLedgers = new List<MonthlyLedger>();
            int rent = 2000;
            var transactions = _transactionRepo.GetAll().ToList();
            var employees = _employeeRepo.GetAll().ToList();
            var pets = _petRepo.GetAll().ToList();
            var petFoods = _petFoodRepo.GetAll().ToList();

            MonthlyLedger monthlyLedger = new MonthlyLedger();
            decimal totalIncomeFromPets = 0;
            decimal totalIncomeFromPetFoods = 0;
            decimal totalAmountOfSalarys = 0;
            decimal totalPetCost = 0;
            decimal totalPetFoodCost = 0;

            foreach (var pet in pets) {
                totalPetCost += pet.Cost;
            }

            foreach (var petFood in petFoods) {
                totalPetFoodCost += petFood.Cost;
            }


            foreach (var employee in employees) {
                totalAmountOfSalarys += employee.SalaryPerMonth;
            }

            foreach (var tras in transactions) {

                totalIncomeFromPets += tras.PetPrice;
                totalIncomeFromPetFoods += tras.PetFoodQty * tras.PetFoodPrice;
            }


            var groupedTransactions = transactions
                                      .GroupBy(trans => new { trans.Date.Year, trans.Date.Month })
                                      .Select(grouped => new MonthlyLedger {

                                          Year = grouped.Key.Year,
                                          Month = grouped.Key.Month,
                                          Income = grouped.Sum(tras => tras.PetPrice + tras.PetFoodQty * tras.PetFoodPrice),
                                          Expenses = totalPetCost + totalAmountOfSalarys + totalPetFoodCost + rent,
                                          Total = grouped.Sum(t => t.PetPrice + t.PetFoodQty * t.PetFoodPrice) - (totalPetCost + totalAmountOfSalarys + totalPetFoodCost)
                                      });
            monthlyLedgers.Add(monthlyLedger);
            return View(groupedTransactions);

        }

        // GET: MonthlyLedger/Details/5
        public ActionResult Details(int id) {
            return View();
        }

        // GET: MonthlyLedger/Create
        public ActionResult Create() {
            return View();
        }

        // POST: MonthlyLedger/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection) {
            try {
                return RedirectToAction(nameof(MonthlyLedger));
            } catch {
                return View();
            }
        }

        // GET: MonthlyLedger/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: MonthlyLedger/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }

        // GET: MonthlyLedger/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: MonthlyLedger/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repository;
using PetShop.Model;

namespace PetShop.Web.MVC.Controllers {
    public class CustomerController : Controller {

        private readonly EntityInterface<Customer> _customerRepo;

        public CustomerController(EntityInterface<Customer> customerRepo) {
                _customerRepo=customerRepo;
        }
        // GET: CustomerController
        public ActionResult Index() {
            var customers=_customerRepo.GetAll();
            return View(model:customers);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id) {
            return View();
        }

        // GET: CustomerController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: CustomerController/Delete/5
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

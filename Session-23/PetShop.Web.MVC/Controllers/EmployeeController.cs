using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repository;
using PetShop.Model;

namespace PetShop.Web.MVC.Controllers {
    public class EmployeeController : Controller {

        private readonly EntityInterface<Employee> _employeeRepo;

        public EmployeeController(EntityInterface<Employee> employeeRepo) {
            _employeeRepo = employeeRepo;
        }


        // GET: EmployeeController
        public ActionResult Index() {
            var employees=_employeeRepo.GetAll();
            return View(model:employees);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id) {
            return View();
        }

        // GET: EmployeeController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: EmployeeController/Delete/5
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

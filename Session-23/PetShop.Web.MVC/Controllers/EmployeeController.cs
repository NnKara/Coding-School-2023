using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repository;
using PetShop.Model;
using PetShop.Web.MVC.Models.CustomerDto;
using PetShop.Web.MVC.Models.EmployeeDto;

namespace PetShop.Web.MVC.Controllers {
    public class EmployeeController : Controller {

        private readonly EntityInterface<Employee> _employeeRepo;

        public EmployeeController(EntityInterface<Employee> employeeRepo) {
            _employeeRepo = employeeRepo;
        }


        // GET: EmployeeController
        public ActionResult Employee() {
            var employees=_employeeRepo.GetAll();
            return View(model:employees);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id) {
            if (id == null) {
                return NotFound();
            }

            var dbEmployee = _employeeRepo.GetByID(id);
            if (dbEmployee == null) {
                return NotFound();
            }

            var viewEmployee = new EmployeeDto {
                EmployeeID = dbEmployee.EmployeeID,
                EmployeeName = dbEmployee.EmployeeName,
                EmployeeSurname = dbEmployee.EmployeeSurname,
                EmployeeType=dbEmployee.EmployeeType,
                SalaryPerMonth= dbEmployee.SalaryPerMonth,
                Transactions = dbEmployee.Transactions.ToList()
            };
            return View(model: viewEmployee);
        }

        // GET: EmployeeController/Create
        public ActionResult Create() {
            var employee = new Employee();
            var employees = _employeeRepo.GetAll();
            return View(model: employee);
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee) {

            //if (!ModelState.IsValid) {
            //    return View();
            //}

            var dbEmployee = new Employee(employee.EmployeeName, employee.EmployeeSurname, employee.EmployeeType, employee.SalaryPerMonth);
            _employeeRepo.Add(dbEmployee);
            return RedirectToAction("Employee");
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
                return RedirectToAction(nameof(Employee));
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
                return RedirectToAction(nameof(Employee));
            } catch {
                return View();
            }
        }
    }
}

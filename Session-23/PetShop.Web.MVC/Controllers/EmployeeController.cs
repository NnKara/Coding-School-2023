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
            var employee = new EmployeeCreateDto();
            var employees = _employeeRepo.GetAll();
            return View(model: employee);
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeCreateDto employee) {

            if (!ModelState.IsValid) {
                return View();
            }

            var dbEmployee = new Employee(employee.EmployeeName, employee.EmployeeSurname, employee.EmployeeType, employee.SalaryPerMonth);
            _employeeRepo.Add(dbEmployee);
            return RedirectToAction("Employee");
        }




        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id) {
            var dbEmployee = _employeeRepo.GetByID(id);
            if (dbEmployee == null) {
                return NotFound();
            }

            var viewEmployee = new EmployeeDtoEdit {
                EmployeeName=dbEmployee.EmployeeName,
                EmployeeSurname=dbEmployee.EmployeeSurname,
                EmployeeType=dbEmployee.EmployeeType,
                SalaryPerMonth=dbEmployee.SalaryPerMonth,
                EmployeeID=dbEmployee.EmployeeID
               
            };
            return View(model: viewEmployee);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, EmployeeDtoEdit employee) {
            if (!ModelState.IsValid) {
                return View();
            }

            var dbEmployee = _employeeRepo.GetByID(id);
            if (dbEmployee == null) {
                return NotFound();
            }

            dbEmployee.EmployeeSurname = employee.EmployeeSurname;
            dbEmployee.EmployeeName = employee.EmployeeName;
            dbEmployee.SalaryPerMonth = employee.SalaryPerMonth;
            dbEmployee.EmployeeType = employee.EmployeeType;
            _employeeRepo.Update(id, dbEmployee);
            return RedirectToAction(nameof(Employee));
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id) {
            var dbEmployee = _employeeRepo.GetByID(id);
            if (dbEmployee == null) {
                return NotFound();
            }

            var viewEmployee = new EmployeeDtoDelete {
                EmployeeName=dbEmployee.EmployeeName,
                EmployeeSurname=dbEmployee.EmployeeSurname,
                EmployeeType=dbEmployee.EmployeeType,
                SalaryPerMonth=dbEmployee.SalaryPerMonth,
                EmployeeID=dbEmployee.EmployeeID              
            };
            return View(model: viewEmployee);
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            _employeeRepo.Delete(id);
            return RedirectToAction(nameof(Employee));
        }
    }
}

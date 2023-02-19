using FuelStation.EF.Repositorys;
using FuelStation.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Session_30.Shared.CustomerDto;
using Session_30.Shared.EmployeeDto;

namespace Session_30.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
public class EmployeeController : ControllerBase {

        private readonly IEntityRepo<Employee> _employeeRepo;

        public EmployeeController(IEntityRepo<Employee> employeeRepo) {
            _employeeRepo= employeeRepo;
        }


        
        [HttpGet]
        public async Task<IEnumerable<EmployeeListDto>> Get() {
            var result = _employeeRepo.GetAll();
            return result.Select(x => new EmployeeListDto {
                EmployeeID = x.EmployeeID,
                EmployeeName = x.EmployeeName,
                EmployeeSurname = x.EmployeeSurname,
                SalaryPerMonth = x.SalaryPerMonth,
                HireDateEnd= x.HireDateEnd,
                HireDateStart= x.HireDateStart,
                EmployeeType= x.EmployeeType
            });
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeEditDto>> GetById(int id) {
            var result = _employeeRepo.GetByID(id);

            if (result == null) {
                return NotFound();
            }

            return new EmployeeEditDto {
                EmployeeID = id,
                EmployeeName = result.EmployeeName,
                EmployeeSurname = result.EmployeeSurname,
                SalaryPerMonth = result.SalaryPerMonth,
                HireDateStart= result.HireDateStart,
                HireDateEnd= result.HireDateEnd,
                EmployeeType= result.EmployeeType
            };
        }

        [HttpPost]
        public async Task<IActionResult> Post(EmployeeEditDto employee) { 

            var newEmployee = new Employee(employee.EmployeeName,employee.EmployeeSurname,employee.SalaryPerMonth
                                            ,employee.HireDateStart,employee.HireDateEnd,employee.EmployeeType);
            _employeeRepo.Add(newEmployee);

            return Ok();

        }

        [HttpPut]
        public async Task<IActionResult> Put(EmployeeEditDto employee) {
            var itemToUpdate = _employeeRepo.GetByID(employee.EmployeeID);

            if (itemToUpdate == null) {
                return NotFound();
            }

            itemToUpdate.EmployeeName = employee.EmployeeName;
            itemToUpdate.EmployeeSurname = employee.EmployeeSurname;
            itemToUpdate.SalaryPerMonth = employee.SalaryPerMonth;
            itemToUpdate.HireDateStart= employee.HireDateStart;
            itemToUpdate.HireDateEnd= employee.HireDateEnd;
            itemToUpdate.EmployeeType = employee.EmployeeType;
            _employeeRepo.Update(employee.EmployeeID, itemToUpdate);

            return Ok();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) {
            var itemToDelete = _employeeRepo.GetByID(id);

            if (itemToDelete == null) {
                return NotFound(); 
            }

            _employeeRepo.Delete(id);

            return Ok(); 
        }


    }
}

using FuelStation.EF.Repositorys;
using FuelStation.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Session_30.Shared;
using Session_30.Shared.CustomerDto;
using Session_30.Shared.EmployeeDto;
using Session_30.Shared.Validator;
using System.Data.Common;

namespace Session_30.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IValidator _validator;
        public string? errorMessage = String.Empty;

        public EmployeeController(IEntityRepo<Employee> employeeRepo, IValidator validator)
        {
            _employeeRepo = employeeRepo;
            _validator = validator;
        }



        [HttpGet]
        public async Task<IEnumerable<EmployeeListDto>> Get()
        {
            var result = _employeeRepo.GetAll();
            return result.Select(x => new EmployeeListDto
            {
                EmployeeID = x.EmployeeID,
                EmployeeName = x.EmployeeName,
                EmployeeSurname = x.EmployeeSurname,
                SalaryPerMonth = x.SalaryPerMonth,
                HireDateEnd = x.HireDateEnd,
                HireDateStart = x.HireDateStart,
                EmployeeType = x.EmployeeType
            });
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeEditDto>> GetById(int id)
        {
            var result = _employeeRepo.GetByID(id);

            if (result == null)
            {
                return NotFound();
            }

            return new EmployeeEditDto
            {
                EmployeeID = id,
                EmployeeName = result.EmployeeName,
                EmployeeSurname = result.EmployeeSurname,
                SalaryPerMonth = result.SalaryPerMonth,
                HireDateStart = result.HireDateStart,
                HireDateEnd = result.HireDateEnd,
                EmployeeType = result.EmployeeType,
                Transactions = result.Transactions.Select(t => new TransactionListDto {
                    TransactionID = t.TransactionID,
                    Date = t.Date,
                    PaymentMethod = t.PaymentMethod,
                    TotalValue = t.TotalValue,
                    EmployeeID = t.EmployeeID,
                    CustomerID = t.CustomerID,
                }).ToList()                  
            };
        }

        [HttpPost]
        public async Task<IActionResult> Post(EmployeeEditDto employee)
        {

            var newEmployee = new Employee(employee.EmployeeName, employee.EmployeeSurname, employee.SalaryPerMonth
                                            , employee.HireDateStart, employee.HireDateEnd, employee.EmployeeType);
            var employees = _employeeRepo.GetAll().ToList();
            if (_validator.ValidateAddEmployee(newEmployee, newEmployee.EmployeeType, employees, out errorMessage))
            {
                try
                {
                    _employeeRepo.Add(newEmployee);

                }
                catch (DbException ex)
                {
                    return BadRequest(ex.Message);
                }
                return Ok();
            }
            return BadRequest(errorMessage);
        }


        [HttpPut]
        public async Task<IActionResult> Put(EmployeeEditDto employee)
        {
            var dbEmployee = _employeeRepo.GetByID(employee.EmployeeID);
            if (dbEmployee == null)
            {
                return BadRequest($"Employee not found");
            }
            else if (_validator.ValidateUpdateEmployee(employee.EmployeeType, dbEmployee, _employeeRepo.GetAll().ToList(), out errorMessage))
            {
                dbEmployee.EmployeeName = employee.EmployeeName;
                dbEmployee.EmployeeSurname = employee.EmployeeSurname;
                dbEmployee.SalaryPerMonth = employee.SalaryPerMonth;
                dbEmployee.EmployeeType = employee.EmployeeType;
                dbEmployee.HireDateStart = employee.HireDateStart;
                dbEmployee.HireDateEnd = employee.HireDateStart;
                try
                {
                    _employeeRepo.Update(employee.EmployeeID, dbEmployee);
                }
                catch (DbUpdateException ex)
                {
                    return BadRequest(ex.Message);
                }
                return Ok();
            }
            else
            {
                return BadRequest(errorMessage);
            }
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var employees = _employeeRepo.GetAll().ToList();
            var dbEmployee = employees.Where(emp => emp.EmployeeID == id).Single();
            if (_validator.ValidateDeleteEmployee(dbEmployee.EmployeeType, employees, out errorMessage) && _validator.HasEmployeeTransaction(dbEmployee, out errorMessage))
            {
                    _employeeRepo.Delete(id);
                    return Ok();
             }

                return BadRequest(errorMessage);
        }

    }
}

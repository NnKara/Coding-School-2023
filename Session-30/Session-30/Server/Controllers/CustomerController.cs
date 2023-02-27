using FuelStation.EF.Context;
using FuelStation.EF.Repositorys;
using FuelStation.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Session_30.Shared;
using Session_30.Shared.CustomerDto;
using Session_30.Shared.EmployeeDto;
using Session_30.Shared.TransactionDto;
using Session_30.Shared.Validator;
using System.Data;
using System.Data.Common;

namespace Session_30.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomer<Customer> _customerRepo;
        private readonly IValidator _validator;
        private string? _errorMessage;

        public CustomerController(ICustomer<Customer> customerRepo, IValidator validator)
        {
            _customerRepo = customerRepo;
            _validator = validator;
        }

        [HttpGet]
        public async Task<IEnumerable<CustomerListDto>> Get()
        {
            var result = _customerRepo.GetAll().ToList();
            return result.Select(x => new CustomerListDto
            {
                CustomerID = x.CustomerID,
                CustomerName = x.CustomerName,
                CustomerSurname = x.CustomerSurname,
                CardNumber = x.CardNumber
            });
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerEditDto>> GetById(int id)
        {
            var result = _customerRepo.GetByID(id);
            if (result == null)
            {
                return NotFound("Customer not found!");
            }
            return new CustomerEditDto
            {
                CustomerID = id,
                CustomerName = result.CustomerName,
                CustomerSurname = result.CustomerSurname,
                CardNumber = result.CardNumber,
                Transactions = result.Transactions.Select(t => new TransactionListDto
                {
                    TransactionID = t.TransactionID,
                    Date = t.Date,
                    PaymentMethod = t.PaymentMethod,
                    TotalValue = t.TotalValue,
                    EmployeeID = t.EmployeeID,
                    CustomerID = t.CustomerID,
                }).ToList()
            };
        }

        [Route("/customerTransaction/details/{id}")]
        public async Task<ActionResult<CustomerDetailsDto>> GetByIdDetails(int id)
        {
            try
            {
                var result = _customerRepo.GetByID(id);
                if (result == null)
                {
                    return NotFound("Customer not found!");
                }
                var customerDetails=new CustomerDetailsDto
                {
                    CustomerID = id,
                    CustomerName = result.CustomerName,
                    CustomerSurname = result.CustomerSurname,
                    CardNumber = result.CardNumber,                    
                    Transactions = result.Transactions.Select(t=>new TransactionDetailsDto
                    {
                        Date = t.Date,
                        PaymentMethod = t.PaymentMethod,
                        TotalValue = t.TotalValue,
                        TransactionID=t.TransactionID,
                        Employee = new EmployeeDetailsDto
                        {
                            EmployeeID = t.Employee.EmployeeID,
                            EmployeeName = t.Employee.EmployeeName,
                            EmployeeSurname = t.Employee.EmployeeSurname
                        }
                    }).ToList()
                   
                };
                return customerDetails;
            }
            catch (DbException)
            {
                return NotFound("Customer not found!");
            }
        }


        [Route("/cardNumber/{cardNumber}")]
        [HttpGet]
        public async Task<ActionResult<CustomerListDto>> GetByCardNumber(string cardNumber)
        {
            var fuelDb = new FuelStasionDbContext();
            var dbCustomer = await _customerRepo.FindCustomerByCardNumber(cardNumber);
            if (dbCustomer == null)
            {
                return NotFound();
            }
            var customer = new CustomerListDto();
            customer.CustomerID = dbCustomer.CustomerID;
            customer.CustomerName = dbCustomer.CustomerName;
            customer.CustomerSurname = dbCustomer.CustomerSurname;
            customer.CardNumber = dbCustomer.CardNumber;

            return customer;
        }



        [HttpPost]
        public async Task<IActionResult> Post(CustomerEditDto customer)
        {

            var newCustomer = new Customer(customer.CustomerName, customer.CustomerSurname);
            _customerRepo.Add(newCustomer);

            return Ok();

        }

        [HttpPut]
        public async Task<IActionResult> Put(CustomerEditDto customer)
        {
            var itemToUpdate = _customerRepo.GetByID(customer.CustomerID);

            if (itemToUpdate == null)
            {
                return NotFound();
            }

            itemToUpdate.CustomerName = customer.CustomerName;
            itemToUpdate.CustomerSurname = customer.CustomerSurname;
            itemToUpdate.CardNumber = customer.CardNumber;
            _customerRepo.Update(customer.CustomerID, itemToUpdate);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var dbCustomer = _customerRepo.GetByID(id);
            try
            {
                if (dbCustomer == null)
                {
                    return NotFound();
                }
                if (_validator.ValidateDeleteCustomer(dbCustomer, out _errorMessage))
                {
                    _customerRepo.Delete(id);
                    return Ok();
                }
                else
                {
                    return BadRequest(_errorMessage);
                }
            }
            catch (DbException)
            {
                return BadRequest($"Could not delete Customer because it has Transactions");
            }

        }
    }
}

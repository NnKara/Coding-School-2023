using FuelStation.EF.Repositorys;
using FuelStation.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Session_30.Shared;
using Session_30.Shared.CustomerDto;
using Session_30.Shared.Validator;

namespace Session_30.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
public class CustomerController : ControllerBase {

        private readonly ICustomer<Customer> _customerRepo;
        private readonly IValidator _validator;
        private string? _errorMessage;

        public CustomerController(ICustomer<Customer> customerRepo,IValidator validator) {
            _customerRepo = customerRepo;
            _validator = validator;
        }

        [HttpGet]
        public async Task<IEnumerable<CustomerListDto>> Get() {
            var result=_customerRepo.GetAll().ToList();
            return result.Select(x => new CustomerListDto {
                CustomerID= x.CustomerID,
                CustomerName= x.CustomerName,
                CustomerSurname= x.CustomerSurname,
                CardNumber= x.CardNumber
            });
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerEditDto>> GetById(int id) {
            var result = _customerRepo.GetByID(id);
            if (result == null) {
                return NotFound();
            }
            return new CustomerEditDto {
             CustomerID=id,
             CustomerName=result.CustomerName,
             CustomerSurname=result.CustomerSurname,
             CardNumber=result.CardNumber
            };
        }

        [Route("/cardNumber/{cardNumber}")]
        [HttpGet]
        public async Task<ActionResult<CustomerListDto>> GetByCardNumber(string cardNumber) {
            var result = _customerRepo.FindCustomerByCardNumber(cardNumber);
            if (result == null) {
                return NotFound();
            }
            return new CustomerListDto {
                CustomerID=result.CustomerID,
                CustomerName = result.CustomerName,
                CustomerSurname = result.CustomerSurname,
                CardNumber = result.CardNumber,
                Transactions = result.Transactions
            };
        }



        [HttpPost]
        public async Task<IActionResult> Post(CustomerEditDto customer) {

            var newCustomer = new Customer(customer.CustomerName, customer.CustomerSurname);
            _customerRepo.Add(newCustomer);

            return Ok();

        }

        [HttpPut]
        public async Task<IActionResult> Put(CustomerEditDto customer) {
            var itemToUpdate = _customerRepo.GetByID(customer.CustomerID);

            if (itemToUpdate == null) {
                return NotFound(); 
            }

            itemToUpdate.CustomerName = customer.CustomerName;
            itemToUpdate.CustomerSurname = customer.CustomerSurname;   
            itemToUpdate.CardNumber = customer.CardNumber;    
            _customerRepo.Update(customer.CustomerID, itemToUpdate);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) {
            var itemToDelete = _customerRepo.GetByID(id);

            if (itemToDelete == null) {
                return NotFound(); 
            }

            _customerRepo.Delete(id);

            return Ok(); 
        }

    }
}

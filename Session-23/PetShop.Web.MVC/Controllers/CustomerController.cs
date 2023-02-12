using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repository;
using PetShop.Model;
using PetShop.Web.MVC.Models.CustomerDto;

namespace PetShop.Web.MVC.Controllers {
    public class CustomerController : Controller {

        private readonly EntityInterface<Customer> _customerRepo;

        public CustomerController(EntityInterface<Customer> customerRepo) {
                _customerRepo=customerRepo;
        }
        // GET: CustomerController
        public ActionResult Customer() {
            var customers=_customerRepo.GetAll();
            return View(model:customers);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id) {


            

            var dbCustomer = _customerRepo.GetByID(id);
            if (dbCustomer == null) {
                return NotFound();
            }

            var viewCustomer = new CustomerDto {
                CustomerDtoID = dbCustomer.CustomerID,
                CustomerDtoName = dbCustomer.CustomerName,
                CustomerDtoSurname = dbCustomer.CustomerSurname,
                PhoneDto = dbCustomer.Phone,
                TINDto = dbCustomer.TIN,
                Transactions = dbCustomer.Transactions.ToList()
            };
            return View(model: viewCustomer);
        }

        // GET: CustomerController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerDtoCreate customer) {

            if (!ModelState.IsValid) {
                return View();
            }

            var dbCustomer = new Customer(customer.CustomerDtoName,
                customer.CustomerDtoSurname,
                customer.PhoneDto,
                customer.TINDto);
    
            _customerRepo.Add(dbCustomer);
            return RedirectToAction("Customer");
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id) {
            var dbCustomer = _customerRepo.GetByID(id);

                if (dbCustomer == null) {
                    return NotFound();
                }

                var viewCustomer = new CustomerDtoEdit {
                    CustomerDtoName = dbCustomer.CustomerName,
                    CustomerDtoSurname = dbCustomer.CustomerSurname,
                    PhoneDto = dbCustomer.Phone,
                    TINDto = dbCustomer.TIN,
                    CustomerDtoID = dbCustomer.CustomerID
                };
                return View(model: viewCustomer);
            
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,CustomerDto customerDto) {

            if (!ModelState.IsValid) {
                return View();
            }
            var dbCustomer = _customerRepo.GetByID(id);
           

            if (dbCustomer == null) {
                return NotFound();
            }
            dbCustomer.CustomerName = customerDto.CustomerDtoName;
            dbCustomer.CustomerSurname = customerDto.CustomerDtoSurname;
            dbCustomer.Phone = customerDto.PhoneDto;
            dbCustomer.TIN = customerDto.TINDto;
            _customerRepo.Update(id, dbCustomer);
            return RedirectToAction(nameof(Customer));
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id) {

            var dbCustomer = _customerRepo.GetByID(id);
            if (dbCustomer == null) {
                return NotFound();
            }

            var viewCustomer = new CustomerDtoDelete {
                CustomerDtoName = dbCustomer.CustomerName,
                CustomerDtoSurname = dbCustomer.CustomerSurname,
                PhoneDto = dbCustomer.Phone,
                TINDto = dbCustomer.TIN,
               CustomerDtoID = dbCustomer.CustomerID
            };
            return View(model: viewCustomer);
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
      
                _customerRepo.Delete(id);
                return RedirectToAction(nameof(Customer));
            }
        }
    }


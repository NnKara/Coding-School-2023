using PetShop.EF.Context;
using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Repository {
    public class CustomerRepo : EntityInterface<Customer> {

        public void Add(Customer entity) {
            using var petShopDbContext = new PetShopDbContext();
            var existingCustomer = petShopDbContext.Customers.FirstOrDefault(customer => customer.CustomerSurname == entity.CustomerSurname);
            if(existingCustomer != null) {
                petShopDbContext.Add(entity);
                petShopDbContext.SaveChanges();
            }
        }

        public void Delete(int id) {
            using var petShopContext= new PetShopDbContext();
            var dbCustomer = petShopContext.Customers.Where(customer => customer.CustomerID == id).SingleOrDefault();
            if (dbCustomer is null)
                return;
            petShopContext.Remove(dbCustomer);
            petShopContext.SaveChanges();
        }

        public IList<Customer> GetAll() {
            using var petShopContext = new PetShopDbContext();
            return petShopContext.Customers.ToList();
        }

        public Customer? GetByID(int id) {
            using var petShopContext = new PetShopDbContext();
            return petShopContext.Customers.Where(customer => customer.CustomerID == id).SingleOrDefault();
        }

        public void Update(int id, Customer entity) {
            using var petShopContext = new PetShopDbContext();
            var dbCustomer=petShopContext.Customers.Where(customer=>customer.CustomerID==id).SingleOrDefault();
            if(dbCustomer is null)
                return;
            dbCustomer.CustomerName=entity.CustomerName;
            dbCustomer.CustomerSurname=entity.CustomerSurname;
            dbCustomer.Phone=entity.Phone;
            dbCustomer.TIN=entity.TIN;
            petShopContext.SaveChanges();
        }
    }
}

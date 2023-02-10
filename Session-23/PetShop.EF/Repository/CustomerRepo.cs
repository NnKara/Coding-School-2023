using Microsoft.EntityFrameworkCore;
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

            if (entity.CustomerID != 0) {
                throw new ArgumentException("Given entity should not have ID set", nameof(entity));
            }          
                petShopDbContext.Add(entity);
                petShopDbContext.SaveChanges();           
        }

        public void Delete(int id) {
            using var petShopContext= new PetShopDbContext();
            var dbCustomer = petShopContext.Customers.Where(customer => customer.CustomerID == id).SingleOrDefault();
            if (dbCustomer is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            petShopContext.Customers.Remove(dbCustomer);
            petShopContext.SaveChanges();
        }

        public IList<Customer> GetAll() {
            using var petShopContext = new PetShopDbContext();
            return petShopContext.Customers.ToList();
        }

        public Customer? GetByID(int id) {
            using var petShopContext = new PetShopDbContext();
            var dbCustomer = petShopContext.Customers.Where(customer => customer.CustomerID == id).SingleOrDefault();
            if (dbCustomer is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            } else {
                return dbCustomer;
            }
        }

        public void Update(int id, Customer entity) {
            using var petShopContext = new PetShopDbContext();
            var dbCustomer=petShopContext.Customers.Where(customer=>customer.CustomerID==id).SingleOrDefault();
            if (dbCustomer is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            dbCustomer.CustomerName=entity.CustomerName;
            dbCustomer.CustomerSurname=entity.CustomerSurname;
            dbCustomer.Phone=entity.Phone;
            dbCustomer.TIN=entity.TIN;
            petShopContext.SaveChanges();
        }
    }
}

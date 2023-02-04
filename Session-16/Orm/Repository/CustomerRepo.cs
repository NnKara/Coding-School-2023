using Microsoft.EntityFrameworkCore;
using Model;
using Orm.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Repository
{
    public class CustomerRepo : EntityInterface<Customer>
    {
        public void Add(Customer entity)
        {
            using var petShopContext = new PetShopContext();
            var existingPet = petShopContext.Customers.FirstOrDefault(customer => customer.CustomerSurname == entity.CustomerSurname);
            if (existingPet == null) {
                petShopContext.Add(entity);
                petShopContext.SaveChanges();
            }
        }

        public void Delete(Guid id)
        {
            using var petShopContext=new PetShopContext();
            var dbCustomer = petShopContext.Customers.Where(customer => customer.CustomerID == id).SingleOrDefault();
            if(dbCustomer is null)           
                return;
            petShopContext.Remove(dbCustomer);
            petShopContext.SaveChanges();
            
        }

        public IList<Customer> GetAll()
        {
            using var petShopContext = new PetShopContext();
            return petShopContext.Customers.ToList();
                
        }

        public Customer? GetById(Guid id)
        {
            using var petShopContext = new PetShopContext();
            return petShopContext.Customers.Where(customer=>customer.CustomerID==id).SingleOrDefault();

        }

        public void Update(Guid id, Customer entity)
        {
            using var petShopContext = new PetShopContext();
            var dbCustomer=petShopContext.Customers.Where(customer=>customer.CustomerID==id).SingleOrDefault(); 
            if(dbCustomer is null)
                return;
            dbCustomer.CustomerName = entity.CustomerName;
            dbCustomer.CustomerSurname=entity.CustomerSurname;
            dbCustomer.Phone= entity.Phone;
            dbCustomer.TIN=entity.TIN;
            petShopContext.SaveChanges();
        }
    }
}

using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositorys {
    public class CustomerRepo : ICustomer<Customer> {
        public void Add(Customer entity) {
            using var fuelDb = new FuelStasionDbContext();


            if (entity.CustomerID != 0) {
                throw new ArgumentException("Given entity should not have ID set", nameof(entity));
            }
            fuelDb.Add(entity);
            fuelDb.SaveChanges();
        }

        public void Delete(int id) {
            using var fuelDb = new FuelStasionDbContext();
            var dbCustomer = fuelDb.Customers.Where(customer => customer.CustomerID == id).SingleOrDefault();
            if (dbCustomer is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            var transactions = fuelDb.Transactions.Where(t => t.CustomerID == id).ToList();
            if (transactions.Any()) {
                throw new Exception("Cannot delete customer who has associated transactions. Please delete the transactions first.");
            }
            fuelDb.Customers.Remove(dbCustomer);
            fuelDb.SaveChanges();
        }


        public IList<Customer> GetAll() {
            using var fuelDb = new FuelStasionDbContext();
            return fuelDb.Customers.Include(cust=>cust.Transactions).ToList();
        }

        public Customer? GetByID(int id) {
            using var fuelDb = new FuelStasionDbContext();

            var dbCustomer = fuelDb.Customers
                 .Include(c => c.Transactions)
                  .ThenInclude(t => t.TransactionLines)
                 .FirstOrDefault(c => c.CustomerID == id);

            if (dbCustomer is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            } else {
                return dbCustomer;
            }
        }

        public void Update(int id, Customer entity) {
            using var fuelDb = new FuelStasionDbContext();
            var dbCustomer = fuelDb.Customers.FirstOrDefault(c => c.CustomerID == id);
            if (dbCustomer is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            dbCustomer.CustomerName = entity.CustomerName;
            dbCustomer.CustomerSurname = entity.CustomerSurname;
            dbCustomer.CardNumber = entity.CardNumber;

            fuelDb.SaveChanges();
        }



        public async Task<Customer?> FindCustomerByCardNumber(string cardNumber) {
            var fuelDb = new FuelStasionDbContext();
            var dbCustomer = await fuelDb.Customers
                .Where(c => c.CardNumber == cardNumber)
                .Include(c => c.Transactions).FirstOrDefaultAsync();
            if(dbCustomer is null) {
                throw new KeyNotFoundException($"Given Card-Number '{cardNumber}' was not found in Database");
            }
            return dbCustomer;
        }
    }
}



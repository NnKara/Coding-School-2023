using Microsoft.EntityFrameworkCore;
using PetShop.EF.Context;
using PetShop.Model;
using System;
using System.Linq;


namespace PetShop.EF.Repository {
    public class TransactionRepo : EntityInterface<Transaction> {
        public void Add(Transaction entity) {
            using var petShopContext = new PetShopDbContext();
            if (entity.TransactionID != 0) {
                throw new ArgumentException("Given entity should not have ID set", nameof(entity));
            }
            petShopContext.Add(entity);
            petShopContext.SaveChanges();
        }

        public void Delete(int id) {
            using var petShopContext = new PetShopDbContext();
            var dbTransaction = petShopContext.Transactions.Where(transaction => transaction.TransactionID == id).SingleOrDefault();
            if (dbTransaction is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            petShopContext.Remove(dbTransaction);
            petShopContext.SaveChanges();
        }

        public IList<Transaction> GetAll() {
            using var petShopContext = new PetShopDbContext();
            return petShopContext.Transactions.Include(t => t.Customer).Include(t => t.Employee).Include(t => t.Pet)
                .Include(t => t.PetFood).ToList();
        }

        public Transaction? GetByID(int id) {
            using var petShopContext = new PetShopDbContext();
            return petShopContext.Transactions
                                 .Include(transaction => transaction.Customer)
                                 .Include(transaction => transaction.Employee)
                                 .Include(transaction => transaction.Pet)
                                 .Include(transaction => transaction.PetFood)
                                 .Where(transaction => transaction.TransactionID == id)
                                 .SingleOrDefault();

        }

        public void Update(int id, Transaction entity) {
            using var petShopContext = new PetShopDbContext();
            var dbTransaction = petShopContext.Transactions.Where(transaction => transaction.TransactionID == id).SingleOrDefault();
            if (dbTransaction is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            dbTransaction.CustomerID = entity.CustomerID;
            dbTransaction.EmployeeID = entity.EmployeeID;
            dbTransaction.PetID = entity.PetID;
            dbTransaction.PetFoodID = entity.PetFoodID;
            dbTransaction.Date = entity.Date;
            dbTransaction.TotalPrice = entity.TotalPrice;
            dbTransaction.PetPrice = entity.PetPrice;
            dbTransaction.PetFoodQty = entity.PetFoodQty;
            dbTransaction.TotalPrice = entity.TotalPrice;
            petShopContext.SaveChanges();
        }


    }
}

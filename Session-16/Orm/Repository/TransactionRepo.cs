using Model;
using Orm.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Repository
{
    public class TransactionRepo : EntityInterface<Transaction>
    {
        public void Add(Transaction entity)
        {
            using var petShopContext = new PetShopContext();
            petShopContext.Add(entity);
            petShopContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            using var petShopContext = new PetShopContext();
            var dbTransaction = petShopContext.Transactions.Where(transaction => transaction.TransactionID == id).SingleOrDefault();
            if (dbTransaction is null)
                return;
            petShopContext.Remove(dbTransaction);
            petShopContext.SaveChanges();
        }

        public IList<Transaction> GetAll()
        {
            using var petShopContext = new PetShopContext();
            return petShopContext.Transactions.ToList();
        }

        public Transaction? GetById(Guid id)
        {
            using var petShopContext = new PetShopContext();
            return petShopContext.Transactions.SingleOrDefault();
        }

        public void Update(Guid id, Transaction entity)
        {
            using var petShopContext = new PetShopContext();
            var dbTransaction = petShopContext.Transactions.Where(transaction => transaction.TransactionID == id).SingleOrDefault();
            if (dbTransaction is null)
                return;
            dbTransaction.Customer = entity.Customer;
            dbTransaction.TransactionDate = entity.TransactionDate;
            dbTransaction.TotalPrice = entity.TotalPrice;
            dbTransaction.Employee = entity.Employee;
            dbTransaction.Pet = entity.Pet;
            dbTransaction.PetPrice = entity.PetPrice;
            dbTransaction.PetFoodQty = entity.PetFoodQty;
            //dbTransaction.PetFood = entity.PetFood;
            dbTransaction.TotalPrice = entity.TotalPrice;
            petShopContext.SaveChanges();
        }
    }
}

﻿using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositorys {
    public class TransactionRepo : ITransactionRepo<Transaction> {
        public void Add(Transaction entity) {
            using var fuelDbContext = new FuelStasionDbContext();
            if (entity.TransactionID != 0)
            {
                throw new ArgumentException("Given entity should not have ID set", nameof(entity));
            }
            fuelDbContext.Add(entity);
            fuelDbContext.SaveChanges();
            
        }

        public void Delete(int id) {
            using var fuelDbContext = new FuelStasionDbContext();
            var dbTransaction = fuelDbContext.Transactions.Where(transaction => transaction.TransactionID == id).SingleOrDefault();
            if (dbTransaction is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            fuelDbContext.Remove(dbTransaction);
            fuelDbContext.SaveChanges();
        }

        public IList<Transaction> GetAll() {
            using var fuelDb = new FuelStasionDbContext();
            return fuelDb.Transactions.Include(t => t.Customer).Include(t => t.Employee).Include(t => t.TransactionLines).ThenInclude(trasLines=>trasLines.Item).ToList();
        }

        public Transaction? GetByID(int id) {
            using var fuelDb = new FuelStasionDbContext();
            return fuelDb.Transactions
                                 .Where(transaction => transaction.TransactionID == id)
                                 .Include(transaction => transaction.Customer)
                                 .Include(transaction => transaction.Employee)
                                 .Include(transaction => transaction.TransactionLines)                                
                                 .SingleOrDefault();
        }

        public void Update(int id, Transaction entity) {
            using var fuelDb = new FuelStasionDbContext();
            var dbTransaction = fuelDb.Transactions.Where(transaction => transaction.TransactionID == id).SingleOrDefault();
            if (dbTransaction is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            
            dbTransaction.CustomerID = entity.CustomerID;
            dbTransaction.EmployeeID = entity.EmployeeID;
            dbTransaction.Date = entity.Date;
            dbTransaction.PaymentMethod = entity.PaymentMethod;
            dbTransaction.TotalValue= entity.TotalValue;
            dbTransaction.TransactionLines = entity.TransactionLines;
            fuelDb.SaveChanges();
        }


        public IList<Transaction> GetCustomerTransactions(int id) {
            using var context = new FuelStasionDbContext();
            return context.Transactions
                .Where(transaction => transaction.CustomerID == id)
                .Include(transaction => transaction.TransactionLines)
                .ThenInclude(transactionLines => transactionLines.Item)
                .ToList();
        }
    }
}

using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositorys {
    public class ItemRepo : IEntityRepo<Item> {
        public void Add(Item entity) {
            using var fuelDb = new FuelStasionDbContext();


            if (entity.ItemID != 0) {
                throw new ArgumentException("Given entity should not have ID set", nameof(entity));
            }
            fuelDb.Add(entity);
            fuelDb.SaveChanges();
        }

        public void Delete(int id) {
            using var fuelDb = new FuelStasionDbContext();
            var dbItem = fuelDb.Items.Where(item => item.ItemID == id).SingleOrDefault();
            if (dbItem is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            var transactionLines = fuelDb.TransactionLines.Where(t => t.ItemID == id).ToList();
            if (transactionLines.Any()) {
                throw new Exception("Cannot delete item who has associated transaction lines. Please delete the transaction lines first.");
            }
            fuelDb.Remove(dbItem);
            fuelDb.SaveChanges();
        }

        public IList<Item> GetAll() {
            using var fuelDb = new FuelStasionDbContext();
            return fuelDb.Items.ToList();
        }

        public Item? GetByID(int id) {
            using var fuelDb = new FuelStasionDbContext();
            return fuelDb.Items
                .Include(i => i.TransactionLines)
                .FirstOrDefault(i => i.ItemID == id);
        }

        public void Update(int id, Item entity) {
            using var fuelDb = new FuelStasionDbContext();
            var existingItem = fuelDb.Items.Include(i => i.TransactionLines).FirstOrDefault(i => i.ItemID == id);
            if (existingItem != null) {
                existingItem.Code = entity.Code;
                existingItem.Description = entity.Description;
                existingItem.ItemType = entity.ItemType;
                existingItem.Cost = entity.Cost;
                existingItem.Price = entity.Price;
                existingItem.TransactionLines = entity.TransactionLines;

                fuelDb.SaveChanges();
            } else {
                throw new Exception("Item not found");
            }
        }
    }
}

using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositorys {
    public class TransactionLineRepo : IEntityRepo<TransactionLine> {

        public void Add(TransactionLine entity) {
            using var fueDb = new FuelStasionDbContext();
            fueDb.Add(entity);
            fueDb.SaveChanges();
        }

        public void Delete(int id) {
            using var fuelDb = new FuelStasionDbContext();
            var trasLine = fuelDb.TransactionLines.Where(transactionline => transactionline.TransactionLineID == id).SingleOrDefault();
            if (trasLine is null)
                return;
            fuelDb.Remove(trasLine);
            fuelDb.SaveChanges();
        }


        public IList<TransactionLine> GetAll() {
            using var fuelDb = new FuelStasionDbContext();
            return fuelDb.TransactionLines
                        .Include(tl => tl.Transaction)
                        //.Include(tl=>tl.TransactionID)
                        .Include(tl => tl.Item)
                        .ToList();

        }

        public void Update(int id, TransactionLine entity) {
            using var fuelDb = new FuelStasionDbContext();
            var transactionLine = fuelDb.TransactionLines.FirstOrDefault(tl => tl.TransactionLineID == entity.TransactionLineID);
            if (transactionLine == null) {
                throw new ArgumentException("TransactionLine not found");
            }

            transactionLine.Quantity = entity.Quantity;
            transactionLine.ItemPrice = entity.ItemPrice;
            transactionLine.NetValue = entity.NetValue;
            transactionLine.DiscountPercent = entity.DiscountPercent;
            transactionLine.DiscountValue = entity.DiscountValue;
            transactionLine.TotalValue = entity.TotalValue;

            fuelDb.SaveChanges();
        }

        TransactionLine? IEntityRepo<TransactionLine>.GetByID(int id) {
            using var dbFuel = new FuelStasionDbContext();
            return dbFuel.TransactionLines
                .Include(t => t.Transaction)
                //.Include(t=>t.TransactionID)
                .Include(t => t.Item)
                .FirstOrDefault(t => t.TransactionLineID == id);
        }
    }
}

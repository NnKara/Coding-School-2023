using Model;
using Orm.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Repository {
    public class MonthlyLedgerRepo : EntityInterface<MonthlyLedger> {
        public void Add(MonthlyLedger entity) {
            using var petShopContext = new PetShopContext();
            petShopContext.Add(entity);
            petShopContext.SaveChanges();
        }

        public void Delete(Guid id) {
            using var petShopContext = new PetShopContext();
            var dbMonthlyLedger = petShopContext.MonthlyLedgers.Where(monthlyLedger => monthlyLedger.MonthlyLedgerID == id).SingleOrDefault();
            if (dbMonthlyLedger is null)
                return;
            petShopContext.Remove(dbMonthlyLedger);
            petShopContext.SaveChanges();
        }

        public IList<MonthlyLedger> GetAll() {
            using var petShopContext = new PetShopContext();
            return petShopContext.MonthlyLedgers.ToList();
        }

        public MonthlyLedger? GetById(Guid id) {
            using var petShopContext = new PetShopContext();
            return petShopContext.MonthlyLedgers.Where(monthlyLedger => monthlyLedger.MonthlyLedgerID == id).SingleOrDefault();
        }

        public void Update(Guid id, MonthlyLedger entity) {
            using var petShopContext = new PetShopContext();
            var dbMonthlyLedger = petShopContext.MonthlyLedgers.Where(monthlyLedger => monthlyLedger.MonthlyLedgerID == id).SingleOrDefault();
            if (dbMonthlyLedger is null)
                return;
            dbMonthlyLedger.Month=entity.Month;
            dbMonthlyLedger.Year=entity.Year;
            dbMonthlyLedger.Income=entity.Income;
            dbMonthlyLedger.Total=entity.Total;
            petShopContext.SaveChanges();
        }
    }
}

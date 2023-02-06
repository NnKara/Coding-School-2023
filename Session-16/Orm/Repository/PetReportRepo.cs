using Model;
using Orm.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Repository {
    public class PetReportRepo : EntityInterface<PetReport> {
        public void Add(PetReport entity) {
            using var petShopContext = new PetShopContext();
            var existingPetReport = petShopContext.PetReports.FirstOrDefault(petReport => petReport.PetReportID == entity.PetReportID);
            if (existingPetReport == null) {
                petShopContext.Add(entity);
                petShopContext.SaveChanges();
            }
        }

        public void Delete(Guid id) {
            using var petShopContext = new PetShopContext();
            var dbPetReport = petShopContext.PetReports.Where(petReport => petReport.PetReportID == id).SingleOrDefault();
            if (dbPetReport is null)
                return;
            petShopContext.Remove(dbPetReport);
            petShopContext.SaveChanges();
        }

        public IList<PetReport> GetAll() {
            using var petShopContext = new PetShopContext();
            return petShopContext.PetReports.ToList();
        }

        public PetReport? GetById(Guid id) {
            using var petShopContext = new PetShopContext();
            return petShopContext.PetReports.Where(petReport => petReport.PetReportID == id).SingleOrDefault();
        }

        public void Update(Guid id, PetReport entity) {
            using var petShopContext = new PetShopContext();
            var dbPetReport = petShopContext.PetReports.Where(petReport => petReport.PetReportID == id).SingleOrDefault();
            if (dbPetReport is null)
                return;
            dbPetReport.PetReportMonth = entity.PetReportMonth;
            dbPetReport.PetReportYear = entity.PetReportYear;
            dbPetReport.PetReportTotalSold = entity.PetReportTotalSold;
            petShopContext.SaveChanges();
        }
    }
}

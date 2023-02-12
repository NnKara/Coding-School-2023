using Microsoft.EntityFrameworkCore;
using PetShop.EF.Context;
using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Repository {
    public class EmployeeRepo : EntityInterface<Employee> {
        public void Add(Employee entity) {
            using var petShopDbContext = new PetShopDbContext();

            if (entity.EmployeeID != 0) {
                throw new ArgumentException("Given entity should not have ID set", nameof(entity));
            }

            petShopDbContext.Add(entity);
            petShopDbContext.SaveChanges();

        }

        public void Delete(int id) {
            using var petShopContext = new PetShopDbContext();
            var dbEmployee = petShopContext.Employees.Where(employee => employee.EmployeeID == id).SingleOrDefault();
            if (dbEmployee is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            var transactions = petShopContext.Transactions.Where(t => t.EmployeeID == id).ToList();
            if (transactions.Any()) {
                throw new Exception("Cannot delete employee who has associated transactions. Please delete the transactions first.");
            }
            petShopContext.Remove(dbEmployee);
            petShopContext.SaveChanges();
        }

        public IList<Employee> GetAll() {
            using var petShopContext = new PetShopDbContext();
            return petShopContext.Employees.ToList();
        }

        public Employee GetByID(int id) {
            using var petShopContext = new PetShopDbContext();
            var dbEmployee = petShopContext.Employees.Include(emp=>emp.Transactions)
                                                     .ThenInclude(tras=>tras.Customer)
                                                     .Include(emp => emp.Transactions)
                                                     .ThenInclude(trans => trans.PetFood)
                                                     .Include(emp => emp.Transactions)
                                                     .ThenInclude(trans => trans.Pet)
                                                     .Where(employee => employee.EmployeeID == id).SingleOrDefault();

            if (dbEmployee is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            } else {
                return dbEmployee;
            }
        }

        public void Update(int id, Employee entity) {
            using var petShopContext = new PetShopDbContext();
            var dbEmployee = petShopContext.Employees.Where(employee => employee.EmployeeID == id).SingleOrDefault();
            if (dbEmployee is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            dbEmployee.EmployeeName = entity.EmployeeName;
            dbEmployee.EmployeeSurname = entity.EmployeeSurname;
            dbEmployee.SalaryPerMonth = entity.SalaryPerMonth;
            dbEmployee.EmployeeType = entity.EmployeeType;
            petShopContext.SaveChanges();
        }
    }
}

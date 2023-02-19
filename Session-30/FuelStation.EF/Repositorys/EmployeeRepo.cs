using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositorys {
    public class EmployeeRepo : IEntityRepo<Employee> {
        public void Add(Employee entity) {
            using var fuelDb = new FuelStasionDbContext();

            if (entity.EmployeeID != 0) {
                throw new ArgumentException("Given entity should not have ID set", nameof(entity));
            }

            fuelDb.Add(entity);
            fuelDb.SaveChanges();
        }

        public void Delete(int id) {
            using var fuelDb = new FuelStasionDbContext();
            var dbEmployee = fuelDb.Employees.Where(employee => employee.EmployeeID == id).SingleOrDefault();
            if (dbEmployee is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            var transactions = fuelDb.Transactions.Where(t => t.EmployeeID == id).ToList();
            if (transactions.Any()) {
                throw new Exception("Cannot delete employee who has associated transactions. Please delete the transactions first.");
            }
            fuelDb.Remove(dbEmployee);
            fuelDb.SaveChanges();
        }

        public IList<Employee> GetAll() {
            using var fuelDb = new FuelStasionDbContext();
            return fuelDb.Employees.ToList();
        }

        public Employee? GetByID(int id) {
            using var fuelDb = new FuelStasionDbContext();

            var dbEmployee = fuelDb.Employees
                 .Include(c => c.Transactions)
                  .ThenInclude(t => t.TransactionLines)
                 .FirstOrDefault(c => c.EmployeeID == id);

            if (dbEmployee is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            } else {
                return dbEmployee;
            }
        }

        public void Update(int id, Employee entity) {
            using var fuelDb = new FuelStasionDbContext();
            var dbEmployee = fuelDb.Employees.FirstOrDefault(c => c.EmployeeID == id);

            if (dbEmployee is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }

            dbEmployee.EmployeeName = entity.EmployeeName;
            dbEmployee.EmployeeSurname = entity.EmployeeSurname;
            dbEmployee.EmployeeType = entity.EmployeeType;
            dbEmployee.SalaryPerMonth = entity.SalaryPerMonth;
            dbEmployee.HireDateStart = entity.HireDateStart;
            dbEmployee.HireDateEnd = entity.HireDateEnd;
            fuelDb.SaveChanges();
        }

    }
}


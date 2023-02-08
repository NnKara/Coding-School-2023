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
            using var petShopContext = new PetShopDbContext();
            var existingEmployee = petShopContext.Employees.FirstOrDefault(employee => employee.EmployeeSurname == entity.EmployeeSurname);
            if (existingEmployee == null) {
                petShopContext.Add(entity);
                petShopContext.SaveChanges();
            }
        }

        public void Delete(int id) {
            using var petShopContext = new PetShopDbContext();
            var dbEmployee = petShopContext.Employees.Where(employee => employee.EmployeeID == id).SingleOrDefault();
            if (dbEmployee is null)
                return;
            petShopContext.Remove(dbEmployee);
            petShopContext.SaveChanges();
        }

        public IList<Employee> GetAll() {
            using var petShopContext = new PetShopDbContext();
            return petShopContext.Employees.ToList();
        }

        public Employee? GetByID(int id) {
            using var petShopContext = new PetShopDbContext();
            return petShopContext.Employees.Where(employee => employee.EmployeeID == id).SingleOrDefault();
        }

        public void Update(int id, Employee entity) {
            using var petShopContext = new PetShopDbContext();
            var dbEmployee = petShopContext.Employees.Where(employee => employee.EmployeeID == id).SingleOrDefault();
            if (dbEmployee is null)
                return;
            dbEmployee.EmployeeName = entity.EmployeeName;
            dbEmployee.EmployeeSurname = entity.EmployeeSurname;
            dbEmployee.SalaryPerMonth = entity.SalaryPerMonth;
            dbEmployee.EmployeeType = entity.EmployeeType;
            petShopContext.SaveChanges();
        }
    }
}

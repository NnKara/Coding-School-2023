﻿using Microsoft.EntityFrameworkCore;
using Model;
using Orm.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Repository
{
    public class EmployeeRepo : EntityInterface<Employee>
    {
        public void Add(Employee entity)
        {
            using var petShopContext = new PetShopContext();
            var existingEmployee = petShopContext.Employees.FirstOrDefault(employee => employee.EmployeeSurname == entity.EmployeeSurname);
            if (existingEmployee == null) {
                petShopContext.Add(entity);
                petShopContext.SaveChanges();
            }
        }

        public void Delete(Guid id)
        {
            using var petShopContext = new PetShopContext();
            var dbEmployee = petShopContext.Employees.Where(employee => employee.EmployeeID == id).SingleOrDefault();
            if (dbEmployee is null)
                return;
            petShopContext.Remove(dbEmployee);
            petShopContext.SaveChanges();
        }

        public IList<Employee> GetAll()
        {
            using var petShopContext = new PetShopContext();
            return petShopContext.Employees.ToList();             
        }

        public Employee? GetById(Guid id)
        {
            using var petShopContext = new PetShopContext();
            return petShopContext.Employees.Where(employee => employee.EmployeeID == id).SingleOrDefault();
        }

        public void Update(Guid id, Employee entity)
        {
            using var petShopContext = new PetShopContext();
            var dbEmployee = petShopContext.Employees.Where(employee => employee.EmployeeID == id).SingleOrDefault();
            if (dbEmployee is null)
                return;
            dbEmployee.EmployeeName= entity.EmployeeName;
            dbEmployee.EmployeeSurname = entity.EmployeeSurname;
            dbEmployee.SallaryPerMonth= entity.SallaryPerMonth;
            dbEmployee.EmployeeType = entity.EmployeeType;
            petShopContext.SaveChanges();
        }
    }
}

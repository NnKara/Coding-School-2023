using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Repository {
    public class MockRepoEmployees : EntityInterface<Employee> {
        private readonly List<Model.Employee> _employees;


        public MockRepoEmployees() {
            _employees = new List<Model.Employee>
            {

            new Model.Employee {
                EmployeeID= 1,
                EmployeeName="Nikos",
                EmployeeSurname="karamitos",
                EmployeeType=Model.Enums.EmployeeType.Staff,
                SalaryPerMonth=1500
            },

            new Model.Employee {
                EmployeeID= 1,
                EmployeeName="Grigoris",
                EmployeeSurname="Avgenikos",
                EmployeeType=Model.Enums.EmployeeType.Manager,
                SalaryPerMonth=1800
            },

              new Model.Employee {
                EmployeeID= 1,
                EmployeeName="Xristos",
                EmployeeSurname="Kontorias",
                EmployeeType=Model.Enums.EmployeeType.Manager,
                SalaryPerMonth=1800,
            }
        };
        }

        public void Add(Employee entity) {
            throw new NotImplementedException();
        }

        public void Delete(int id) {
            throw new NotImplementedException();
        }

        public IList<Employee> GetAll() {
            return _employees;
        }

        public Employee? GetByID(int id) {
            return _employees.SingleOrDefault(employee => employee.EmployeeID == id);
        }

        public void Update(int id, Employee entity) {
            throw new NotImplementedException();
        }
    }
}

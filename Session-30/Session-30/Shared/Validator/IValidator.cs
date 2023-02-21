using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_30.Shared.Validator
{
    public interface IValidator {

        bool ValidateAddEmployee(Employee employee,EmployeeType type, List<Employee> employees, out String errorMessage);
        bool ValidateDeleteEmployee(EmployeeType type, List<Employee> employees, out String errorMessage);
        bool ValidateUpdateEmployee(EmployeeType NewType, Employee dbEmployee, List<Employee> employees, out String errorMessage);
        //bool ValidateAddCustomer(List<Customer> customers, out String errorMessage);
        //bool ValidateDeleteCustomer(List<Customer> customers, out String errorMessage);
        //bool ValidateTransaction(Transaction transaction, out String errorMessage);
    }
}

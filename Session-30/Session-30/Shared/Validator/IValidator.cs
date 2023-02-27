using FuelStation.Model;
using Session_30.Shared.ItemDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_30.Shared.Validator
{
    public interface IValidator {


        bool ValidateDeleteCustomer(Customer customer, out String erroMessage);
        bool ValidateAddEmployee(Employee employee,EmployeeType type, List<Employee> employees, out String errorMessage);
        bool ValidateDeleteEmployee(EmployeeType type, List<Employee> employees, out String errorMessage);

        bool HasEmployeeTransaction(Employee employee,out String errorMessage);
        bool ValidateUpdateEmployee(EmployeeType type, Employee dbEmployee, List<Employee> employees, out String errorMessage);
        bool ValidateAddItem(List<Item> items,ItemEditDto item, out String errorMessage);
        bool ValidateUpdateItem(List<Item> items, Item dbItem, ItemEditDto newItem, out String errorMessage);
        bool ValidateDeleteItem(Item item, out String errorMessage);
    }
}

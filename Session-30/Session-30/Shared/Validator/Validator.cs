using FuelStation.Model;
using Session_30.Shared.ItemDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_30.Shared.Validator
{
    public class Validator : IValidator {

        public readonly MinMax ManagersLimits;
        public readonly MinMax CashiersLimits;
        public readonly MinMax StaffLimits;
        public readonly MinMax WaitersLimits;

        public Validator() {
            ManagersLimits = new MinMax() { Min = 1, Max = 3 };
            CashiersLimits = new MinMax() { Min = 1, Max = 4 };
            StaffLimits = new MinMax() { Min = 1, Max = 10 };
        }

        public bool ValidateAddEmployee(Employee employee,EmployeeType type, List<Employee> employees, out string errorMessage) {
            errorMessage = "Succeed";
            bool isValid = true;
            var cashiers = employees.Where(e => e.EmployeeType == EmployeeType.Cashier);
            var staff = employees.Where(e => e.EmployeeType == EmployeeType.Staff);
            var managers = employees.Where(e => e.EmployeeType == EmployeeType.Manager);

            if (type == EmployeeType.Manager && managers.Count() == ManagersLimits.Max) {
                isValid = false;
                errorMessage = $"You have already {ManagersLimits.Max} Managers. Max number of Managers is {ManagersLimits.Max}";
            }
            if (type == EmployeeType.Cashier && cashiers.Count() >= CashiersLimits.Max) {
                isValid = false;
                errorMessage = $"You have already {CashiersLimits.Max} Cashiers. Max number of Cashiers is {CashiersLimits.Max}";
            }
            if (type == EmployeeType.Staff && staff.Count() >= StaffLimits.Max) {
                isValid = false;
                errorMessage = $"You have already {StaffLimits.Max} Staff. Max number of Staff is {StaffLimits.Max}";
            }
            if (employee.HireDateStart <= employee.HireDateEnd) {
                isValid = false;
                errorMessage = $"Hire-Date-Start must be greater than Hire-Date-End!";
            }
            return isValid;    
    }


        public bool ValidateAddItem(List<Item> items, ItemEditDto newItem, out string errorMessage)
        {
            errorMessage = "Succeed";
            bool isValid = true;
            foreach(Item item in items)
            {
                if (item.Code == newItem.Code && item.ItemID!=newItem.ItemID)
                {
                    errorMessage = $"Specific code is been taken by another Item! Re-enter a new code..";
                    isValid = false;
                }
                if(item.ItemID!=newItem.ItemID && item.ItemType==newItem.ItemType && item.Description == newItem.Description)
                {
                    errorMessage = $"This item already exists!";
                    isValid = false;
                }
            }

            return isValid;
        }

        public bool ValidateUpdateItem(List<Item> items, Item dbItem, ItemEditDto newItem, out string errorMessage)
        {
            errorMessage = "Succeed";
            bool isValid = true;
            foreach (Item item in items)
            {
                if (item.Code == newItem.Code && item.ItemID != newItem.ItemID)
                {
                    errorMessage = $"Specific code is been taken by another Item! Re-enter a new code..";
                    isValid = false;
                }
                if (item.ItemID != newItem.ItemID && item.ItemType == newItem.ItemType && item.Description == newItem.Description)
                {
                    errorMessage = $"This item already exists!";
                    isValid = false;
                }
            }

            return isValid;
        }

        public bool ValidateDeleteItem(Item item, out string errorMessage)
        {
            errorMessage = "Succeed";
            bool isValid = true;
            if (item.TransactionLines.Count > 0)
            {
                errorMessage = $"You cannot delete current Item.Delete it's associated Transactions first!";
                isValid = false;
            }
            return isValid;
        }

        public bool ValidateDeleteEmployee(EmployeeType type, List<Employee> employees, out string errorMessage) {
            bool isValid = true;
            errorMessage = "Succeed ";
            var cashiers = employees.Where(e => e.EmployeeType == EmployeeType.Cashier);
            var staff = employees.Where(e => e.EmployeeType == EmployeeType.Staff);
            var managers = employees.Where(e => e.EmployeeType == EmployeeType.Manager);
            if (type == EmployeeType.Manager && managers.Count() <= ManagersLimits.Min) {
                errorMessage = $"You have only {ManagersLimits.Min} Manager. Min number of Managers is {ManagersLimits.Min}";
                isValid = false;
            }
            if (type == EmployeeType.Cashier && cashiers.Count() <= CashiersLimits.Min) {
                errorMessage = $"You have only {CashiersLimits.Min} Cashier. Min number of Cashiers is {CashiersLimits.Min}";
                isValid = false;
            }
            if (type == EmployeeType.Staff && staff.Count() <= StaffLimits.Min) {
                errorMessage = $"You have only {StaffLimits.Min} staff. Min number of Staff is {StaffLimits.Min}";
                isValid = false;
            }
            return isValid;
        }


        public bool ValidateUpdateEmployee(EmployeeType NewType, Employee dbEmployee, List<Employee> employees, out string errorMessage) {
            errorMessage = "Succeed ";
            bool isValid = true;
            if (dbEmployee == null) {
                isValid = false;
            } else if (NewType != dbEmployee.EmployeeType) {
                var cashiers = employees.Where(e => e.EmployeeType == EmployeeType.Cashier);
                var staff = employees.Where(e => e.EmployeeType == EmployeeType.Staff);
                var managers = employees.Where(e => e.EmployeeType == EmployeeType.Manager);
                if (NewType == EmployeeType.Manager && managers.Count() >= ManagersLimits.Max) {
                    errorMessage = $"You have already {ManagersLimits.Max} Managers. Max number of managers is {ManagersLimits.Max}";
                    isValid = false;
                }
                if (NewType == EmployeeType.Cashier && cashiers.Count() >= CashiersLimits.Max) {
                    errorMessage = $"You have already {CashiersLimits.Max} Cashiers. Max number of cashiers is {CashiersLimits.Max}";
                    isValid = false;
                }
                if (NewType == EmployeeType.Staff && staff.Count() >= StaffLimits.Max) {
                    errorMessage = $"You have already {StaffLimits.Max} Staff. Max number of Staff is {StaffLimits.Max}";
                    isValid = false;
                }
                if (dbEmployee.HireDateStart <= dbEmployee.HireDateEnd)
                {
                    isValid = false;
                    errorMessage = "Hire-Date-Start must be lower than Hire-Date-End!";
                }
            }
            return isValid;
        }

        public bool ValidateDeleteCustomer(Customer customer, out string erroMessage)
        {
            erroMessage = "Succeed";
            bool isValid = true;
            if (customer.Transactions.Count > 0)
            {
                erroMessage = $"You cannot delete current Customer.Delete his associated Transactions first!";
                isValid = false;
            }
            return isValid;
        }

        public bool HasEmployeeTransaction(Employee employee, out string errorMessage)
        {
            errorMessage = "Succeed";
            bool isValid = true;
            if (employee.Transactions.Count > 0)
            {
                errorMessage = $"You cannot delete current Employee.Delete his associated Transactions first!";
                isValid = false;
            }
            return isValid;
        }

        public struct MinMax {
            public int Min;
            public int Max;
        }
    }
}

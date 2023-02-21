using FuelStation.Model;
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
            var baristas = employees.Where(e => e.EmployeeType == EmployeeType.Staff);
            var managers = employees.Where(e => e.EmployeeType == EmployeeType.Manager);

            if (type == EmployeeType.Manager && managers.Count() == ManagersLimits.Max) {
                isValid = false;
                errorMessage = $"You have already {ManagersLimits.Max} Managers. Max number of managers is {ManagersLimits.Max}";
            }
            if (type == EmployeeType.Cashier && cashiers.Count() >= CashiersLimits.Max) {
                isValid = false;
                errorMessage = $"You have already {CashiersLimits.Max} Cashiers. Max number of Cashiers is {CashiersLimits.Max}";
            }
            if (type == EmployeeType.Staff && baristas.Count() >= StaffLimits.Max) {
                isValid = false;
                errorMessage = $"You have already {StaffLimits.Max} Staff. Max number of Staff is {StaffLimits.Max}";
            }
            if (employee.HireDateStart < employee.HireDateEnd) {
                isValid = false;
                errorMessage = $"Hire-Date-Start must be greater than Hire-Date-End!";
            }
            return isValid;    
    }

        public bool ValidateAddEmployee(EmployeeType type, List<Employee> employees, out string errorMessage) {
            throw new NotImplementedException();
        }

        public bool ValidateDeleteEmployee(EmployeeType type, List<Employee> employees, out string errorMessage) {
            bool isValid = true;
            errorMessage = "Succeed ";
            var cashiers = employees.Where(e => e.EmployeeType == EmployeeType.Cashier);
            var baristas = employees.Where(e => e.EmployeeType == EmployeeType.Staff);
            var managers = employees.Where(e => e.EmployeeType == EmployeeType.Manager);
            if (type == EmployeeType.Manager && managers.Count() <= ManagersLimits.Min) {
                errorMessage = $"You have only {ManagersLimits.Min} Manager. Min number of Managers is {ManagersLimits.Min}";
                isValid = false;
            }
            if (type == EmployeeType.Cashier && cashiers.Count() <= CashiersLimits.Min) {
                errorMessage = $"You have only {CashiersLimits.Min} Cashier. Min number of Cashiers is {CashiersLimits.Min}";
                isValid = false;
            }
            if (type == EmployeeType.Staff && baristas.Count() <= StaffLimits.Min) {
                errorMessage = $"You have only {StaffLimits.Min} Barista. Min number of Baristas is {StaffLimits.Min}";
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
                var baristas = employees.Where(e => e.EmployeeType == EmployeeType.Staff);
                var managers = employees.Where(e => e.EmployeeType == EmployeeType.Manager);
                if (NewType == EmployeeType.Manager && managers.Count() >= ManagersLimits.Max) {
                    errorMessage = $"You have already {ManagersLimits.Max} Managers. Max number of managers is {ManagersLimits.Max}";
                    isValid = false;
                }
                if (NewType == EmployeeType.Cashier && cashiers.Count() >= CashiersLimits.Max) {
                    errorMessage = $"You have already {CashiersLimits.Max} cashiers. Max number of cashiers is {CashiersLimits.Max}";
                    isValid = false;
                }
                if (NewType == EmployeeType.Staff && baristas.Count() >= StaffLimits.Max) {
                    errorMessage = $"You have already {StaffLimits.Max} Staff. Max number of Staff is {StaffLimits.Max}";
                    isValid = false;
                }
                if (dbEmployee.HireDateStart > dbEmployee.HireDateEnd) {
                    isValid = false;
                    errorMessage = $"Hire-Date-Start must be greater than Hire-Date-End!";
                }
            }
            return isValid;
        }


        public struct MinMax {
            public int Min;
            public int Max;
        }
    }
}

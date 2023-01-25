﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11 {
    public class Employee : Person {
        public enum EmployeeTypeEnum {
            Manager,
            Staff
        }
        public Guid EmployeeID { get; set; }
        public double SalaryPerMonth { get; set; }
        public EmployeeTypeEnum EmployeeType { get; set; }

        public string FullName {
            get {
                return String.Format("{0} {1}", Name, Surname);
            }
        }

        public Employee()
        {
            EmployeeID = Guid.NewGuid();
        }


        public Employee(Guid employeeID, String name, String surname, double salaryPerMonth, EmployeeTypeEnum employeeType) : base(name,surname)
        {
            EmployeeID = employeeID;
            SalaryPerMonth = salaryPerMonth;
            EmployeeType = employeeType;
        }

    
    }
}

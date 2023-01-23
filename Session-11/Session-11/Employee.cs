﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11 {
    public class Employee : Person {
        enum EmployeeTypeEnum {
            Manager,
            Staff
        }
        public Guid EmployeeID { get; set; }
        public double SalaryPerMonth { get; set; }
        EmployeeTypeEnum EmployeeType { get; set; }

        public Employee(Guid id) : base(id) {
            EmployeeID = id;
        }
    }

}

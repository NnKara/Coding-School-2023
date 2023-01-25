using DevExpress.XtraSpreadsheet.Commands.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11 {
    public class Settings {
        public double Rent { get; set; }
        public double StaffSalary { get; set; }


        public Settings() {
            Rent = 2000;
            StaffSalary = 700;
        }

    }
}

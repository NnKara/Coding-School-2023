using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Session_11
{
    public class MonthlyLedger
    {
        public DateOnly Year { get; set; }
        public DateOnly Month { get; set; }
        public double Income { get; set; }
        public double Expenses { get; set; }
        public double Total { get; set; }
    }
}

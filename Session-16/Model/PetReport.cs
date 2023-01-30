using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  class PetReport
    {
        public int PetReportYear { get; set; }
        public int PetReportMonth { get; set; }
        public AnimalType AnimalType { get; set; }
        public decimal PetReportTotalSold { get; set; }
    }
}

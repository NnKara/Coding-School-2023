using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  class PetReport
    {
        public Guid PetReportID { get; set; }
        public int PetReportYear { get; set; }
        public int PetReportMonth { get; set; }
        public Pet.AnimalType AnimalType { get; set; }
        public decimal PetReportTotalSold { get; set; }

        public PetReport()
        {
            PetReportID = Guid.NewGuid();
        }
    }
}

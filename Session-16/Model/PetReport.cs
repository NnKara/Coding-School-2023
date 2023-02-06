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
        public AnimalType AnimalType { get; set; }
        public int PetReportTotalSold { get; set; }

        public List<Transaction> Transactions { get; set; }

        public PetReport()
        {
            PetReportID = Guid.NewGuid();
            Transactions = new List<Transaction>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    internal class Institude
    {
        public Guid ID { get; set; }

        public string? Name { get; set; }

        public int YearsService { get; set; }

        public Institude() { }

        public Institude(Guid id)
        {
            ID= id;
        }

        public Institude(Guid id,string name)
        {
            ID= id;
            Name= name;
        }

        public Institude(Guid iD, string name, int yearsService)
        {
            ID= iD;
            Name= name;
            YearsService = yearsService;
        }

        public void GetName()
        {

        }

        public void SetName(string name)
        {

        }
    }
}

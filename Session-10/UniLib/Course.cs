using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class Course
    {

        public Guid ID { get; set; }

        public string? Code { get; set; }

        public string? Subject { get; set; }

        public Course() { }
        

        public Course(Guid id)
        {
            ID= id;
        }

        public Course(Guid id,String code)
        {
            ID = id;
            Code= code;
        }

        public Course(Guid iD, string? code, string? subject) 
        {
            ID = iD;
            Code= code;
            Subject = subject;
        }
    }
}

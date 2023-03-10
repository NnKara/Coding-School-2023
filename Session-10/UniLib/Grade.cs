using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniLib
{
    public class Grade
    {
        public Guid ID { get; set; }
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        public int GradeValue { get; set; }


        public Grade() 
        {
           ID=Guid.NewGuid();
            StudentID=Guid.NewGuid();
            CourseID=Guid.NewGuid();
            
        }

        public Grade(Guid id)
        {
            ID = id;
        }

        public Grade(Guid id,Guid studentID)
        {
            ID = id;
            StudentID = studentID;
        }

        public Grade(Guid id,Guid studentID,Guid courseid)
        {
            ID = id;
            StudentID = studentID;
            CourseID = courseid;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniLib
{
    public class Schedule
    {
        public Guid ID { get; set; }

        public Guid CourseID { get; set; }

        public Guid ProfessorID { get; set; }

        public DateTime Callendar { get; set; }

        public Schedule() { }

        public Schedule(Guid id)
        {
            ID = id;
        }

        public Schedule(Guid id,Guid courseId)
        {
            ID = id;
            CourseID = courseId;
        }

        public Schedule(Guid id,Guid courseId,Guid professorId)
        {
            ID = id;
            CourseID= courseId;
            ProfessorID= professorId;
        }

        public Schedule(Guid id,Guid courseId,Guid professorId,DateTime callendar)
        {
            ID = id;
            CourseID = courseId;
            ProfessorID= professorId;
            Callendar = callendar;
        }
    }
}

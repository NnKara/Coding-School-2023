using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniLib
{
    public class University:Institude
    {
        public List<Student> Students { get; set; }

        public List<Course> Courses { get; set; }

        public List<Grade> Grades { get; set; }

        public List<Schedule> ScheduledCourse { get; set; }


        public University() : base() { }


        public University(Guid id) : base(id) { }


        public University(Guid id,string name):base(id,name) { }


        public University(Guid id,string name,int yearsServed):base(id,name, yearsServed) { }


        public University(List<Student> students, List<Course> courses, List<Grade> grades, List<Schedule> scheduleCourse,
            Guid id,String name,int yearsServed):base(id,name,yearsServed)
        {
            Students = students;
            Courses = courses;
            Grades = grades;
            ScheduledCourse = scheduleCourse;
        }

        public void GetStudents()
        {

        }

        public void GetCourses()
        {

        }

        public void GetGrades()
        {

        }

        public void SetSchedule(Guid courseId,Guid professotId,DateTime datetime)
        {

        }


    }
}

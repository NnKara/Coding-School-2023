using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    internal class University:Institude
    {
        public Student[]? Students { get; set; }
        public Course[]? Courses { get; set; }

        public Grade[]? Grades { get; set; }

        public Schedule[]? ScheduledCourse { get; set; }

        public University() : base() { }


        public University(Guid id) : base(id) { }

        public University(Guid id,string name):base(id,name) { }

        public University(Guid id,string name,int yearsServed):base(id,name, yearsServed) { }

        public University(Student[] students, Course[] courses, Grade[] grades, Schedule[] scheduleCourse,
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

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

        public University()
        {
            ID=Guid.NewGuid();
            Students = new List<Student>();
            Courses= new List<Course>();
            Grades = new List<Grade>();
            ScheduledCourse = new List<Schedule>();
        }


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

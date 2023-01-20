using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class Student:Person
    {
        public int RegistrationNumber { get; set; }

        public List<Course> Courses { get; set; }

        public Student()
        {
            ID= Guid.NewGuid();
        }

        

        public Student(Guid id) : base(id) { }

        public Student(Guid id,string name) : base(id, name) { }

        public Student(Guid id,string name,int age) : base(id, name, age) { }

        

        public Student(int registrationNumber, List<Course> courses, String name, Guid id, int age) : base(id, name, age)
        {
            RegistrationNumber = registrationNumber;
            Courses  = courses;
        }

        public void Attend(Course course,DateTime dateTime)
        {

        }

        public void WriteExam(Course course,DateTime dateTime)
        {

        }
    }
}

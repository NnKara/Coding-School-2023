using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    internal class Student:Person
    {
        public int RegistrationNumber { get; set; }
        public Course[]? Courses { get; set; }

        public Student():base() { }

        public Student(Guid id) : base(id) { }

        public Student(Guid id,string name) : base(id, name) { }

        public Student(Guid id,string name,int age) : base(id, name, age) { }

        public Student(int registrationNumber, Course[] courses, String name, Guid id, int age) : base(id, name, age)
        {
            RegistrationNumber = registrationNumber;
            Courses  = courses;
        }


    }
}

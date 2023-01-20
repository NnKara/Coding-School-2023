using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLib
{
    public class Student:Person
    {
        public Student()
        {
        }

        public Student(Guid id, string name, int age) : base(id, name, age)
        {
            id = Guid.NewGuid();
        }

        public int RegistrationNumber { get; set; }

        public Course[]? Courses { get; set; }

        
    }
}

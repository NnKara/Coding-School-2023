using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLib
{
    public class Person
    {
        public Guid ID { get; set; }

        public string? Name { get; set; }

        public int Age { get; set; }

        public Person(Guid id, string name, int age)
        {
            ID = id;
            Name = name;
            Age = age;
        }
    }
}

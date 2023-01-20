using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class Professor:Person
    {
        public String? Rank { get; set; }

        public Course[]? Courses { get; set; }

        public Professor() : base() { }

        public Professor(Guid id) : base(id) { }

        public Professor(Guid id,string name) : base(id, name) { }

        public Professor(Guid id,string name,int age) : base(id, name, age) { }


        /*public Professor(string? rank,String name,int age,Guid id):base(id,name,age)
        {
            Rank = rank;           
        }*/
        
        /*public Professor(Course[] courses,String name,int age,Guid id):base(id,name,age)
        {
            Courses = Courses;          
        }*/
        
        public Professor(string? rank, Course[] courses,String name,int age,Guid id):base(id,name,age)
        {
            Rank = rank;
            Courses = courses;
        }


        public void Teach(Course course,DateTime dateTime)
        {

        }

        public void SetGrade(Guid studetntID,Guid courseID,int grade)
        {

        }

        public void GetName()
        {

        }
    }
}

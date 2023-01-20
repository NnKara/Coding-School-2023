using System.Diagnostics;

namespace UniversityLib
{
    public class University
    {
        public Student[]? Students { get; set; }

        public Course[]? Courses { get; set; }

        public Grade[]? Grades { get; set; }

        public Schedule[]? ScheduledCourse { get; set; }
    }
}
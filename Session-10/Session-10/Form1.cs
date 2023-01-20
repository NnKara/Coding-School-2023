

using System;
using UniLib;

namespace Session_10
{
    public partial class Form1 : Form
    {
        Serializer serializer;

        University uni;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grdViewStudents.AutoGenerateColumns = false;
            grdVCourses.AutoGenerateColumns = false;
            grdViewGrades.AutoGenerateColumns = false;
            grdViewSchedules.AutoGenerateColumns = false;

             serializer = new Serializer();

            uni = new University()
            {
                Name="Papel",
                YearsService=1980
            };
           

            List<Student> students = new List<Student>();
            List<Course> courses = new List<Course>();
            List<Grade> grades = new List<Grade>();
            List<Schedule> schedules = new List<Schedule>();



            Student student1 = new Student()
            {
                Name = "Nikos Karamitos",
                Age = 25,
                RegistrationNumber = 1
            };
            uni.Students.Add(student1);
            Student student2 = new Student()
            {
                Name = "Giannis Kats",
                Age = 25,
                RegistrationNumber = 2
            };
            uni.Students.Add(student2);
            grdViewStudents.DataSource = uni.Students;


            Course course = new Course()
            {
                Subject = "Maths",
                Code = "1"
            };
            courses.Add(course);
            Course course1 = new Course()
            {
                Subject = "History",
                Code = "2"
            };
            uni.Courses.Add(course);
            uni.Courses.Add(course1);
            grdVCourses.DataSource = uni.Courses;

            Grade grade1 = new Grade()
            {
                GradeValue = 15
            };

            Grade grade2 = new Grade()
            {
            GradeValue = 20
            };
            uni.Grades.Add(grade1);
            uni.Grades.Add(grade2);
            grdViewGrades.DataSource = uni.Grades;

            Schedule schedule1 = new Schedule();
            Schedule schedule2 = new Schedule();
            uni.ScheduledCourse.Add(schedule2);
            uni.ScheduledCourse.Add(schedule1);
            grdViewSchedules.DataSource = uni.ScheduledCourse;



        }




        public Course AddCourse(String subject, String code)
        {
            Course course = new Course();
            course.Subject = subject;
            course.Code = code;
            return course;
        }

        private void grdViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdViewGrades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdViewSchedules_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdVCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            serializer.SerializeToFile(uni, "University.json");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            uni = serializer.Deserialize<University>("University.json");
        }
    }
}
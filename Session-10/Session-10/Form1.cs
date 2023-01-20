

using UniLib;

namespace Session_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grdViewStudents.AutoGenerateColumns = false;
            University uni = new University();
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
            students.Add(student1);
           // uni.Students.Add(student1);
            Student student2 = new Student()
            {
                Name = "Giannis Kats",
                Age = 25,
                RegistrationNumber = 2
            };
            students.Add(student2);
           // uni.Students.Add(student2);
            grdViewStudents.DataSource = students;
            grdViewStudents.AutoGenerateColumns = false;
            Course course = new Course()
            {
                Subject = "Maths",
                Code = "1"
            };
            courses.Add(course);
            //uni.Courses.Add(course);
            Course course1 = new Course()
            {
                Subject = "History",
                Code = "2"
            };
            courses.Add(course1);
            //uni.Courses.Add(course1);
            grdVCourses.DataSource = courses;
          

        }




        //public void AddCourse(String subject,String code)
        //{
        //    Course course = new Course();
        //    course.Subject = subject;
        //    course.Code = code;
        //}

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
    }
}
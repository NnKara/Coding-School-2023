using Session_06;

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
            List<Student> students = new List<Student>();

            Student student1 = new Student()
            {
                Name = "Nikos Karamitos",
                Age = 25,
                RegistrationNumber = 1

            };
            students.Add(student1);

            Student student2 = new Student()
            {
                Name = "Giannis Katsaros",
                Age = 25,
                RegistrationNumber = 2

            };
            students.Add(student2);

        }
    }
}
using System.Windows.Forms;

namespace lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student
            {
                RollNo = Convert.ToInt32(textBox1.Text),
                Name = textBox2.Text
            };
            StudentContext db = new StudentContext();
            db.Students.Add(student);
            db.SaveChanges();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student student = new Student
            {
                RollNo = Convert.ToInt32(textBox1.Text),
                Name = textBox2.Text
            };

            StudentContext db = new StudentContext();
            db.Students.Update(student);
            db.SaveChanges();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student student = new Student
            {
                RollNo = Convert.ToInt32(textBox1.Text),
                Name = textBox2.Text
            };

            StudentContext db = new StudentContext();
            db.Students.Remove(student);
            db.SaveChanges();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            StudentContext db = new StudentContext();
            dataGridView1.DataSource = db.Students.ToList();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int rollno = Convert.ToInt32(textBox1.Text);
            StudentContext db = new StudentContext();
            var found = db.Students.FirstOrDefault(s => s.RollNo == rollno);

            List<Student> students = new List<Student> { found };
            dataGridView1.DataSource = students;

        }
    }
}

using Microsoft.Data.SqlClient;
using System.Drawing;

namespace lab9b
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

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(comboBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text) ||
                string.IsNullOrWhiteSpace(textBox7.Text) ||
                string.IsNullOrWhiteSpace(textBox8.Text))
            {
                MessageBox.Show("Please enter all details!");
                return;
            }
            DateTime selectedDate = dateTimePicker1.Value;
            DateTime today = DateTime.Today;

            if (selectedDate>today)
            {
                MessageBox.Show("Date added can't be future date");
                return;
            }
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-HFMTC3I\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            try
            {
                string query = "INSERT INTO Books (BookID,Title,Author,Publisher,category,ISBN,Quantity,Price,RackNo,DateAdded) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + dateTimePicker1.Value + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }
}

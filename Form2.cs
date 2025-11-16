using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace lab9b
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-HFMTC3I\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            try
            {
                string query = "SELECT * FROM [user] WHERE name='"+textBox1.Text+"' AND Password='"+textBox2.Text+"'";
                SqlCommand cmd = new SqlCommand(query,con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Login Successful!");
                    Form3 f=new Form3();    
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login");
                }
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
    

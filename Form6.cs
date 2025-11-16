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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter bookId");
                return;
            }
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-HFMTC3I\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            try
            {
                string query = "UPDATE Books SET BookID='" + textBox1.Text + "',Title='" + textBox2.Text + "',Author='" + textBox3.Text + "',Publisher='" + textBox4.Text + "',category='" + comboBox1.Text + "',ISBN='" + textBox5.Text + "',Quantity='" + textBox6.Text + "',Price='" + textBox7.Text + "',RackNo='" + textBox8.Text + "',DateAdded='" + dateTimePicker1.Value + "' Where BookID='"+textBox1.Text+"'";
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter bookId");
                return;
            }
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-HFMTC3I\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            try
            {
                string query = "SELECT * FROM Books Where BookID='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {
                    textBox2.Text = r["Title"].ToString();
                    textBox3.Text = r["Author"].ToString();
                    textBox4.Text = r["Publisher"].ToString();
                    comboBox1.Text = r["category"].ToString();
                    textBox5.Text = r["ISBN"].ToString();
                    textBox6.Text = r["Quantity"].ToString();
                    textBox7.Text = r["Price"].ToString();
                    textBox8.Text = r["RackNo"].ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(r["DateAdded"]);
                }
                else MessageBox.Show("Book is not there ");
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

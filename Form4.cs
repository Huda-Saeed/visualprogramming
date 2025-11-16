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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
             {
                    MessageBox.Show("Please enter BookId");
                    return;
            }
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-HFMTC3I\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            try
            {
                string query = "DELETE FROM Books Where BookID='" + textBox1.Text + "'";
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

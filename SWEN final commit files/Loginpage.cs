using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;


namespace SWENWindowForm
{
    public partial class Loginpage : Form
    {
        public Loginpage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SWENDatabase;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select position FROM userMan where username = '" + textBox1.Text + "' and password ='" + textBox2.Text + "'", con);
            SqlDataAdapter sda1 = new SqlDataAdapter("Select Count(*) From userMan where username='" + textBox1.Text + "' and password = '" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sda1.Fill(dt);
            if (dt.Rows[0][0].ToString() == "Administrator")
            {
                this.Hide();
                HmsHomepage ss = new HmsHomepage();
                ss.Show();
            }
            else if (dt.Rows[0][0].ToString() != "Administrator")
            {
                this.Hide();
                HmsHomepageUser ss = new HmsHomepageUser();
                ss.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }
    }
}

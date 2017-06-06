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

namespace SWENWindowForm
{
    public partial class searchUser : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;

        public searchUser()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Database1;Integrated Security=True");


        private void button3_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
            MessageBox.Show("Delete Successful");


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "id")
            {
                sda = new SqlDataAdapter("SELECT id, fName, lName, username, password, Position FROM userMan WHERE id LIKE '" + textBox1.Text + "%'", con);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "fName")
            {
                 sda = new SqlDataAdapter("SELECT id, fName, lName, username, password, Position FROM userMan WHERE fName LIKE '" + textBox1.Text + "%'", con);
                 dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "lName")
            {
                 sda = new SqlDataAdapter("SELECT id, fName, lName, username, password, Position FROM userMan WHERE lName LIKE '" + textBox1.Text + "%'", con);
                 dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "username")
            {
                 sda = new SqlDataAdapter("SELECT id, fName, lName, username, password, Position FROM userMan WHERE username LIKE '" + textBox1.Text + "%'", con);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "Position")
            {
                sda = new SqlDataAdapter("SELECT id, fName, lName, username, password, Position FROM userMan WHERE Position LIKE '" + textBox1.Text + "%'", con);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void searchUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.userMan' table. You can move, or remove it, as needed.
            this.userManTableAdapter.Fill(this.database1DataSet.userMan);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
            MessageBox.Show("Update Complete");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

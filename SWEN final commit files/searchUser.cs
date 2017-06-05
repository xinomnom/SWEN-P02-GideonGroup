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
    public partial class SearchUser : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;


        public SearchUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
            MessageBox.Show("Update Complete");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
            MessageBox.Show("Delete Successful");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            HmsHomepage ss = new HmsHomepage();
            ss.Show();
        }
    }
}

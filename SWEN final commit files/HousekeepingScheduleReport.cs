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
    public partial class HousekeepingScheduleReport : Form
    {
        public HousekeepingScheduleReport()
        {
            InitializeComponent();
        }
 
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SWENDatabase;Integrated Security=True ");
        DataTable dt = new DataTable();
        private void HousekeepingScheduleReport_Load(object sender, EventArgs e)
        {
            
            FillData();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//filter the combo box staff duty
        {
           
        }

        private void FillData()//fill data grid
        {
            //Intitalize
            SqlDataAdapter adapter= new SqlDataAdapter();
            SqlCommand cmd;

            //SQL data
            string sql = "SELECT * from Staff ";
            cmd = new SqlCommand(sql, con);
            adapter.SelectCommand = cmd;
            //Fill data grid
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FilterBox2_SelectedIndexChanged(object sender, EventArgs e)//filter for combo box days of a week
        {

        }

        private void FilterBox1_SelectedIndexChanged_1(object sender, EventArgs e)//select staff duty
        {
            DataView dv = new DataView(dt);
            if(FilterBox1.SelectedItem.ToString()=="All")//if user selects all everything would be displayed from the data grid
            {
                dataGridView1.DataSource = dt;
            }

            else
            {
                dv.RowFilter = string.Format("Staff_Duty LIKE '%{0}%'", FilterBox1.SelectedItem.ToString());
                dataGridView1.DataSource = dv; 
            }
        }

        private void button4_Click(object sender, EventArgs e)//go back to report home page
        {
            this.Hide();
            ReportModule ss = new ReportModule();
            ss.Show();
        }
    }
}

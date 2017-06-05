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
    public partial class GuestStatusReport : Form
    {
        
        SqlConnection SQLCon = new SqlConnection(@"Data Source=.;Initial Catalog=SWENDatabase;Integrated Security=True ");
        public GuestStatusReport()
        {
            InitializeComponent();
        }

        private void GuestStatusReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'guestDataSet.Guest' table. You can move, or remove it, as needed.
            this.guestTableAdapter.Fill(this.guestDataSet.Guest);

        }

        private void bAllGuest_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection SQLCon = new System.Data.SqlClient.SqlConnection("Data Source=.;Initial Catalog=SWENDatabase;Integrated Security=True ");
            System.Data.DataTable Guestdata = new System.Data.DataTable();
            string query = "SELECT * from Guest Order by Room_No";
            System.Data.SqlClient.SqlDataAdapter SQLAdapter = new System.Data.SqlClient.SqlDataAdapter(query, SQLCon);
            SQLAdapter.Fill(Guestdata);
            GuestStatusGrid.DataSource = Guestdata;
        }

        private void bEachGuest_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection SQLCon = new System.Data.SqlClient.SqlConnection("Data Source=.;Initial Catalog=SWENDatabase;Integrated Security=True ");
            System.Data.DataTable Guestdata = new System.Data.DataTable();
            int result;
            bool isInt = int.TryParse(iRoomNo.Text, out result);
            if (String.IsNullOrEmpty(iRoomNo.Text))
            {
                string query = "SELECT * from Guest";
                System.Data.SqlClient.SqlDataAdapter SQLAdapter = new System.Data.SqlClient.SqlDataAdapter(query, SQLCon);
                SQLAdapter.Fill(Guestdata);
                GuestStatusGrid.DataSource = Guestdata;
            }
            else if (!isInt)
            {
                MessageBox.Show("Please input a valid number.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string query = "SELECT * from Guest";
                System.Data.SqlClient.SqlDataAdapter SQLAdapter = new System.Data.SqlClient.SqlDataAdapter(query, SQLCon);
                SQLAdapter.Fill(Guestdata);
                GuestStatusGrid.DataSource = Guestdata;

            }
            else
            {
                string query = "SELECT * FROM Guest where Room_No =";
                System.Data.SqlClient.SqlDataAdapter SQLAdapter = new System.Data.SqlClient.SqlDataAdapter(query + int.Parse(iRoomNo.Text), SQLCon);
                SQLAdapter.Fill(Guestdata);
                GuestStatusGrid.DataSource = Guestdata;
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportModule ss = new ReportModule();
            ss.Show();
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection SQLCon = new System.Data.SqlClient.SqlConnection("Data Source=.;Initial Catalog=SWENDatabase;Integrated Security=True ");
            System.Data.DataTable Guestdata = new System.Data.DataTable();
            string query = "SELECT * from Guest";
            System.Data.SqlClient.SqlDataAdapter SQLAdapter = new System.Data.SqlClient.SqlDataAdapter(query, SQLCon);
            SQLAdapter.Fill(Guestdata);
            GuestStatusGrid.DataSource = Guestdata;
        }
    }
}

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
    public partial class RoomOccupancy : Form
    {
        SqlDataAdapter sda;
        DataTable dt;
        public RoomOccupancy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SWENDatabase;Integrated Security=True");
            sda = new SqlDataAdapter(@"Select Booking_ID, Room_No, Customer_ID, Booking_StartDate, Booking_EndDate FROM Booking", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HmsHomepage ss = new HmsHomepage();
            ss.Show();
        }
    }
}

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
    public partial class BookingManagement : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SWENDatabase;Integrated Security=True ");
        public BookingManagement()
        {
            InitializeComponent();

        }




        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblReservationID_Click(object sender, EventArgs e)
        {

        }

        private void BookingManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sWENDatabaseDataSet23.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter1.Fill(this.sWENDatabaseDataSet23.Room);
            // TODO: This line of code loads data into the 'sWENDatabaseDataSet22.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.sWENDatabaseDataSet22.Room);
            // TODO: This line of code loads data into the 'sWENDatabaseDataSet17.Booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter3.Fill(this.sWENDatabaseDataSet17.Booking);

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Room";
    
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                RoomNumberCbox.Items.Add(dr["Room_No"].ToString());

            }
            con.Close();
            {

            }
            con.Open();
            SqlCommand cmd1 = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Customer";
            cmd.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {

                CustomeridCbox.Items.Add(dr["Customer_ID"].ToString());
            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateCust_Click(object sender, EventArgs e)
        {
            if (IsValidated())
            {

                if (MessageBox.Show("Are you sure you want to update this record", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    string query = "UPDATE Booking SET Room_No = '" + RoomNumberCbox.Text + "',Customer_ID='" + CustomeridCbox.Text + "',Booking_StartDate='" + ChkinDate.Text + "',Booking_EndDate='" + ChkoutDate.Text + "',Booking_Extention='" + BookingExtension.Text + "' ";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                    SDA.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Booking Updated!");
                }
            }
        }
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HmsHomepage ss = new HmsHomepage();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection("Data Source=.;Initial Catalog=SWENDatabase;Integrated Security=True ");
            System.Data.DataTable dt = new System.Data.DataTable();
            System.Data.SqlClient.SqlDataAdapter SDA = new System.Data.SqlClient.SqlDataAdapter("SELECT * from Booking", con);
            SDA.Fill(dt);
            BookingGridView.DataSource = dt;
         
        }

        private void btnCreateCust_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "INSERT INTO Booking(Room_No,Customer_ID,Booking_StartDate,Booking_EndDate,Booking_Extention) VALUES ('" + RoomNumberCbox.Text + "','" + CustomeridCbox.Text + "','" + ChkinDate.Text + "','" + ChkoutDate.Text + "','" + BookingExtension.Text + "') ";
           
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
           
            SDA.SelectCommand.ExecuteNonQuery();
           
            con.Close();
            MessageBox.Show("Inserted new reservation");


        }
        private bool IsValidated()
        {
          
            if (RoomNumberCbox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Double click on the existing rows you wish to update/delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                int tempage;
                bool isNumeric = int.TryParse(RoomNumberCbox.Text.Trim(), out tempage);

                if (!isNumeric)
                {
                    MessageBox.Show("Room number should be in integers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
           
            if (CustomeridCbox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Double click on the existing rows you wish to update/delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                int tempage;
                bool isNumeric = int.TryParse(CustomeridCbox.Text.Trim(), out tempage);

                if (!isNumeric)
                {
                    MessageBox.Show("Customer ID should be in integers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if (ChkinDate.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Double click on the existing rows you wish to update/delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (ChkoutDate.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Double click on the existing rows you wish to update/delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (BookingExtension.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Double click on the existing rows you wish to update/delete ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RoomsearchBox_TextChanged(object sender, EventArgs e)
        {

        }
        private bool SearchValidate()
        {
            if (BookingTxtbox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter a value into the search box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (SearchValidate())
            {
                DataTable dt = new DataTable();
                SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM Customer where Customer_ID =" + int.Parse(BookingTxtbox.Text), con);
                SDA.Fill(dt);
                BookingGridView.DataSource = dt;
            }
            }

        private void btnSearchBooking_Click(object sender, EventArgs e)
        {

        }


        private void btnDeleteCust_Click(object sender, EventArgs e)
        {
            if (IsValidated())
            {
                if (MessageBox.Show("Are you sure you want to delete this record", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    String query = "DELETE FROM Booking where Booking_ID= '" + BookingTxtbox.Text + "'";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                    SDA.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Deleted");

                }
            }
        }
        private void RoomNotxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BookingGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BookingTxtbox.Text = BookingGridView.SelectedRows[0].Cells[0].Value.ToString(); 
            RoomNumberCbox.Text = BookingGridView.SelectedRows[0].Cells[1].Value.ToString();
            CustomeridCbox.Text = BookingGridView.SelectedRows[0].Cells[2].Value.ToString();
            ChkinDate.Text = BookingGridView.SelectedRows[0].Cells[3].Value.ToString();
            ChkoutDate.Text = BookingGridView.SelectedRows[0].Cells[4].Value.ToString();
            BookingExtension.Text = BookingGridView.SelectedRows[0].Cells[5].Value.ToString();
         
        }

        private void BookingGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection("Data Source=.;Initial Catalog=SWENDatabase;Integrated Security=True ");
            System.Data.DataTable dt = new System.Data.DataTable();
            System.Data.SqlClient.SqlDataAdapter SDA = new System.Data.SqlClient.SqlDataAdapter("SELECT * from Booking", con);
            SDA.Fill(dt);
            BookingGridView.DataSource = dt;
        }
    }
}
        
    
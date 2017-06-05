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
    public partial class GuestMangementHome : Form
    {
        SqlConnection SQLCon = new SqlConnection(@"Data Source=.;Initial Catalog=SWENDatabase;Integrated Security=True ");
        public GuestMangementHome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'guestDataSet.Guest' table. You can move, or remove it, as needed.
            this.guestTableAdapter.Fill(this.guestDataSet.Guest);

        }
        private bool Validation()
        {
            String EmptyErrormessage = "A necessary field is empty. Please fill it before updating again. The field that is empty is: ";
            String NotIntegarErrormessage = "A field has the wrong datatype. Please enter only numbers in the field. The field that has the wrong datatype is: ";
            if (iGuestID.Text == string.Empty)
            {
                MessageBox.Show(EmptyErrormessage + " GuestID.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                int result;
                bool isInt = int.TryParse(iGuestID.Text, out result);
                if (!isInt)
                {
                    MessageBox.Show(NotIntegarErrormessage + " GuestID.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (vFirstName.Text == string.Empty)
            {
                MessageBox.Show(EmptyErrormessage + " First Name.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (vLastName.Text == string.Empty)
            {
                MessageBox.Show(EmptyErrormessage + " Last Name.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (dtDateOfBirth.Text == string.Empty)
            {
                MessageBox.Show(EmptyErrormessage + " DateOfBirth. The format is: Month/Day/Year ", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (vEmail.Text == string.Empty)
            {
                MessageBox.Show(EmptyErrormessage + " Email.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (iAge.Text == string.Empty)
            {
                MessageBox.Show(EmptyErrormessage + " Age.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                int result;
                bool isInt = int.TryParse(iAge.Text, out result);
                if (!isInt)
                {
                    MessageBox.Show(NotIntegarErrormessage + " Age.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if (vCountry.Text == string.Empty)
            {
                MessageBox.Show(EmptyErrormessage + " Country.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (vAddress.Text == string.Empty)
            {
                MessageBox.Show(EmptyErrormessage + " Address.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (iPostalCode.Text == string.Empty)
            {
                MessageBox.Show(EmptyErrormessage + " Postal Code.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                int result;
                bool isInt = int.TryParse(iPostalCode.Text, out result);
                if (!isInt)
                {
                    MessageBox.Show(NotIntegarErrormessage + " PostalCode.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if (iRoomID.Text == string.Empty)
            {
                MessageBox.Show(EmptyErrormessage + " Room ID.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                int result;
                bool isInt = int.TryParse(iRoomID.Text, out result);
                if (!isInt)
                {
                    MessageBox.Show(NotIntegarErrormessage + " Room ID.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private void GridGuestInfo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //ondoubleclick set the following into the textboxes above
            iGuestID.Text = GridGuestInfo.SelectedRows[0].Cells[0].Value.ToString();
            vFirstName.Text = GridGuestInfo.SelectedRows[0].Cells[1].Value.ToString();
            vLastName.Text = GridGuestInfo.SelectedRows[0].Cells[2].Value.ToString();
            iAge.Text = GridGuestInfo.SelectedRows[0].Cells[3].Value.ToString();
            dtDateOfBirth.Text = GridGuestInfo.SelectedRows[0].Cells[4].Value.ToString();
            vAddress.Text = GridGuestInfo.SelectedRows[0].Cells[5].Value.ToString();
            vCountry.Text = GridGuestInfo.SelectedRows[0].Cells[6].Value.ToString();
            iPostalCode.Text = GridGuestInfo.SelectedRows[0].Cells[7].Value.ToString();
            vEmail.Text = GridGuestInfo.SelectedRows[0].Cells[8].Value.ToString();
            iRoomID.Text = GridGuestInfo.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection SQLCon = new System.Data.SqlClient.SqlConnection("Data Source=.;Initial Catalog=SWENDatabase;Integrated Security=True ");
            System.Data.DataTable Guestdata = new System.Data.DataTable();
            int result;
            bool isInt = int.TryParse(iRoomID.Text, out result);
            if (String.IsNullOrEmpty(iRoomID.Text))
            {
                string query = "SELECT * from Guest";
                System.Data.SqlClient.SqlDataAdapter SQLAdapter = new System.Data.SqlClient.SqlDataAdapter(query, SQLCon);
                SQLAdapter.Fill(Guestdata);
                GridGuestInfo.DataSource = Guestdata;
            }
            else if (!isInt)
            {
                MessageBox.Show("Please input a valid number.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string query = "SELECT * from Guest";
                System.Data.SqlClient.SqlDataAdapter SQLAdapter = new System.Data.SqlClient.SqlDataAdapter(query, SQLCon);
                SQLAdapter.Fill(Guestdata);
                GridGuestInfo.DataSource = Guestdata;

            }
            else
            {
                string query = "SELECT * FROM Guest where Room_No =";
                System.Data.SqlClient.SqlDataAdapter SQLAdapter = new System.Data.SqlClient.SqlDataAdapter(query + int.Parse(iRoomID.Text), SQLCon);
                SQLAdapter.Fill(Guestdata);
                GridGuestInfo.DataSource = Guestdata;
            }

        }

        private void bReset_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection SQLCon = new System.Data.SqlClient.SqlConnection("Data Source=.;Initial Catalog=SWENDatabase;Integrated Security=True ");
            System.Data.DataTable Guestdata = new System.Data.DataTable();
            string query = "SELECT * from Guest";
            System.Data.SqlClient.SqlDataAdapter SQLAdapter = new System.Data.SqlClient.SqlDataAdapter(query, SQLCon);
            SQLAdapter.Fill(Guestdata);
            GridGuestInfo.DataSource = Guestdata;
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            if (Validation())
            {

                if (MessageBox.Show("Are you sure you want to update this record", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SQLCon.Open();
                    string query = "UPDATE Guest SET Guest_FirstName = '" + vFirstName.Text + "',Guest_LastName='" + vLastName.Text + "',Guest_Age='" + iAge.Text +
                        "',Guest_DOB='" + dtDateOfBirth.Text + "',Guest_Address='" + vAddress.Text + "',Guest_Country='" + vCountry.Text + "',Guest_PostalCode='" +
                        iPostalCode.Text + "',Guest_Email='" + vEmail.Text + "',Room_No='"
                        + iRoomID.Text + "' WHERE Guest_ID='" + iGuestID.Text + "' ";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, SQLCon);
                    SDA.SelectCommand.ExecuteNonQuery();
                    SQLCon.Close();
                    MessageBox.Show("Guest Updated!");
                }
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {

            if (Validation())
            {
                if (MessageBox.Show("Are you sure you want to delete all information of this guest?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SQLCon.Open();
                    String query = "DELETE FROM Guest where Guest_ID= '" + iGuestID.Text + "'";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, SQLCon);
                    SDA.SelectCommand.ExecuteNonQuery();
                    SQLCon.Close();
                    MessageBox.Show("Guest Deleted");
                }
            }
        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                if (MessageBox.Show("Are you sure you want to add this guest?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SQLCon.Open();
                    String query = "INSERT INTO Guest(Guest_ID,Guest_FirstName,Guest_LastName, Guest_Age,Guest_DOB,Guest_Address,Guest_Country,Guest_PostalCode,Guest_Email,Room_No) VALUES ('" + iGuestID.Text + "','" + vFirstName.Text + "','" + vLastName.Text + "','" + iAge.Text + "','" + dtDateOfBirth.Text + "','" + vAddress.Text + "','" + vCountry.Text + "','" + iPostalCode.Text + "','" + vEmail.Text + "','" + iRoomID.Text + "') ";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, SQLCon);
                    SDA.SelectCommand.ExecuteNonQuery();
                    SQLCon.Close();
                    MessageBox.Show("Guest has been added.");
                }
            }
        }

        private void iRoomID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

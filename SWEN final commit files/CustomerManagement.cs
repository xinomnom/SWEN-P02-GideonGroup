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
    public partial class btnCreateCustomer : Form
    {
        public btnCreateCustomer()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SWENDatabase;Integrated Security=True ");

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private bool IsValidated()
        {
            if (vFirstnameTxtBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Double click on the existing rows you wish to update/delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (vLastnameTxtBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Double click on the existing rows you wish to update/delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (iAgeTxtBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Double click on the existing rows you wish to update/delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                int tempage;
                bool isNumeric = int.TryParse(iAgeTxtBox.Text.Trim(), out tempage);

                if (!isNumeric)
                {
                    MessageBox.Show("Age should be in integers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
                if (vdateTxtBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Double click on the existing rows you wish to update/delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (iContactNoTxtBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Double click on the existing rows you wish to update/delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                int tempage;
                bool isNumeric = int.TryParse(iContactNoTxtBox.Text.Trim(), out tempage);

                if (!isNumeric)
                {
                    MessageBox.Show("Contact numbers should be in integers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
                if (vAddressTxtBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Double click on the existing rows you wish to update/delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (vCountryTxtBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Double click on the existing rows you wish to update/delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (iPostalCodeTxtBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Double click on the existing rows you wish to update/delete ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                int tempage;
                bool isNumeric = int.TryParse(iPostalCodeTxtBox.Text.Trim(), out tempage);
                if (!isNumeric)
                {
                    MessageBox.Show("Postal code should be in integers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if (vEmailTxtBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Double click on the existing rows you wish to update/delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
                return true;
            }
        

        private void BookingManagementH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sWENDatabaseDataSet13.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter6.Fill(this.sWENDatabaseDataSet13.Customer);
       
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnRefreshTable_Click_1(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection("Data Source=.;Initial Catalog=SWENDatabase;Integrated Security=True ");
            System.Data.DataTable dt = new System.Data.DataTable();
            System.Data.SqlClient.SqlDataAdapter SDA = new System.Data.SqlClient.SqlDataAdapter("SELECT * from Customer", con);
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "INSERT INTO Customer(Customer_NRIC,Customer_FirstName,Customer_LastName,Customer_Age,Customer_DOB,Customer_Address,Customer_Country,Customer_PostalCode,Customer_Email,Customer_ContactNo) VALUES ('" + vNRICTxtBox.Text + "','" + vFirstnameTxtBox.Text + "','" + vLastnameTxtBox.Text + "','" + iAgeTxtBox.Text +  "','" + vdateTxtBox.Text + "','" + vAddressTxtBox.Text+ "','" + vCountryTxtBox.Text + "','" + iPostalCodeTxtBox.Text + "','" + vEmailTxtBox.Text + "','"+iContactNoTxtBox.Text + "') ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Insert Success");
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBacktoHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HmsHomepage ss = new HmsHomepage();
            ss.Show();
        }

        private void btnDeleteCust_Click(object sender, EventArgs e)
        {
            if (IsValidated())
            {
                if (MessageBox.Show("Are you sure you want to delete this record", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    String query = "DELETE FROM Customer where Customer_ID= '" + searchBox.Text + "'";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                    SDA.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Deleted");
                }
            }

        }
        private bool SearchValidate()
        {
            if (searchBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter a value into the search box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)//search
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please enter the row ID");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (SearchValidate())
            {
                DataTable dt = new DataTable();
                SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM Customer where Customer_ID =" + int.Parse(searchBox.Text), con);
                SDA.Fill(dt);
                dataGridView1.DataSource = dt;
            }
    }

        private void btnUpdateCust_Click(object sender, EventArgs e)
        {
            if (IsValidated())
            {

                if (MessageBox.Show("Are you sure you want to update this record", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    string query = "UPDATE Customer SET Customer_NRIC = '" + vNRICTxtBox.Text + "',Customer_FirstName='" + vFirstnameTxtBox.Text + "',Customer_LastName='" + vLastnameTxtBox.Text + "',Customer_Age='" + iAgeTxtBox.Text + "',Customer_DOB='" + vdateTxtBox.Text + "',Customer_ContactNo='" + iContactNoTxtBox.Text + "',Customer_Address='" + vAddressTxtBox.Text + "',Customer_Country='" + vCountryTxtBox.Text + "',Customer_PostalCode='" + iPostalCodeTxtBox.Text + "',Customer_Email='" + vEmailTxtBox.Text + "' WHERE Customer_ID='" + searchBox.Text + "' ";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                    SDA.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Customer Updated!");
                }
            }
    }

        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            searchBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString(); // CustomerID

            vNRICTxtBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            vFirstnameTxtBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            vLastnameTxtBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            iAgeTxtBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            vdateTxtBox.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            vAddressTxtBox.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            vCountryTxtBox.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            iPostalCodeTxtBox.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            vEmailTxtBox.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            iContactNoTxtBox.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
        }

        private void vdobTxtBox(object sender, EventArgs e)
        {

        }
        public static void ClearAll(Control control)
        {
            foreach (Control c in control.Controls)
            {
                var texbox = c as TextBox;
                var comboBox = c as ComboBox;
              

                if (texbox != null)
                    texbox.Clear();
                if (comboBox != null)
                    comboBox.SelectedIndex = -1;
                
                if (c.HasChildren)
                    ClearAll(c);
            }
        }

        private void btnClear(object sender, EventArgs e)
        {
            ClearAll(this);

         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection("Data Source=.;Initial Catalog=SWENDatabase;Integrated Security=True ");
            System.Data.DataTable dt = new System.Data.DataTable();
            System.Data.SqlClient.SqlDataAdapter SDA = new System.Data.SqlClient.SqlDataAdapter("SELECT * from Customer", con);
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}

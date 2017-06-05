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
    public partial class StaffManagementH : Form
    {
        public StaffManagementH()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SWENDatabase;Integrated Security=True ");


        private void button6_Click(object sender, EventArgs e)//update
        {
            if (IsValidated())
            {

                if (MessageBox.Show("Are you sure you want to update this record", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    string query = "UPDATE Staff SET Staff_FirstName = '" + FirstName.Text + "',Staff_LastName='" + LastName.Text + "',Staff_Address='" + Address.Text + "',Staff_ContactNumber='" + ContactNum.Text + "',Staff_NRIC='" + vNRIC.Text + "',Staff_DOB='" + dateTimePicker1.Text + "',Staff_Salary='" + vSalary.Text + "',Staff_BankNo='" + vBankAccount.Text + "',Staff_PostalCode='" + iPostalCode.Text + "',Staff_Country='" + sCountry.Text + "',Staff_Email='" + vEmail.Text + "',Staff_Duty='" + sDuty.Text + "' WHERE Staff_ID='" + textBox13.Text + "' ";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                    SDA.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Staff Updated!");
                }
            }


        }


        private bool IsValidated()
        {
            if (FirstName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Double click on the existing rows you wish to update/delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (LastName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Double click on the existing rows you wish to update/delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (vNRIC.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Double click on the existing rows you wish to update/delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (dateTimePicker1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Double click on the existing rows you wish to update/delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (vEmail.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Double click on the existing rows you wish to update/delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (ContactNum.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Double click on the existing rows you wish to update/delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                int tempage;
                bool isNumeric = int.TryParse(ContactNum.Text.Trim(), out tempage);
                if (!isNumeric)
                {
                    MessageBox.Show("Contact numbers should be in integers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if (sCountry.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Double click on the existing rows you wish to update/delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Address.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Double click on the existing rows you wish to update/delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (iPostalCode.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Double click on the existing rows you wish to update/delete ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                int tempage;
                bool isNumeric = int.TryParse(iPostalCode.Text.Trim(), out tempage);
                if (!isNumeric)
                {
                    MessageBox.Show("Postal code should be in integers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if (sDuty.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Double click on the existing rows you wish to update/delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (vSalary.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Double click on the existing rows you wish to update/delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (vBankAccount.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Double click on the existing rows you wish to update/delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }




            return true;
        }







        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)//double click to update/delete 
        {
            textBox13.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//id

            FirstName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            LastName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Address.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            ContactNum.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            vNRIC.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            vSalary.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            vBankAccount.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            iPostalCode.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            sCountry.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            vEmail.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            sDuty.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
      

        }

        private void button3_Click(object sender, EventArgs e)//create
        {

            StaffManagementC ss = new StaffManagementC();
            ss.Show();
        }

        private void button4_Click(object sender, EventArgs e)//delete
        {
            if (IsValidated())
            {
                if (MessageBox.Show("Are you sure you want to delete this record", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    String query = "DELETE FROM Staff where Staff_ID= '" + textBox13.Text + "'";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                    SDA.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Deleted");
                }
            }

        }

        private void StaffManagementH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sWENDatabaseDataSet1.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter1.Fill(this.sWENDatabaseDataSet1.Staff);
 

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)//FirstName
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)//search ID
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)//SearchButton
        {

            if (SearchValidate())
            {
                DataTable dt = new DataTable();
                SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM Staff where Staff_ID =" + int.Parse(textBox13.Text), con);
                SDA.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private bool SearchValidate()
        {
            if (textBox13.Text.Trim() == string.Empty)
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

        private void button7_Click(object sender, EventArgs e)//Display All button
        {
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection("Data Source=.;Initial Catalog=SWENDatabase;Integrated Security=True ");
            System.Data.DataTable dt = new System.Data.DataTable();
            System.Data.SqlClient.SqlDataAdapter SDA = new System.Data.SqlClient.SqlDataAdapter("SELECT * from Staff", con);
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
        }



        private void textBox4_TextChanged(object sender, EventArgs e)//DOB
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)//Last Name
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)//NRIC
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)//Email
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)//Contact Number
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//Country
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)//Address
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)//Postal Code
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)//Duty
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)//Salary
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)//Bank a/n
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//Back
        {
            this.Hide();
            HmsHomepage ss = new HmsHomepage();
            ss.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            StaffManagementHelp ss = new StaffManagementHelp();
            ss.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
            base.OnKeyPress(e);
            MessageBox.Show("Only alphabets are allowed");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
          //  DateTime date = DateTime.ParseExact(this.dateTimePicker1, "dd/mm/yyyy", null);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            HmsHomepage ss = new HmsHomepage();
            ss.Show();
        }
    }
}
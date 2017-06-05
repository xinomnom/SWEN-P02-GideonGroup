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
    public partial class StaffManagementC : Form
    {
        public StaffManagementC()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SWENDatabase;Integrated Security=True ");

        private void button2_Click(object sender, EventArgs e)//Back
        {
            this.Hide();
            StaffManagementH ss = new StaffManagementH();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)//Submit
        {

            

            if (IsValidated())
            {
                if (MessageBox.Show("Are you sure you want to create this record", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                con.Open();
                String query = "INSERT INTO Staff(Staff_FirstName,Staff_LastName, Staff_Address,Staff_ContactNumber,Staff_NRIC,Staff_DOB,Staff_Salary,Staff_BankNo,Staff_PostalCode,Staff_Country,Staff_Email,Staff_Duty) VALUES ('" + sFirstNameCreate.Text + "','" + sLastNameCreate.Text + "','" + vAddressCreate.Text + "','" + iContactNumCreate.Text + "','" + vNRICCreate.Text + "','" + dateTimePicker1.Text + "','" + vSalaryCreate.Text + "','" + vBankNumberCreate.Text + "','" + iPostalCodeCreate.Text + "','" + sCountryCreate.Text + "','" + vEmailCreate.Text + "','" + sDutyCreate.Text + "') ";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Insert Success");
                }
            }


                
            
        }

        private bool IsValidated()// Check if the create boxes are empty
        {
           if(sFirstNameCreate.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Staff first name is required","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
           if(sLastNameCreate.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Staff last name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (vNRICCreate.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Staff NRIC is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (dateTimePicker1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Staff DOB is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (vEmailCreate.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Staff email is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (iContactNumCreate.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Staff contact number is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                int tempage;
                bool isNumeric = int.TryParse(iContactNumCreate.Text.Trim(), out tempage);
                if(!isNumeric)
                {
                    MessageBox.Show("Contact numbers should be in integers", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return false;
                }
            }
            if (sCountryCreate.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Staff country is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (vAddressCreate.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Staff address is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (iPostalCodeCreate.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Staff postal code is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                int tempage;
                bool isNumeric = int.TryParse(iPostalCodeCreate.Text.Trim(), out tempage);
                if (!isNumeric)
                {
                    MessageBox.Show("Postal code should be in integers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if (sDutyCreate.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Staff duty is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (vSalaryCreate.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Staff salary is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (vBankNumberCreate.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Staff bank account number is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//First name
        {
          
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)//Last name
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)//NRIC
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)//DOB
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)//Email
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)//Contact number
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//Country
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)//Address
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)//postal code
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)//duty
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)//Salary
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)//Bank account
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StaffManagementC_Load(object sender, EventArgs e)//close
        {

        }

        private void button2_Click_1(object sender, EventArgs e)//backbutton
        {
            
            StaffManagementH ss = new StaffManagementH();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)//cancel button
        {
            this.Close();
        }

      

        private void sCountryCreate_KeyDown(object sender, KeyEventArgs e)
        {
      
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

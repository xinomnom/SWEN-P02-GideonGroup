using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWENWindowForm
{
    public partial class HmsHomepageUser : Form
    {
        public HmsHomepageUser()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookingManagement ss = new BookingManagement();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportModule ss = new ReportModule();
            ss.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffManagementH ss = new StaffManagementH();
            ss.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            btnCreateCustomer ss = new btnCreateCustomer();
            ss.Show();
        }
    }
}

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
    public partial class ReportModule : Form
    {
        public ReportModule()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            HousekeepingScheduleReport ss = new HousekeepingScheduleReport();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HmsHomepage ss = new HmsHomepage();
            ss.Show();           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomOccupancy ss = new RoomOccupancy();
            ss.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomStatusReport ss = new RoomStatusReport();
            ss.Show();
        }
    }
}

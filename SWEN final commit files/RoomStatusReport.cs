﻿using System;
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
    public partial class RoomStatusReport : Form
    {
        public RoomStatusReport()
        {
            InitializeComponent();
        }

        private void RoomStatusReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sWENDatabaseDataSet24.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.sWENDatabaseDataSet24.Room);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportModule ss = new ReportModule();
            ss.Show();


        }
    }
}

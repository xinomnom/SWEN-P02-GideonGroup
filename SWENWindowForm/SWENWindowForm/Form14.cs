using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SWENWindowForm.Logic_Layer;
namespace SWENWindowForm
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StaffLL objLL = new StaffLL();
            dataGridView1.DataSource = objLL.getStaff();
        }
    }
}

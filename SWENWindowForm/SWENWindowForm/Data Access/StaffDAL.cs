using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace SWENWindowForm.Data_Access
{
    public class StaffDAL
    {
        DataTable dt = new DataTable();

        public DataTable readStaff()
        {
            Connection connect = new Connection();
            if (ConnectionState.Closed == connect.con.State)// incase the database is closed
            {
                connect.con.Open();
            }


            SqlCommand cmd = new SqlCommand("Select * From Staff", connect.con);

            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch
            {
                throw;
            }

        }



    }
}

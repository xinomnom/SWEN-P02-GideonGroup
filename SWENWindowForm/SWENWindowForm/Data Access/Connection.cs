using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace SWENWindowForm.Data_Access
{
    public class Connection
    {
        public SqlConnection con=new SqlConnection("Data Source=.;Initial Catalog=SWENDatabase;Integrated Security=True");

    }
}

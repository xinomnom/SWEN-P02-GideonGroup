using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SWENWindowForm.Data_Access;
namespace SWENWindowForm.Logic_Layer
{
    public class StaffLL
    {
        public DataTable getStaff()
        {
            try
            {
                StaffDAL obj = new StaffDAL();//calling from the data access
                return obj.readStaff();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

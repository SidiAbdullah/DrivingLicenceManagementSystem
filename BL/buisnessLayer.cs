using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLicenseManagement.BL
{
    internal class buisnessLayer
    {
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
        public DataTable getAllPeople()
        {
            DataTable dt = new DataTable();
            dt = dal.ExecuteQuery("getAllPeople", null);
            return dt;
        }
    }
}

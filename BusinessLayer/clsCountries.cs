using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLicenseManagement.BusinessLayer
{
    internal class clsCountries
    {
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

        public DataTable getAllCountries()
        {
            return dal.ExecuteQuery("getAllCountries", null);
        }

    }
}

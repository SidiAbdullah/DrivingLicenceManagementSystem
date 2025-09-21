using System;
using System.Data;
using System.Data.SqlClient;

namespace DrivingLicenseManagement.BL
{
    internal class buisnessLayer
    {
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

        public DataTable getPersonByID(int personID)
        {
            SqlParameter[] parameters = { new SqlParameter("@PersonID", personID) };
            return dal.ExecuteQuery("getPersonByID", parameters);
        }

        public DataTable getPersonByNationalNo(string nationalNo)
        {
            SqlParameter[] parameters = { new SqlParameter("@NationalNo", nationalNo) };
            return dal.ExecuteQuery("getPersonByNationalNo", parameters);
        }

        public DataTable getAllPeople()
        {
            return dal.ExecuteQuery("getAllPeople", null);
        }

        public void addNewPerson(
            string nationalNo, string firstName, string secondName, string thirdName, string lastName,
            DateTime dateOfBirth, byte gendor, string address, string phone, string email,
            int nationalityCountryID, string imagePath)
        {
            string[] paramNames = {
                "@NationalNo","@FirstName","@SecondName","@ThirdName","@LastName",
                "@DateOfBirth","@Gendor","@Address","@Phone","@Email","@NationalityCountryID","@ImagePath"
            };

            object[] values = {
                nationalNo, firstName, secondName, thirdName, lastName,
                dateOfBirth, gendor, address, phone, email, nationalityCountryID, imagePath
            };

            SqlParameter[] parameters = new SqlParameter[paramNames.Length];
            for (int i = 0; i < paramNames.Length; i++)
                parameters[i] = new SqlParameter(paramNames[i], values[i]);

            dal.ExecuteNonQuery("addNewPerson", parameters);
        }

        public void updatePerson(
            string nationalNo, string firstName, string secondName, string thirdName, string lastName,
            DateTime dateOfBirth, byte gendor, string address, string phone, string email,
            int nationalityCountryID, string imagePath)
        {
            string[] paramNames = {
                "@NationalNo","@FirstName","@SecondName","@ThirdName","@LastName",
                "@DateOfBirth","@Gendor","@Address","@Phone","@Email","@NationalityCountryID","@ImagePath"
            };

            object[] values = {
                nationalNo, firstName, secondName, thirdName, lastName,
                dateOfBirth, gendor, address, phone, email, nationalityCountryID, imagePath
            };

            SqlParameter[] parameters = new SqlParameter[paramNames.Length];
            for (int i = 0; i < paramNames.Length; i++)
                parameters[i] = new SqlParameter(paramNames[i], values[i]);

            dal.ExecuteNonQuery("updatePerson", parameters);
        }

        public void deletePerson(string nationalNo)
        {
            SqlParameter[] parameters = { new SqlParameter("@NationalNo", nationalNo) };
            dal.ExecuteNonQuery("deletePerson", parameters);
        }

        public bool isPersonExistByID(int PersonID)
        {
            SqlParameter[] parameters = { new SqlParameter("@PersonID", PersonID) };
            object result = dal.ExecuteScalar("isPersonExist", parameters);
            return result != null && Convert.ToInt32(result) > 0;
        }

        public bool isPersonExistByNationalNo(string NationalNo)
        {
            SqlParameter[] parameters = { new SqlParameter("@NationalNo", NationalNo) };
            object result = dal.ExecuteScalar("isPersonExistByNationalNo", parameters);
            return result != null && Convert.ToInt32(result) > 0;
        }
    }
}

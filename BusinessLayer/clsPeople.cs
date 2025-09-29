using System;
using System.Data;
using System.Data.SqlClient;

namespace DrivingLicenseManagement.BL
{
    internal class clsPeople
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

        public DataTable getPersonByFirstName(string firstName)
        {
            SqlParameter[] parameters = { new SqlParameter("@FirstName", firstName) };
            return dal.ExecuteQuery("getPersonByFirstName", parameters);
        }

        public DataTable getPersonBySecondName(string secondName)
        {
            SqlParameter[] parameters = { new SqlParameter("@SecondName", secondName) };
            return dal.ExecuteQuery("getPersonBySecondName", parameters);
        }

        public DataTable getPersonByThirdName(string thirdName)
        {
            SqlParameter[] parameters = { new SqlParameter("@ThirdName", thirdName) };
            return dal.ExecuteQuery("getPersonByThirdName", parameters);
        }

        public DataTable getPersonByLastName(string lastName)
        {
            SqlParameter[] parameters = { new SqlParameter("@LastName", lastName) };
            return dal.ExecuteQuery("getPersonByLastName", parameters);
        }
        // getPersonByNationalityCountry
        public DataTable getPersonByGendor(string gendorText)
        {
            byte gendorValue;

            if (gendorText.Equals("Male", StringComparison.OrdinalIgnoreCase))
                gendorValue = 0;
            else if (gendorText.Equals("Female", StringComparison.OrdinalIgnoreCase))
                gendorValue = 1;
            else if (!byte.TryParse(gendorText, out gendorValue))
                throw new ArgumentException("Invalid Gendor value");

            SqlParameter[] parameters = { new SqlParameter("@Gendor", gendorValue) };
            return dal.ExecuteQuery("getPersonByGendor", parameters);
        }
        public DataTable getPersonByGmail(string gmail)
        {
            SqlParameter[] parameters = { new SqlParameter("@Gmail", gmail) };
            return dal.ExecuteQuery("getPersonByGmail", parameters);
        }

        public DataTable getPersonByPhone(string phone)
        {
            SqlParameter[] parameters = { new SqlParameter("@Phone", phone) };
            return dal.ExecuteQuery("getPersonByPhone", parameters);
        }

        public DataTable getAllPeople()
        {
            return dal.ExecuteQuery("getAllPeople", null);
        }
        public byte[] GetPersonPhoto(int personID)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@personID", personID);
            object result = dal.ExecuteScalar("GetPersonPhoto", parameters);

            if (result != null && result != DBNull.Value)
                return (byte[])result;

            return null;
        }

        public void addNewPerson(
            string nationalNo, string firstName, string secondName, string thirdName, string lastName,
            DateTime dateOfBirth, byte gendor, string address, string phone, string email,
            int nationalityCountryID, byte[] image)
        {
            string[] paramNames = {
                "@NationalNo","@FirstName","@SecondName","@ThirdName","@LastName",
                "@DateOfBirth","@Gendor","@Address","@Phone","@Email","@NationalityCountryID","@Image"
            };

            object[] values = {
                nationalNo, firstName, secondName, thirdName, lastName,
                dateOfBirth, gendor, address, phone, email, nationalityCountryID, image
            };

            SqlParameter[] parameters = new SqlParameter[paramNames.Length];
            for (int i = 0; i < paramNames.Length; i++)
                parameters[i] = new SqlParameter(paramNames[i], values[i]);

            dal.ExecuteNonQuery("addNewPerson", parameters);
        }

        public void updatePerson(
            string nationalNo, string firstName, string secondName, string thirdName, string lastName,
            DateTime dateOfBirth, byte gendor, string address, string phone, string email,
            int nationalityCountryID, byte[] image)
        {
            string[] paramNames = {
                "@NationalNo","@FirstName","@SecondName","@ThirdName","@LastName",
                "@DateOfBirth","@Gendor","@Address","@Phone","@Email","@NationalityCountryID","@Image"
            };

            object[] values = {
                nationalNo, firstName, secondName, thirdName, lastName,
                dateOfBirth, gendor, address, phone, email, nationalityCountryID, image
            };

            SqlParameter[] parameters = new SqlParameter[paramNames.Length];
            for (int i = 0; i < paramNames.Length; i++)
                parameters[i] = new SqlParameter(paramNames[i], values[i]);

            dal.ExecuteNonQuery("updatePerson", parameters);
        }

        public void deletePerson(int personID)
        {
            SqlParameter[] parameters = { new SqlParameter("@personID", personID) };
            dal.ExecuteNonQuery("deletePerson", parameters);
        }
    }
}

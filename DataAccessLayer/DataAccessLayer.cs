using System;
using System.Data;
using System.Data.SqlClient;

namespace DrivingLicenseManagement.DAL
{
    internal class DataAccessLayer
    {
        private readonly string connectionString = "Server = .; Database = DVLD;User = sa; Password = 123456";
        private SqlConnection connection;

        public DataAccessLayer()
        {
            connection = new SqlConnection(connectionString);
        }
        public DataTable ExecuteQuery(string storedProcedure, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(storedProcedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                    command.Parameters.AddRange(parameters);

                SqlDataReader reader = command.ExecuteReader();
                dt.Load(reader);
                reader.Close();
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }
        public void ExecuteNonQuery(string storedProcedure, params SqlParameter[] parameters)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(storedProcedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                    command.Parameters.AddRange(parameters);

                command.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

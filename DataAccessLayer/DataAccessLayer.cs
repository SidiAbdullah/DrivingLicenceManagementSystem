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
        public int ExecuteNonQuery(string storedProcedure, params SqlParameter[] parameters)
        {
            int recordsCount = 0;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(storedProcedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                    command.Parameters.AddRange(parameters);

                recordsCount = command.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
            return recordsCount;
        }
        public object ExecuteScalar(string storedProcedure, params SqlParameter[] parameters)
        {
            object result = null;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(storedProcedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                    command.Parameters.AddRange(parameters);

                result = command.ExecuteScalar();
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
    }
}

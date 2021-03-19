using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ProductManagementSystem.DAL.Utility
{
    public static class DaoUtility
    {
        public static string CreateConnectionString()
        {            
            try
            {
                var allSettings = ConfigurationManager.ConnectionStrings;
                var epsilonDbSetting = allSettings["epsilonDbConStr"];

                return epsilonDbSetting.ConnectionString;
            }
            catch (Exception ex)
            { 
                throw ex;
            }
        }

        public static IDbConnection CreateConnection(string connectionString)
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                return connection;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static IDbCommand CreateCommand(IDbConnection connection,
            string queryOrProcedure, CommandType commandType)
        {
            SqlCommand sqlCommand = null;
            try
            {
                sqlCommand = new SqlCommand(queryOrProcedure, connection as SqlConnection);
                sqlCommand.CommandType = commandType;
                return sqlCommand;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void OpenConnection(IDbConnection connection)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public static void CloseConnection(IDbConnection connection)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public static string GetProcedure(string keyProcedure)
        {
            try
            {
                return ConfigurationManager.AppSettings[keyProcedure];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static IDataParameter CreateParameter(string paramName, object paramValue, SqlDbType dbType, ParameterDirection direction)
        {
            SqlParameter parameter = null;
            try
            {
                parameter = new SqlParameter();
                parameter.ParameterName = paramName;
                parameter.Value = paramValue;
                parameter.SqlDbType = dbType;
                parameter.Direction = direction;

                return parameter;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

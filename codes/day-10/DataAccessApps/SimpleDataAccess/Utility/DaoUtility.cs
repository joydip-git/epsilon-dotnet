﻿using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SimpleDataAccess.Utility
{
    //public enum Database
    //{
    //    SQL,
    //    Oracle,
    //    OleDb,
    //    Others
    //}
    public static class DaoUtility
    {
        //private static Database databaseChoice;
        //public static Database DatabaseChoice
        //{
        //    set { databaseChoice = value; }
        //    get { return databaseChoice; }
        //}
        public static string CreateConnectionString()
        {
            //Console.Write("enter server name: ");
            //string serverName = Console.ReadLine();

            //Console.Write("enter database name: ");
            //string dbName = Console.ReadLine();

            //return $"server={serverName};database={dbName};integrated security=sspi";

            //read configurations from config file using this class
            var allSettings = ConfigurationManager.ConnectionStrings;
            var epsilonDbSetting = allSettings["epsilonDbConStr"];

            return epsilonDbSetting.ConnectionString;
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

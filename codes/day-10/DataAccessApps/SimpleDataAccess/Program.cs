using System;
using System.Data; //ConnectionState, CommandType enum
using System.Data.SqlClient; //SqlConnection, SqlCommand

namespace SimpleDataAccess
{
    class Program
    {
        static string CreateConnectionString()
        {
            Console.Write("enter server name: ");
            string serverName = Console.ReadLine();

            Console.Write("enter database name: ");
            string dbName = Console.ReadLine();

            return $"server={serverName};database={dbName};integrated security=sspi";
        }
        static IDbConnection CreateConnection(string connectionString)
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
        static IDbCommand CreateCommand(IDbConnection connection, string query)
        {
            SqlCommand sqlCommand = null;
            try
            {
                sqlCommand = new SqlCommand(query, connection as SqlConnection);
                return sqlCommand;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        static void OpenConnection(IDbConnection connection)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        static DataTable ExecuteAndGetData(IDbCommand command)
        {
            SqlDataReader reader = null;
            SqlCommand sqlCommand = command as SqlCommand;
            DataTable productTable = null;
            try
            {
                reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    productTable = new DataTable("producttable");
                    productTable.Load(reader);
                }
                reader.Close();
                return productTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        static void CloseConnection(IDbConnection connection)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        static void ShowRecords(DataTable table)
        {
            if (table != null)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    //DataRow row = table.Rows[i];
                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        //Console.Write(row[j] + "\t");
                        Console.Write(table.Rows[i][j]+"\t");
                    }
                    Console.WriteLine("\n");
                }
            }
        }
        static void Main()
        {
            string connectionString = null;
            IDbConnection connection = null;
            IDbCommand command = null;
            DataTable productTable = null;
            try
            {
                connectionString = CreateConnectionString();
                if (connectionString != null && connectionString != string.Empty)
                {
                    connection = CreateConnection(connectionString);
                    if (connection != null)
                    {
                        command = CreateCommand(connection, "select productid as ID, productname as NAME, productdescription as DESCRIPTION, price as PRICE from products");
                        if (command != null)
                        {
                            OpenConnection(connection);
                            productTable = ExecuteAndGetData(command);
                            ShowRecords(productTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                CloseConnection(connection);
            }
        }
    }
}

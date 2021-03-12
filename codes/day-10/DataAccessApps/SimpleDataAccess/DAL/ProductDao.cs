using SimpleDataAccess.Contracts;
using SimpleDataAccess.Entities;
using SimpleDataAccess.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SimpleDataAccess.DAL
{
    public class ProductSqlDao : IDao<Product>
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllRecords()
        {
            string connectionString = null;
            //IDbConnection connection = null;
            SqlConnection connection = null;
            //IDbCommand command = null;
            SqlCommand command = null;
            //DataTable productTable = null;
            List<Product> products = null;
            SqlDataReader reader = null;

            try
            {
                connectionString = DaoUtility.CreateConnectionString();
                if (connectionString != null && connectionString != string.Empty)
                {
                    connection = (SqlConnection)DaoUtility.CreateConnection(connectionString);
                    if (connection != null)
                    {
                        //preferrable
                        //string procedureName = DaoUtility.GetProcedure("GETPRODUCTS");
                        //command = (SqlCommand)DaoUtility.CreateCommand(
                        //    connection,
                        //    procedureName,
                        //    CommandType.StoredProcedure
                        //    );

                        command = (SqlCommand)DaoUtility.CreateCommand(
                            connection,
                            Procedures.GETPRODUCTS,
                            CommandType.StoredProcedure
                            );

                        if (command != null)
                        {
                            DaoUtility.OpenConnection(connection);
                            //productTable = ExecuteAndGetData(command);

                            reader = command.ExecuteReader();
                            if (reader.HasRows)
                            {
                                CreateListFromReader(reader, ref products);
                            }
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DaoUtility.CloseConnection(connection);
            }
            return products;
        }

        public bool Insert(Product data)
        {
            SqlConnection connection = null;
            string connectionString = null;
            SqlCommand command = null;
            int result = 0;
            try
            {
                connectionString = DaoUtility.CreateConnectionString();
                if (connectionString != null && connectionString != string.Empty)
                {
                    connection = (SqlConnection)DaoUtility.CreateConnection(connectionString);
                    if (connection != null)
                    {

                        string procedureName = DaoUtility.GetProcedure("ADDPRODUCT");
                        command = (SqlCommand)DaoUtility.CreateCommand(connection, procedureName, CommandType.StoredProcedure);

                        /*
                        //string query = "insert into products(productname,productdescription,price) values(@pname,@pdesc,@price)";
                        string query = $"insert into products(productname,productdescription,price) values({data.ProductName},{data.Description},{data.Price})";
                        command = (SqlCommand)DaoUtility.CreateCommand(connection, query, CommandType.Text);
                        */

                        //create parameters defined in the query or stored procedure
                        SqlParameter nameParameter = (SqlParameter)DaoUtility.CreateParameter("@pname", data.ProductName, SqlDbType.VarChar, ParameterDirection.Input);
                        SqlParameter descParameter = (SqlParameter)DaoUtility.CreateParameter("@pdesc", data.Description, SqlDbType.VarChar, ParameterDirection.Input);
                        SqlParameter priceParameter = (SqlParameter)DaoUtility.CreateParameter("@price", data.Price, SqlDbType.Decimal, ParameterDirection.Input);

                        //add them in the collection of parameters of command object
                        command.Parameters.Add(nameParameter);
                        command.Parameters.Add(descParameter);
                        command.Parameters.Add(priceParameter);

                        if (command != null)
                        {
                            DaoUtility.OpenConnection(connection);
                            result = command.ExecuteNonQuery();
                        }
                    }
                }
                return result > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DaoUtility.CloseConnection(connection);
            }
        }

        public bool Update(Product data)
        {
            throw new NotImplementedException();
        }

        private void CreateListFromReader(SqlDataReader reader, ref List<Product> products)
        {
            products = new List<Product>();

            while (reader.Read())
            {
                Product product = new Product();
                //product.ProductId = (int)reader["productid"];
                product.ProductId = (int)reader["ID"];
                product.ProductName = (string)reader["NAME"];
                product.Description = (string)reader["DESCRIPTION"];
                product.Price = (decimal)reader["PRICE"];

                products.Add(product);
            }
        }
    }
}

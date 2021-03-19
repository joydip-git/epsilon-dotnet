using ProductManagementSystem.DAL.Contracts;
using ProductManagementSystem.Entities;
using static ProductManagementSystem.DAL.Utility.DaoUtility;
using static ProductManagementSystem.DAL.Utility.Procedures;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ProductManagementSystem.DAL.Implementation
{
    public class ProductDao : IDao<Product>
    {
        public bool Add(Product obj)
        {
            SqlConnection connection = null;
            string connectionString = null;
            SqlCommand command = null;
            int result = 0;
            try
            {
                connectionString = CreateConnectionString();
                if (connectionString != null && connectionString != string.Empty)
                {
                    connection = (SqlConnection)CreateConnection(connectionString);
                    if (connection != null)
                    {

                        //string procedureName = GetProcedure("ADDPRODUCT");
                        //command = (SqlCommand)CreateCommand(connection, procedureName, CommandType.StoredProcedure);

                        //from Procedures file
                        command = (SqlCommand)CreateCommand(connection, ADDPRODUCT, CommandType.StoredProcedure);

                        SqlParameter nameParameter = (SqlParameter)CreateParameter("@pname", obj.ProductName, SqlDbType.VarChar, ParameterDirection.Input);
                        SqlParameter descParameter = (SqlParameter)CreateParameter("@pdesc", obj.Description, SqlDbType.VarChar, ParameterDirection.Input);
                        SqlParameter priceParameter = (SqlParameter)CreateParameter("@price", obj.Price, SqlDbType.Decimal, ParameterDirection.Input);

                        //add them in the collection of parameters of command object
                        command.Parameters.Add(nameParameter);
                        command.Parameters.Add(descParameter);
                        command.Parameters.Add(priceParameter);

                        if (command != null)
                        {
                            OpenConnection(connection);
                            result = command.ExecuteNonQuery();
                        }
                    }
                }
                return result > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                CloseConnection(connection);
            }
        }

        public bool Delete(int id)
        {
            SqlConnection connection = null;
            string connectionString = null;
            SqlCommand command = null;
            int result = 0;
            try
            {
                connectionString = CreateConnectionString();
                if (connectionString != null && connectionString != string.Empty)
                {
                    connection = (SqlConnection)CreateConnection(connectionString);
                    if (connection != null)
                    {

                        //string procedureName = GetProcedure("DELETEPRODUCT");
                        //command = (SqlCommand)CreateCommand(connection, procedureName, CommandType.StoredProcedure);

                        //from Procedures file
                        command = (SqlCommand)CreateCommand(connection, DELETEPRODUCT, CommandType.StoredProcedure);

                        SqlParameter idParameter = (SqlParameter)CreateParameter("@pid", id, SqlDbType.Int, ParameterDirection.Input);

                        //add them in the collection of parameters of command object
                        command.Parameters.Add(idParameter);

                        if (command != null)
                        {
                            OpenConnection(connection);
                            result = command.ExecuteNonQuery();
                        }
                    }
                }
                return result > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                CloseConnection(connection);
            }
        }

        public Product Get(int id)
        {
            string connectionString = null;
            SqlConnection connection = null;
            SqlCommand command = null;
            Product product = null;
            SqlDataReader reader = null;

            try
            {
                connectionString = CreateConnectionString();
                if (connectionString != null && connectionString != string.Empty)
                {
                    connection = (SqlConnection)CreateConnection(connectionString);
                    if (connection != null)
                    {
                        //preferrable
                        //string procedureName = GetProcedure("GETPRODUCT");
                        //command = (SqlCommand)CreateCommand(
                        //    connection,
                        //    procedureName,
                        //    CommandType.StoredProcedure
                        //    );

                        //from Procedures file
                        command = (SqlCommand)CreateCommand(
                            connection,
                            GETPRODUCT,
                            CommandType.StoredProcedure
                            );

                        SqlParameter idParameter = (SqlParameter)CreateParameter("@pid", id, SqlDbType.Int, ParameterDirection.Input);

                        //add them in the collection of parameters of command object
                        command.Parameters.Add(idParameter);

                        if (command != null)
                        {
                            OpenConnection(connection);

                            reader = command.ExecuteReader();
                            if (reader.HasRows)
                            {
                                CreateProductFromReader(reader, ref product);
                            }
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                CloseConnection(connection);
            }
            return product;
        }

        public List<Product> GetAll()
        {
            string connectionString = null;
            SqlConnection connection = null;
            SqlCommand command = null;
            List<Product> products = null;
            SqlDataReader reader = null;

            try
            {
                connectionString = CreateConnectionString();
                if (connectionString != null && connectionString != string.Empty)
                {
                    connection = (SqlConnection)CreateConnection(connectionString);
                    if (connection != null)
                    {
                        //preferrable
                        //string procedureName = GetProcedure("GETPRODUCTS");
                        //command = (SqlCommand)CreateCommand(
                        //    connection,
                        //    procedureName,
                        //    CommandType.StoredProcedure
                        //    );

                        //from Procedures file
                        command = (SqlCommand)CreateCommand(
                            connection,
                            GETPRODUCTS,
                            CommandType.StoredProcedure
                            );

                        if (command != null)
                        {
                            OpenConnection(connection);
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
            catch (Exception)
            {
                throw;
            }
            finally
            {
                CloseConnection(connection);
            }
            return products;
        }

        public bool Update(Product obj)
        {
            SqlConnection connection = null;
            string connectionString = null;
            SqlCommand command = null;
            int result = 0;
            try
            {
                connectionString = CreateConnectionString();
                if (connectionString != null && connectionString != string.Empty)
                {
                    connection = (SqlConnection)CreateConnection(connectionString);
                    if (connection != null)
                    {

                        //string procedureName = GetProcedure("UPDATEPRODUCT");
                        //command = (SqlCommand)CreateCommand(connection, procedureName, CommandType.StoredProcedure);

                        //from Procedures file
                        command = (SqlCommand)CreateCommand(connection, UPDATEPRODUCT, CommandType.StoredProcedure);

                        SqlParameter idParameter = (SqlParameter)CreateParameter("@pid", obj.ProductId, SqlDbType.Int, ParameterDirection.Input);
                        SqlParameter nameParameter = (SqlParameter)CreateParameter("@pname", obj.ProductName, SqlDbType.VarChar, ParameterDirection.Input);
                        SqlParameter descParameter = (SqlParameter)CreateParameter("@pdesc", obj.Description, SqlDbType.VarChar, ParameterDirection.Input);
                        SqlParameter priceParameter = (SqlParameter)CreateParameter("@price", obj.Price, SqlDbType.Decimal, ParameterDirection.Input);

                        //add them in the collection of parameters of command object
                        command.Parameters.Add(idParameter);
                        command.Parameters.Add(nameParameter);
                        command.Parameters.Add(descParameter);
                        command.Parameters.Add(priceParameter);

                        if (command != null)
                        {
                            OpenConnection(connection);
                            result = command.ExecuteNonQuery();
                        }
                    }
                }
                return result > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                CloseConnection(connection);
            }
        }

        private void CreateProductFromReader(SqlDataReader reader, ref Product product)
        {
            while (reader.Read())
            {
                product = new Product();
                product.ProductId = (int)reader["ID"];
                product.ProductName = (string)reader["NAME"];
                product.Description = (string)reader["DESCRIPTION"];
                product.Price = (decimal)reader["PRICE"];
            }
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

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace SampleWeb
{
    public class ProductDao
    {
        public List<Product> GetProducts()
        {
            SqlConnection connection = null;
            SqlCommand command = null;
            SqlDataReader reader = null;
            List<Product> products = null;
            try
            {
                connection = new SqlConnection(ConfigurationManager.ConnectionStrings["epsilonDbConStr"].ConnectionString);
                command = new SqlCommand("select productid as ID, productname as NAME, productdescription as DESCRIPTION, price as PRICE from products", connection);
                //command.CommandType = System.Data.CommandType.Text;
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    products = new List<Product>();
                    while (reader.Read())
                    {
                        ConvertReaderToList(reader, products);
                    }
                }
                reader.Close();
                return products;
            }
            catch(ArgumentException ex)
            {
                throw ex;
            }
            catch(NullReferenceException ex)
            {
                throw ex;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        private static void ConvertReaderToList(SqlDataReader reader, List<Product> products)
        {
            Product product = new Product();
            product.ProductId = (int)reader["ID"];
            product.ProductName = (string)reader["NAME"];
            product.Description = (string)reader["DESCRIPTION"];
            product.Price = (decimal)reader["PRICE"];
            products.Add(product);
        }
    }
}
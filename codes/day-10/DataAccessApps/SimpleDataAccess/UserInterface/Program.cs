using SimpleDataAccess.BL;
using SimpleDataAccess.Entities;
using System;
using System.Collections.Generic;

//using System.Data; //ConnectionState, CommandType enum
//using System.Data.SqlClient; //SqlConnection, SqlCommand

namespace SimpleDataAccess.UserInterface
{
    class Program
    {
        //static void ShowRecords(DataTable table)
        //{
        //    if (table != null)
        //    {
        //        for (int i = 0; i < table.Rows.Count; i++)
        //        {
        //            //DataRow row = table.Rows[i];
        //            for (int j = 0; j < table.Columns.Count; j++)
        //            {
        //                //Console.Write(row[j] + "\t");
        //                Console.Write(table.Rows[i][j] + "\t");
        //            }
        //            Console.WriteLine("\n");
        //        }
        //    }
        //}
        static void ShowRecords(List<Product> products)
        {
            if (products != null)
            {
                foreach (Product product in products)
                {
                    Console.WriteLine(product);
                }
            }
        }

        static void Main()
        {
            ProductManager productManager = null;
            try
            {
                productManager = new ProductManager();
                //List<Product> products = productManager.FetchAll(2);
                //ShowRecords(products);   
                bool result = productManager.Add(new Product(0, "iPhone 11", 100000.00M, "new phone from Apple"));
                Console.WriteLine($"{(result ? "added" : "failed")}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            /*
            string connectionString = null;
            IDbConnection connection = null;
            IDbCommand command = null;
            //DataTable productTable = null;
            List<Product> products = null;
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
                            //productTable = ExecuteAndGetData(command);
                            products = ExecuteAndGetData(command);
                            //ShowRecords(productTable);
                            ShowRecords(products);
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
            */
        }
    }
}

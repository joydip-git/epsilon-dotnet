using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//using System.Data.SqlClient;
//using System.Configuration;

namespace SampleWeb
{
    public partial class ProductRecords : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            //SqlConnection connection = null;
            //SqlCommand command = null;
            //SqlDataReader reader = null;
            List<Product> products = null;
            //GetProducts(ref connection, ref command, ref reader, ref products);
            ProductBo productBo = null;
            try
            {
                productBo = new ProductBo();
                products = productBo.FetchProducts(1);
                if (products != null)
                {
                    //pass a collection/array to DataSource property
                    gridProducts.DataSource = products;
                    gridProducts.DataBind();
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }            
        }

        //private void GetProducts(ref SqlConnection connection, ref SqlCommand command, ref SqlDataReader reader, ref List<Product> products)
        //{
        //    try
        //    {
        //        connection = new SqlConnection(ConfigurationManager.ConnectionStrings["epsilonDbConStr"].ConnectionString);
        //        command = new SqlCommand("select productid as ID, productname as NAME, productdescription as DESCRIPTION, price as PRICE from products", connection);
        //        //command.CommandType = System.Data.CommandType.Text;
        //        connection.Open();
        //        reader = command.ExecuteReader();
        //        if (reader.HasRows)
        //        {
        //            products = new List<Product>();
        //            while (reader.Read())
        //            {
        //                Product product = new Product();
        //                product.ProductId = (int)reader["ID"];
        //                product.ProductName = (string)reader["NAME"];
        //                product.Description = (string)reader["DESCRIPTION"];
        //                product.Price = (decimal)reader["PRICE"];
        //                products.Add(product);
        //            }
        //        }
        //        reader.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        Response.Write(ex);
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //}
    }
}
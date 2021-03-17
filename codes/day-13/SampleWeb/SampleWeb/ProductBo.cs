using System;
using System.Collections.Generic;

namespace SampleWeb
{
    public class ProductBo
    {
        public List<Product> FetchProducts(int sortChoice)
        {
            ProductDao productDao = null;
            List<Product> products = null;
            try
            {
                productDao = new ProductDao();
                products = productDao.GetProducts();
                return products;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
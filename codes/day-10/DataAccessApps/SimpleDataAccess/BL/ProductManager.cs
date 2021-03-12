using SimpleDataAccess.Contracts;
using SimpleDataAccess.DAL;
using SimpleDataAccess.Entities;
using System;
using System.Collections.Generic;

namespace SimpleDataAccess.BL
{
    public class ProductManager : IBusinessManager<Product>
    {
        private ProductSqlDao productSqlDao;

        public ProductManager()
        {
            productSqlDao = new ProductSqlDao();
        }

        public bool Add(Product data)
        {
            try
            {
                if (data != null)
                    return productSqlDao.Insert(data);
                else
                    throw new NullReferenceException("Null refernce was passed");
            }
            catch(NullReferenceException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Product> FetchAll(int sortChoice)
        {
            try
            {
                List<Product> products = productSqlDao.GetAllRecords();
                products.Sort(new ProductComparison(sortChoice));
                return products;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Product Fetch(int id)
        {
            throw new NotImplementedException();
        }

        public bool Modify(Product data)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}

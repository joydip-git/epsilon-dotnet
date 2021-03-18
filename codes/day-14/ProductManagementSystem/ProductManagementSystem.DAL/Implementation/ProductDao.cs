using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagementSystem.DAL.Contracts;
using ProductManagementSystem.Entities;

namespace ProductManagementSystem.DAL.Implementation
{
    public class ProductDao : IDao<Product>
    {
        public bool Add(Product obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return new List<Product> { new Product { ProductId = 1, ProductName = "laptop", Description = "new laptop", Price = 1000 } };
        }

        public bool Update(Product obj)
        {
            throw new NotImplementedException();
        }
    }
}

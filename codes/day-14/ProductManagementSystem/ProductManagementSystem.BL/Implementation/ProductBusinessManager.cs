using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProductManagementSystem.BL.Contracts;
using ProductManagementSystem.Container;
using ProductManagementSystem.DAL.Contracts;
using ProductManagementSystem.DAL.Implementation;
using ProductManagementSystem.Entities;

namespace ProductManagementSystem.BL.Implementation
{
    public class ProductBusinessManager : IBusinessManager<Product>
    {
        private IDao<Product> dao;
        public ProductBusinessManager()
        {
            dao = new IOCContainer().Create<IDao<Product>, ProductDao>();
        }
        public Product Fetch(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> FetchAll()
        {
            return dao.GetAll();
        }

        public bool Insert(Product obj)
        {
            throw new NotImplementedException();
        }

        public bool Modify(Product obj)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}

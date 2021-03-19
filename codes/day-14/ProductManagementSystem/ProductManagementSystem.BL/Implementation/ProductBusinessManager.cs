using System;
using System.Collections.Generic;
using System.Linq;

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
            return dao.Get(id);
        }

        public List<Product> FetchAll()
        {
            return dao.GetAll();
        }

        public bool Insert(Product obj)
        {
            return dao.Add(obj);
        }

        public bool Modify(Product obj)
        {
            return dao.Update(obj);
        }

        public bool Remove(int id)
        {
            return dao.Delete(id);
        }
    }
}

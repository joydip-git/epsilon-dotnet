using DataAccess.Contracts;
using ProductLibrary;
using System.Collections.Generic;

namespace DataAccess.File
{
    public class ProductFileDataAccess : IDataAccess<Product>
    {
        public bool Add(Product obj)
        {
            return false;
        }

        public List<Product> GetAll()
        {
            return null;
        }
        //public void SetPath(string path){cw();}
    }
}

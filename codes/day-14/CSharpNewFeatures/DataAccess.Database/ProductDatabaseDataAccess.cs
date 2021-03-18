using System;
using System.Collections.Generic;
using DataAccess.Contracts;
using ProductLibrary;

namespace DataAccess.Database
{
    public class Person { }
    public class ProductDatabaseDataAccess : IDataAccess<Product>
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
    public class PersonDatabaseDataAccess : IDataAccess<Person>
    {
        //public void SetPath(string path){cw();}
        public bool Add(Person obj)
        {
            return false;
        }

        public List<Person> GetAll()
        {
            return null;
        }
    }
}

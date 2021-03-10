using System;

namespace DaoLibrary
{
    public interface IDao<TInput, TResult>
    {
        bool Insert(TInput data);
        bool Update(TInput data);
        bool Delete(int id);
        TResult[] GetAll();
        TResult Get(int id);
    }

    public interface IBo<TInput, TResult>
    {
        bool Add(TInput data);
        bool Modify(TInput data);
        bool Remove(int id);
        TResult[] FetchAll();
        TResult Fetch(int id);
    }

    public class ProductDao : IDao<Product, Product>
    {
        public bool Delete(int id)
        {
            return false;
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public Product[] GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Insert(Product data)
        {
            throw new NotImplementedException();
        }

        public bool Update(Product data)
        {
            throw new NotImplementedException();
        }
    }

    public class CategoryDao : IDao<Category, Category>
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Category Get(int id)
        {
            throw new NotImplementedException();
        }

        public Category[] GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Insert(Category data)
        {
            throw new NotImplementedException();
        }

        public bool Update(Category data)
        {
            throw new NotImplementedException();
        }
    }

    public class ProductBo : IBo<Product, Product>
    {
        public bool Add(Product data)
        {
            throw new NotImplementedException();
        }

        public Product Fetch(int id)
        {
            throw new NotImplementedException();
        }

        public Product[] FetchAll()
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
    public class CategoryBo : IBo<Category, Category>
    {
        public bool Add(Category data)
        {
            throw new NotImplementedException();
        }

        public Category Fetch(int id)
        {
            throw new NotImplementedException();
        }

        public Category[] FetchAll()
        {
            throw new NotImplementedException();
        }

        public bool Modify(Category data)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
    /*
    public class Dao<TInput, TReturn, TDto> : IDao<TInput, TReturn, TDto>
    {
        public TReturn Delete(int id)
        {
            return default(TReturn);
        }

        public TDto Get(int id)
        {
            return default(TDto);
        }

        public TDto[] GetAll()
        {
            return default(TDto[]);
        }

        public TReturn Insert(TInput data)
        {
            return default(TReturn);
        }

        public TReturn Update(TInput data)
        {
            return default(TReturn);
        }
    }
    */
}

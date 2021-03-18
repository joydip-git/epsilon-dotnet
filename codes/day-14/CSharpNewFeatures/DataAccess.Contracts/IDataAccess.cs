using System.Collections.Generic;

namespace DataAccess.Contracts
{
    public interface IDataAccess<T>
    {
        bool Add(T obj);
        List<T> GetAll();
        //void SetPath(string path);
    }
}

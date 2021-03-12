using System.Collections.Generic;

namespace SimpleDataAccess.Contracts
{
    public interface IBusinessManager<T>
    {
        bool Add(T data);
        bool Modify(T data);
        //bool Remove<TKey>(TKey id);
        bool Remove(int id);
        List<T> FetchAll(int sortChoice);
        T Fetch(int id);
    }
}

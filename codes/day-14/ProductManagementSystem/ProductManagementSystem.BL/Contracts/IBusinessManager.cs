using System.Collections.Generic;

namespace ProductManagementSystem.BL.Contracts
{
    public interface IBusinessManager<T>
    {
        bool Insert(T obj);
        bool Modify(T obj);
        bool Remove(int id);
        List<T> FetchAll();
        T Fetch(int id);
    }
}

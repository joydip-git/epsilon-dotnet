using System.Collections.Generic;

namespace ProductManagementSystem.DAL.Contracts
{
    public interface IDao<T>
    {
        bool Add(T obj);
        bool Update(T obj);
        bool Delete(int id);
        List<T> GetAll();
        T Get(int id);
    }
}

using System.Collections.Generic;

namespace SimpleDataAccess.Contracts
{
    public interface IDao<T>
    {
        bool Insert(T data);
        bool Update(T data);
        bool Delete(int id);
        List<T> GetAllRecords();
        T Get(int id);
    }
}

using System.Collections.Generic;

namespace gustavoakira.series.Interfaces
{
    public interface IRepository<T>
    {
        List<T> FindAll();
        T FinById(int id);
        void Insert(T entity);
        void Exclude(int id);
        void Update(int id, T entity);
        int NextId();
    }
}
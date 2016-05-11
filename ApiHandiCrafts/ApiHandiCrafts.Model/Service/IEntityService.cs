using System.Collections.Generic;

namespace ApiHandiCrafts.Contract.Service
{
    public interface IEntityService<T>
   where T : class
    {
        void Create(T entity);
        void Delete(int id);
        IEnumerable<T> GetAll();
        void Update(T entity);    
    }
}

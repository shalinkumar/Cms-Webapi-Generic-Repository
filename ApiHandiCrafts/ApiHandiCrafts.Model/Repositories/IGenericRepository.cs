using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ApiHandiCrafts.Contract.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
        //IEnumerable<T> GetUser(IEnumerable<T> entities, params object[] parameters);
        T Add(T entity);
        T Delete(T entity);
        void Edit(T entity);
        void Save();
        IEnumerable<T> FindById(int id);
        T Find(params object[] keyvalues);
        IQueryable<T> SelectQuery(string query, params object[] parameters);
        void Insert(T entity);
        void InsertRange(IEnumerable<T> entities);
        void InsertOrUpdateGraph(IEnumerable<T> entities);
        void InsertGraphRange(IEnumerable<T> entities);
        void Update(T entity);
        void Delete(object id);
        IGenericRepository<T> GetRepository<T>() where T : class;
        IQueryFluent<T> Query(IQueryObject<T> queryObject);
        IQueryFluent<T> Query(Expression<Func<T, bool>> query);
        IQueryFluent<T> Query();
        IQueryable<T> Queryable();       
    }
}

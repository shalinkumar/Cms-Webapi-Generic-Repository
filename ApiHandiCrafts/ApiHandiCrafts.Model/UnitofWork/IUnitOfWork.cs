using System;
using System.Data;
using ApiHandiCrafts.Contract.Repositories;

namespace ApiHandiCrafts.Repository.Common
{
    public interface IUnitOfWork:IDisposable
    {
        int SaveChanges();
        void Dispose(bool disposing);
        IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class;
        void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.Unspecified);
        /// <summary>
        /// Saves all pending changes
        /// </summary>
        /// <returns>The number of objects in an Added, Modified, or Deleted state</returns>
        bool Commit();
        void Rollback();
    }
}

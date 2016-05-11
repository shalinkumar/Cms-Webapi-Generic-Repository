using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Threading;
using System.Threading.Tasks;
using ApiHandiCrafts.Contract.Repositories;
using ApiHandiCrafts.Contract.UnitofWork;
using ApiHandiCrafts.Repository.Common;
using ApiHandiCrafts.Repository.Repositories;
using ServiceLocation;

namespace ApiHandiCrafts.Repository.UnitOfWork
{
    public sealed class UnitOfWork : IUnitOfWorkAsync
    {
        /// <summary>
        /// The DbContext
        /// </summary>
        private DbContext _dbContext;

        private Dictionary<string, dynamic> _repositories;
        /// <summary>
        /// Initializes a new instance of the UnitOfWork class.
        /// </summary>
        /// <param name="context">The object context</param>
        public UnitOfWork(DbContext context)
        {

            _dbContext = context;
        }


        public void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.Unspecified)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Saves all pending changes
        /// </summary>
        /// <returns>The number of objects in an Added, Modified, or Deleted state</returns>
        bool IUnitOfWork.Commit()
        {
            _dbContext.SaveChangesAsync();

            return true;
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Disposes the current object
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }

        void IUnitOfWork.Dispose(bool disposing)
        {
            Dispose(disposing);
        }

        public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class
        {
            if (ServiceLocator.IsLocationProviderSet)
            {
                return ServiceLocator.Current.GetInstance<IGenericRepository<TEntity>>();
            }
            return RepositoryAsync<TEntity>();
        }


        public IRepositoryAsync<TEntity> RepositoryAsync<TEntity>() where TEntity : class
        {
            if (ServiceLocator.IsLocationProviderSet)
            {
                return ServiceLocator.Current.GetInstance<IRepositoryAsync<TEntity>>();
            }

            if (_repositories == null)
            {
                _repositories = new Dictionary<string, dynamic>();
            }

            var type = typeof(TEntity).Name;

            if (_repositories.ContainsKey(type))
            {
                return (IRepositoryAsync<TEntity>)_repositories[type];
            }

            var repositoryType = typeof(GenericRepository<>);

            _repositories.Add(type, Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), _dbContext, this));

            return _repositories[type];
        }

        /// <summary>
        /// Disposes all external resources.
        /// </summary>
        /// <param name="disposing">The dispose indicator.</param>
        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_dbContext != null)
                {
                    _dbContext.Dispose();
                    _dbContext = null;
                }
            }
        }

        public Task<int> SaveChangesAsync()
        {
            return _dbContext.SaveChangesAsync();
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        //public IRepositoryAsync<TEntity> RepositoryAsync<TEntity>() where TEntity : class
        //{
        //    throw new NotImplementedException();
        //}
    }
}

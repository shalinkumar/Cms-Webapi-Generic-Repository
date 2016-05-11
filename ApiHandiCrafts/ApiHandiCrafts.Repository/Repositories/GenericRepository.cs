using System.Threading.Tasks;
using ApiHandiCrafts.Contract.Repositories;
using ApiHandiCrafts.Contract.UnitofWork;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using MongoDB.Driver.Builders;

namespace ApiHandiCrafts.Repository.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T>
        where T : class
    {
        private readonly DbContext dbContext;
        private readonly DbSet<T> _dbSet;
        private readonly IUnitOfWorkAsync _unitOfWork;
        private readonly IMongoDatabase _mongoDatabase;
        private IMongoCollection<T> _mongoCollection;
        private IMongoCollection<BsonDocument> _mongoCollectionBsonDocument;
        public GenericRepository(DbContext context, IUnitOfWorkAsync unitOfWork)
        {
            //dbContext = context;
            //_dbSet = context.Set<T>();
            //_unitOfWork = unitOfWork;


            var client = new MongoClient();
            _mongoDatabase = client.GetDatabase("HandiCrafts");        
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.AsEnumerable<T>();
        }

        public IEnumerable<T> FindById(int id)
        {
            //var name = typeof(T).Name;
            //_mongoCollectionBsonDocument = _mongoDatabase.GetCollection<BsonDocument>(name);
            //var filterss = Builders<BsonDocument>.Filter.Eq("_id", id);
            //Task<List<BsonDocument>> result = _mongoCollectionBsonDocument.Find(filterss).ToListAsync();
            //return result;

            throw new NotImplementedException();
        }
      
        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            IEnumerable<T> query = _dbSet.Where(predicate).AsEnumerable();
            return query;        
        }

        //public IEnumerable<T> GetUser(IEnumerable<T> entities, params object[] parameters)
        //{
        //    return  _dbSet.AsEnumerable<T>();
        //}

        public T Add(T entity)
        {
            return _dbSet.Add(entity);
        }

        public T Delete(T entity)
        {
            return _dbSet.Remove(entity);
        }

        public void Edit(T entity)
        {
            dbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }

        public T Find(params object[] keyvalues)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> SelectQuery(string query, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {           
            //_dbSet.Add(entity);         
            //_unitOfWork.SaveChanges();

            var name = typeof(T).Name;
            _mongoCollection = _mongoDatabase.GetCollection<T>(name);
            _mongoCollection.InsertOne(entity);
        }

        public void InsertRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public void InsertOrUpdateGraph(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public void InsertGraphRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            //_dbSet.Attach(entity);
            //_unitOfWork.SaveChangesAsync();
            //  UpdateBuilder updateBuilder = new UpdateBuilder();

            var name = typeof(T).Name;
            _mongoCollection.ReplaceOneAsync(new BsonDocument("_id", new ObjectId("_id")), entity);
          

            //_mongoCollection = _mongoDatabase.GetCollection<T>(name);
            //_mongoCollection.UpdateOne<T>(entity);
            //return _mongoCollection.UpdateOne(name);
        }

        public void Delete(object id)
        {
            var entity = _dbSet.Find(id);
            Delete(entity);
        }

        public IGenericRepository<T> GetRepository<T>() where T : class
        {
            return _unitOfWork.Repository<T>();
        }

        public IQueryFluent<T> Query(IQueryObject<T> queryObject)
        {
            throw new NotImplementedException();
        }

        public IQueryFluent<T> Query(Expression<Func<T, bool>> query)
        {
            throw new NotImplementedException();
        }

        public IQueryFluent<T> Query()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Queryable()
        {
            var name = typeof(T).Name;
            _mongoCollection = _mongoDatabase.GetCollection<T>(name);
            return _mongoCollection.AsQueryable();
        }
    }
}

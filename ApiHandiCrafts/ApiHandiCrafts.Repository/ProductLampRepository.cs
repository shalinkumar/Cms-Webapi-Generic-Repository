using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiHandiCrafts.Contract.IRepositories;
using ApiHandiCrafts.Contract.ModelRepositories;
using ApiHandiCrafts.Contract.Models;
using ApiHandiCrafts.Contract.Repositories;

namespace ApiHandiCrafts.Repository
{
    class ProductLampRepository : IProductLampRepository
    {
        private readonly IGenericRepository<Products> _genericRepository;
        private int _idIncrement;

        public ProductLampRepository(IGenericRepository<Products> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public IEnumerable<Products> GetAll()
        {
            var value= _genericRepository.Queryable().AsEnumerable();
            return value;
        }

        public Products GetById(int id)
        {
            return _genericRepository.Queryable().Where(x => x.Id == id).AsEnumerable().SingleOrDefault();
        }

        public void Insert(Products entity)
        {
            var value = _genericRepository.Queryable().AsEnumerable().LastOrDefault();
            if (value == null)
            {
                _idIncrement = 1;
            }
            else
            {
                _idIncrement = value.Id;
                _idIncrement++;
            }
            entity.Id = _idIncrement;

           _genericRepository.Insert(entity);
        }

        public void Update(int id, Products entity)
        {
            _genericRepository.Update(entity);
        }

        public void Delete(int id)
        {
            _genericRepository.Delete(id);
        }
    }
}

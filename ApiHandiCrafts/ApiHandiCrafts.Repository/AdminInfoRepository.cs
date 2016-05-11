using System;
using System.Collections.Generic;
using System.Linq;
using ApiHandiCrafts.Contract.IRepositories;
using ApiHandiCrafts.Contract.ModelRepositories;
using ApiHandiCrafts.Contract.Models;
using ApiHandiCrafts.Contract.Repositories;

namespace ApiHandiCrafts.Repository
{
    public class AdminInfoRepository : IAdminInfoRepository
    {
        private readonly IGenericRepository<AdminInformation> _genericRepository;
        private int _idIncrement;

        public AdminInfoRepository(IGenericRepository<AdminInformation> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public IEnumerable<AdminInformation> GetAll()
        {
            var value= _genericRepository.Queryable().AsEnumerable();
            return value;
        }

        public AdminInformation GetById(int id)
        {
            return _genericRepository.Queryable().Where(x => x.Id == id).AsEnumerable().SingleOrDefault();
        }

        public void Insert(AdminInformation entity)
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

        public void Update(int id, AdminInformation entity)
        {
            _genericRepository.Update(entity);
        }

        public void Delete(int id)
        {
            _genericRepository.Delete(id);
        }
    }
}

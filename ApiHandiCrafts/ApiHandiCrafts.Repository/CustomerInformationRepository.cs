using System.Collections.Generic;
using System.Linq;
using ApiHandiCrafts.Contract.ModelRepositories;
using ApiHandiCrafts.Contract.Models;
using ApiHandiCrafts.Contract.Repositories;

namespace ApiHandiCrafts.Repository
{
    public class CustomerInformationRepository : ICustomerInformationRepository
    {
        private readonly IGenericRepository<CustomerInformation> _genericRepository;
        private int _idIncrement;
        public CustomerInformationRepository(IGenericRepository<CustomerInformation> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public IEnumerable<CustomerInformation> GetAll()
        {
            var value = _genericRepository.Queryable().AsEnumerable();
            return value;
        }

        public CustomerInformation GetById(int id)
        {

            //var backupRegister = _genericRepository.GetRepository<backupRegister>().Queryable();
            //var testTable = _genericRepository.GetRepository<TestTable>().Queryable();

            var value = _genericRepository.Queryable()
               .Where(x => x.Id == id)
             .AsEnumerable().SingleOrDefault();
            return value;
        }

        public void Insert(CustomerInformation entity)
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

        public void Update(int id, CustomerInformation entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            _genericRepository.Delete(id);
        }
    }
}

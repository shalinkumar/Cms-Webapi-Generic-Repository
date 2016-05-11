using ApiHandiCrafts.Contract.ModelRepositories;
using ApiHandiCrafts.Contract.Models;
using ApiHandiCrafts.Contract.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ApiHandiCrafts.Repository
{
    public class ContactUsRepository : IContactUsRepository
    {

        private readonly IGenericRepository<ContactUs> _genericRepository;
        private int _idIncrement;

        public ContactUsRepository(IGenericRepository<ContactUs> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public IEnumerable<ContactUs> GetAll()
        {
            var value = _genericRepository.Queryable().AsEnumerable();
            return value;
        }

        public ContactUs GetById(int id)
        {
            var value = _genericRepository.Queryable()
             .Where(x => x.Id == id)
           .AsEnumerable().SingleOrDefault();
            return value;
        }

        public void Insert(ContactUs entity)
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

        public void Delete(int id)
        {
            _genericRepository.Delete(id);
        }
    }
}

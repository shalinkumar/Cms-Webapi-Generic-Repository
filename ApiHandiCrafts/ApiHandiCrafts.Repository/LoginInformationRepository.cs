using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiHandiCrafts.Contract.ModelRepositories;
using ApiHandiCrafts.Contract.Models;
using ApiHandiCrafts.Contract.Repositories;

namespace ApiHandiCrafts.Repository
{
    public class LoginInformationRepository : ILoginInformationRepository
    {

        private readonly IGenericRepository<LoginInformation> _genericRepository;
        private int _idIncrement;

        public LoginInformationRepository(IGenericRepository<LoginInformation> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public IEnumerable<LoginInformation> GetAll()
        {
            throw new NotImplementedException();
        }

        public LoginInformation GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool ValidateUser(string userName,string passWord)
        {
            bool isValue=false;
            //var value =
            //    repository.AsQueryable().Where(x => x.UserName == userName && x.Password == passWord).AsEnumerable().FirstOrDefault();
            var value = _genericRepository.Queryable().Where(x => x.UserName == userName && x.Password == passWord).AsEnumerable().FirstOrDefault();
            if (value == null)
            {
                isValue = false;
            }
            else if (value.Id != 0)
            {
                isValue = true;
            }      
            return isValue;
        }

       
        public void Insert(LoginInformation entity)
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
            throw new NotImplementedException();
        }

        public void Update(LoginInformation entity)
        {
            throw new NotImplementedException();
        }
    }
}

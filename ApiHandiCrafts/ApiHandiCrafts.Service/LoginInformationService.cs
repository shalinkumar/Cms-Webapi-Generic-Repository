using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiHandiCrafts.Contract.ModelRepositories;
using ApiHandiCrafts.Contract.Models;
using ApiHandiCrafts.Contract.ModelService;

namespace ApiHandiCrafts.Service
{
    public class LoginInformationService : ILoginInformationService
    {

        readonly ILoginInformationRepository _loginInformationRepository;

        public LoginInformationService(ILoginInformationRepository loginInformationRepository)
        {

            _loginInformationRepository = loginInformationRepository;
        }

        public void Create(LoginInformation entity)
        {
            _loginInformationRepository.Insert(entity);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LoginInformation> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(LoginInformation entity)
        {
            throw new NotImplementedException();
        }

        public LoginInformation GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool ValidateUser(string userName, string passWord)
        {
            var value = _loginInformationRepository.ValidateUser(userName, passWord);
            return value;
        }
    }
}

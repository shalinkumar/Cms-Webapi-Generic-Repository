using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiHandiCrafts.Contract.Models;
using ApiHandiCrafts.Contract.Repositories;
using ApiHandiCrafts.Model.Comman;

namespace ApiHandiCrafts.Contract.ModelRepositories
{
    public interface ILoginInformationRepository
    {
        IEnumerable<LoginInformation> GetAll();
        LoginInformation GetById(int id);
        bool ValidateUser(string userName, string passWord);
        void Insert(LoginInformation entity);
        void Delete(int id);
        void Update(LoginInformation entity);
    }
}

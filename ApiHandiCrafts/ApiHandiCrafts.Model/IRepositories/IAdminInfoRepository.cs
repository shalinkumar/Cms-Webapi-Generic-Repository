using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiHandiCrafts.Contract.Models;

namespace ApiHandiCrafts.Contract.IRepositories
{
    public interface IAdminInfoRepository
    {
        IEnumerable<AdminInformation> GetAll();

        AdminInformation GetById(int id);

        void Insert(AdminInformation entity);

        void Update(int id, AdminInformation entity);

        void Delete(int id);
    }
}

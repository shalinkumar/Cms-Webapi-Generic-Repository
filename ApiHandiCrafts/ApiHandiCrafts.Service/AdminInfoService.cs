using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiHandiCrafts.Contract.IRepositories;
using ApiHandiCrafts.Contract.Models;
using ApiHandiCrafts.Contract.ModelService;

namespace ApiHandiCrafts.Service
{
    public class AdminInfoService : IAdminInfoService
    {
        private readonly IAdminInfoRepository _adminInfoRepository;


        public AdminInfoService(IAdminInfoRepository adminInfoRepository)
        {
            _adminInfoRepository = adminInfoRepository;
        }


        public void Create(AdminInformation entity)
        {
            _adminInfoRepository.Insert(entity);
        }

        public void Delete(int id)
        {
            _adminInfoRepository.Delete(id);
        }

        public IEnumerable<AdminInformation> GetAll()
        {
            return _adminInfoRepository.GetAll();
        }

        public void Update(AdminInformation entity)
        {
            _adminInfoRepository.Update(1, entity);
        }

        public AdminInformation GetById(int id)
        {
            return _adminInfoRepository.GetById(id);
        }
    }
}

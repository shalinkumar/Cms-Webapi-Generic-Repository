using System.Collections.Generic;
using ApiHandiCrafts.Contract.ModelRepositories;
using ApiHandiCrafts.Contract.Models;
using ApiHandiCrafts.Contract.ModelService;
using ApiHandiCrafts.Repository.Common;

namespace ApiHandiCrafts.Service
{
    public class CustomerInformationService : ICustomerInformationService
    {
        IUnitOfWork _unitOfWork;
        readonly ICustomerInformationRepository _customerInformationRepository;

        public CustomerInformationService(ICustomerInformationRepository customerInformationRepository)
        {

            _customerInformationRepository = customerInformationRepository;
        }


        public CustomerInformation GetById(int Id)
        {
            return _customerInformationRepository.GetById(Id);
        }


        public void Create(CustomerInformation entity)
        {
            _customerInformationRepository.Insert(entity);
        }

        public void Delete(int id)
        {
            _customerInformationRepository.Delete(id);
        }

        public IEnumerable<CustomerInformation> GetAll()
        {
            return _customerInformationRepository.GetAll();
        }

        public void Update(CustomerInformation entity)
        {
            throw new System.NotImplementedException();
        }
    }
}

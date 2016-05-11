using System.Collections.Generic;
using ApiHandiCrafts.Contract.Models;

namespace ApiHandiCrafts.Contract.ModelRepositories
{
    public interface ICustomerInformationRepository
    {
        IEnumerable<CustomerInformation> GetAll();

        CustomerInformation GetById(int id);

        void Insert(CustomerInformation entity);

        void Update(int id, CustomerInformation entity);

        void Delete(int id);

    }
}

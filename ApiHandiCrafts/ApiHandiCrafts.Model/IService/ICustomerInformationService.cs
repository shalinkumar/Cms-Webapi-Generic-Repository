using System.Collections.Generic;
using ApiHandiCrafts.Contract.Models;
using ApiHandiCrafts.Contract.Service;

namespace ApiHandiCrafts.Contract.ModelService
{
    public interface ICustomerInformationService : IEntityService<CustomerInformation>
    {
        CustomerInformation GetById(int Id);  
     
    }
}

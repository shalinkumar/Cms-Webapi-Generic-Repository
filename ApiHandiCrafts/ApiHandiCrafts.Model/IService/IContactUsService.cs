using ApiHandiCrafts.Contract.Models;
using ApiHandiCrafts.Contract.Service;

namespace ApiHandiCrafts.Contract.ModelService
{
    public interface IContactUsService : IEntityService<ContactUs>
    {
        ContactUs GetById(int Id);  
    }
}

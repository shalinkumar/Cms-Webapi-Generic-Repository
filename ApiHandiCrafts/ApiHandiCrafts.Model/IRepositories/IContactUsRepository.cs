using ApiHandiCrafts.Contract.Models;
using System.Collections.Generic;

namespace ApiHandiCrafts.Contract.ModelRepositories
{
    public interface IContactUsRepository
    {
        IEnumerable<ContactUs> GetAll();

        ContactUs GetById(int id);

        void Insert(ContactUs entity);

        void Delete(int id);
    }
}

using ApiHandiCrafts.Contract.ModelRepositories;
using ApiHandiCrafts.Contract.Models;
using ApiHandiCrafts.Contract.ModelService;
using System;
using System.Collections.Generic;

namespace ApiHandiCrafts.Service
{
    public class ContactUsService : IContactUsService
    {
        private readonly IContactUsRepository _contactUsRepository;

        public ContactUsService(IContactUsRepository contactUsRepository)
        {

            _contactUsRepository = contactUsRepository;
        }

        public void Create(ContactUs entity)
        {
            _contactUsRepository.Insert(entity);
        }

        public void Delete(int id)
        {
            _contactUsRepository.Delete(id);
        }

        public IEnumerable<ContactUs> GetAll()
        {
            return _contactUsRepository.GetAll();
        }

        public void Update(ContactUs entity)
        {
            throw new NotImplementedException();
        }

        public ContactUs GetById(int Id)
        {
            return _contactUsRepository.GetById(Id);
        }
    }
}

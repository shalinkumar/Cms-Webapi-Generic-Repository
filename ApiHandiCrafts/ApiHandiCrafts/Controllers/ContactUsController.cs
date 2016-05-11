using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiHandiCrafts.Contract.Models;
using ApiHandiCrafts.Contract.Models.Mapping;
using ApiHandiCrafts.Contract.ModelService;

namespace ApiHandiCrafts.Controllers
{
    public class ContactUsController : ApiController
    {
        IContactUsService _contactUsService;

        public ContactUsController(IContactUsService contactUsService)
        {
            _contactUsService = contactUsService;
        }

        // GET api/<controller>
        public IEnumerable<ContactUs> Get()        
        {
            //return new string[] { "value1", "value2" };
            return _contactUsService.GetAll();
        }

        // GET api/<controller>/5
        public ContactUs Get(int id)
        {
            //return "value";
            return _contactUsService.GetById(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post(ContactUs information)
        {
            _contactUsService.Create(information);
        }

        // PUT api/<controller>/5
        public void Put(int id, ContactUs information)
        {
            _contactUsService.Update(information);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            _contactUsService.Delete(id);
        }
    }
}

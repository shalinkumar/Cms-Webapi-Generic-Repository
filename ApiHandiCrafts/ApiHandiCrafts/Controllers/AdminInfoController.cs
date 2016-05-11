using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiHandiCrafts.Contract.IRepositories;
using ApiHandiCrafts.Contract.Models;

namespace ApiHandiCrafts.Controllers
{
    [RoutePrefix("api/AdminInfo")]
    public class AdminInfoController : ApiController
    {
        private readonly IAdminInfoRepository _adminInfoRepository;

        public AdminInfoController(IAdminInfoRepository adminInfoRepository)
        {
            _adminInfoRepository = adminInfoRepository;
        }

        // GET api/<controller>
        [HttpGet]
        public IEnumerable<AdminInformation> Get()
        {
            //return new string[] { "value1", "value2" };
            return _adminInfoRepository.GetAll();
        }

        // GET api/<controller>/5
        [HttpGet]
        public AdminInformation Get(int id)
        {
            //return "value";
            return _adminInfoRepository.GetById(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post(AdminInformation information)
        {
            _adminInfoRepository.Insert(information);
        }

        // PUT api/<controller>/5
        [HttpPut]
        public void Put(int id, AdminInformation information)
        {
            _adminInfoRepository.Update(id, information);
        }

        // DELETE api/<controller>/5
        [HttpDelete]
        public void Delete(int id)
        {
            _adminInfoRepository.Delete(id);
        }
    }
}

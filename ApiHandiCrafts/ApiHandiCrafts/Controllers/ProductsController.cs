using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiHandiCrafts.Contract.IRepositories;
using ApiHandiCrafts.Contract.ModelRepositories;
using ApiHandiCrafts.Contract.Models;

namespace ApiHandiCrafts.Controllers
{
     [RoutePrefix("api/Products")]    
    public class ProductsController : ApiController
    {
        private readonly IProductLampRepository _productLampRepository;

        public ProductsController(IProductLampRepository loginInformationService)
        {
            _productLampRepository = loginInformationService;
        }

        // GET api/<controller>
        [HttpGet]
        public IEnumerable<Products> Get()
        {
            //return new string[] { "value1", "value2" };
            return _productLampRepository.GetAll();
        }

        // GET api/<controller>/5
        [HttpGet]
        public Products Get(int id)
        {
            //return "value";
            return _productLampRepository.GetById(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post(Products information)
        {
            _productLampRepository.Insert(information);
        }

        // PUT api/<controller>/5
        [HttpPut]
        public void Put(int id, Products information)
        {
            _productLampRepository.Update(id, information);
        }

        // DELETE api/<controller>/5
        [HttpDelete]
        public void Delete(int id)
        {
            _productLampRepository.Delete(id);
        }
    }
}

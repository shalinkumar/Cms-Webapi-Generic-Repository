using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiHandiCrafts.Contract.ModelRepositories;
using ApiHandiCrafts.Contract.Models;
using ApiHandiCrafts.Contract.ModelService;

namespace ApiHandiCrafts.Controllers
{
      [RoutePrefix("api/PageCreation")]    
    public class PageCreationController : ApiController
    {
         private readonly IPageCreationService _pageCreationService;

         public PageCreationController(IPageCreationService pageCreationService)
        {
            _pageCreationService = pageCreationService;
        }

        // GET api/<controller>
        [HttpGet]
         public IEnumerable<PageContentDesign> Get()
        {
            //return new string[] { "value1", "value2" };
            return _pageCreationService.GetAll();
        }

        // GET api/<controller>/5
        [HttpGet]
        public PageContentDesign Get(int id)
        {
            //return "value";
            return _pageCreationService.GetById(id);
        }

        [HttpGet]
        [Route("GetPageDesign")]     
        public PageContentDesign Get(string pageName)
        {
            //return "value";
            return _pageCreationService.GetPageDesign(pageName);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post(PageContentDesign information)
        {
            _pageCreationService.Create(information);
        }

        // PUT api/<controller>/5
        [HttpPut]
        public void Put(int id, PageContentDesign information)
        {
            _pageCreationService.Update(information);
        }

        // DELETE api/<controller>/5
        [HttpDelete]
        public void Delete(int id)
        {
            _pageCreationService.Delete(id);
        }
    }
}

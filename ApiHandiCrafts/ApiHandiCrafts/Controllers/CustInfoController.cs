using System.Collections.Generic;
using System.Web.Http;
using ApiHandiCrafts.Contract.Models;
using ApiHandiCrafts.Contract.ModelService;

namespace ApiHandiCrafts.Controllers
{
    public class CustInfoController : ApiController
    {

        ICustomerInformationService _customerInformationService;     

        public CustInfoController(ICustomerInformationService customerInformationService)
        {
            _customerInformationService = customerInformationService;
        }

        // GET api/<controller>
        public IEnumerable<CustomerInformation> Get()        
        {
            //return new string[] { "value1", "value2" };
            return _customerInformationService.GetAll();
        }

        // GET api/<controller>/5
        public CustomerInformation Get(int id)
        {
            //return "value";
            return _customerInformationService.GetById(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post(CustomerInformation information)
        {
            _customerInformationService.Create(information);
        }

        // PUT api/<controller>/5
        public void Put(int id, CustomerInformation information)
        {
            _customerInformationService.Update(information);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            _customerInformationService.Delete(id);
        }
    }
}

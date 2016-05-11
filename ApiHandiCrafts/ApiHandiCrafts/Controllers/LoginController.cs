using System.Collections.Generic;
using System.Web.Http;
using ApiHandiCrafts.Contract.Models;
using ApiHandiCrafts.Contract.ModelService;

namespace ApiHandiCrafts.Controllers
{
    [RoutePrefix("api/Login")]    
    public class LoginController : ApiController
    {
        private readonly ILoginInformationService _loginInformationService;

        public LoginController(ILoginInformationService loginInformationService)
        {
            _loginInformationService = loginInformationService;
        }

        // GET api/<controller>
        public IEnumerable<LoginInformation> Get()
        {
            //return new string[] { "value1", "value2" };
            return _loginInformationService.GetAll();
        }

        // GET api/<controller>/5
        public LoginInformation Get(int id)
        {
            //return "value";
            return _loginInformationService.GetById(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post(LoginInformation information)
        {
            _loginInformationService.Create(information);
        }

        // PUT api/<controller>/5
        public void Put(int id, LoginInformation information)
        {
            _loginInformationService.Update(information);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            _loginInformationService.Delete(id);
        }

      
        [HttpGet]
        [Route("ValidateUser")]     
        public bool ValidateUser(string userName, string passWord)
        {
            return _loginInformationService.ValidateUser(userName, passWord);         
        }
    }
}
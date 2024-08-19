using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayerNaveen;
using DataAccessLayerNaveen.Entity;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiNaveen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        RegistrationRepositorynk reg = null;
       
           
        
        // GET: api/<RegistrationController>
        [HttpGet]
        public IEnumerable<Registrationnk> Get()
        {
            reg = new RegistrationRepositorynk();
            return reg.selectalluser();
        }

        // GET api/<RegistrationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RegistrationController>
        [HttpPost]
        public void Post([FromBody] Registrationnk regist)
        {
            reg = new RegistrationRepositorynk();
            reg.Registeruser(regist);
        }

        // PUT api/<RegistrationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RegistrationController>/5
        [HttpDelete("{username}")]
        public void Delete(string username)
        {
            reg = new RegistrationRepositorynk();
            reg.deleteuser(username);
        }
    }
}

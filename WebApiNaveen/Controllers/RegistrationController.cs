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
       public RegistrationController()
        {
            reg = new RegistrationRepositorynk();
        }
           
        
        // GET: api/<RegistrationController>
        [HttpGet]
        public IEnumerable<Registrationnk> Get()
        {
          
            return reg.selectalluser();
        }

        // GET api/<RegistrationController>/5
        [HttpGet("{username}")]
        public Registrationnk Get(string  username)
        {
            return reg.selectuserbyname(username);
        }

        // POST api/<RegistrationController>
        [HttpPost]
        public void Post([FromBody] Registrationnk regist)
        {
            
            reg.Registeruser(regist);
        }

        // PUT api/<RegistrationController>/5
        [HttpPut("{id}")]
        public void Put(  Registrationnk value)
        {
            reg.Updateuser(value);
        }

        // DELETE api/<RegistrationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id )
        {

            reg.deleteuser(id);
        }
    }
}

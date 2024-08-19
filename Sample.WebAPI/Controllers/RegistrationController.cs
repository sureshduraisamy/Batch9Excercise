using DataAccessLayer;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sample.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        RegistrationRepository reg = null; 
        public RegistrationController()
        {
            reg = new RegistrationRepository();
        }

        // GET: api/<RegistrationController>
        [HttpGet]
        public IEnumerable<Registration> Get()
        {
           return  reg.SelectALLUser();
        }

        // GET api/<RegistrationController>/5
        [HttpGet("{username}")]
        public Registration Get(string username)
        {
            return reg.SelectUserByUsername(username);
        }

        // POST api/<RegistrationController>
        [HttpPost]
        public void Post([FromBody] Registration regis)
        {

            reg.RegisterUser(regis);
        }

        // PUT api/<RegistrationController>/5
        [HttpPut]
        public void Put([FromBody] Registration value)
        {
            reg.UpdateUser(value);
        }

        // DELETE api/<RegistrationController>/5
        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            reg.DeleteUser(id);
        }
    }
}

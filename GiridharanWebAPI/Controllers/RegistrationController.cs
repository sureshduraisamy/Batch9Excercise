using GiridharanDataAcessLayer;
using GiridharanDataAcessLayer.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GiridharanWebAPI.Controllers
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
            return reg.SelectAllUser();
        }

        // GET api/<RegistrationController>/5
        [HttpGet("{UserName}")]
        public Registration Get(string username)
        {
            return reg.SelectUserByUserName(username);
        }

        // POST api/<RegistrationController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RegistrationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RegistrationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

using DataAccesslayerkavi;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SampleWebAPIkavi.Controllers
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
        // GET: api/<Registration>
        [HttpGet]
        public IEnumerable<Registration> Get()
        {
            return reg.SelectALLUser();
        }
        // GET api/<Registration>/5
        [HttpGet("{UserName}")]
        public Registration Get(string UserName)
        {
            return reg.SelectUserByUsername(UserName);
        }

        // POST api/<Registration>
        [HttpPost]
        public void Post([FromBody]  Registration value)
        {
            reg.RegisterUser(value);
        }

        // PUT api/<Registration>/5
        [HttpPut]
        public void Put( [FromBody] Registration regi)
        {
            reg.UpdateUser(regi);
        }

        // DELETE api/<Registration>/5
        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            reg.DeleteUser(id);
        }
    }
}

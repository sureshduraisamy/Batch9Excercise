using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PraneshDataAcessLayer.Entity;
using PraneshDataAcessLayer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PraneshWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegestrationController : ControllerBase
    {
        RegistrationRepository con = null;
        public RegestrationController()
        {
            con = new RegistrationRepository();
        }
        // GET: api/<RegestrationController>
        [HttpGet]
        public IEnumerable<Registration> Get()
        {
            return con.selectAlluaer();
        }

        // GET api/<RegestrationController>/5
        [HttpGet("{RegestrationID}")]
        public Registration Get(long RegestrationID)
        {
            return con.SelectByUsername(RegestrationID);
        }

        // POST api/<RegestrationController>
        [HttpPost]
        public void Post([FromBody] Registration value)
        {
            con.Registeruser(value);

        }

        // PUT api/<RegestrationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Registration value)
        {
            con.UpdateuserData(value);
        }

        // DELETE api/<RegestrationController>/5
        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            con.Deleteuser(id);
        }
    }
}

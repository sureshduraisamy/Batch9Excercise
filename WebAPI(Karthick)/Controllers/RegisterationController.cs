using KarthickDataAccess.Entity;
using KarthickDataAccess;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI_Karthick_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterationController : ControllerBase
    {
        IRegisterationRepository objReg = null;
        public RegisterationController(IRegisterationRepository register)
        {
            objReg = register;
        }

        // GET: api/<RegisterationController>
        [HttpGet]
        public IEnumerable<Registration> Get()
        {
            RegistrationRepository objReg = new RegistrationRepository();
            return objReg.SelectALLUser();
        }

        // GET api/<RegisterationController>/5
        [HttpGet("{username}")]
        public Registration Get(string username)
        {
            return objReg.SelectUserByUsername(username);
        }

        // POST api/<RegisterationController>
        [HttpPost]
        public void Post([FromBody] Registration reg)
        {
            objReg.RegisterUser(reg);
        }

        // PUT api/<RegisterationController>/5
        [HttpPut]
        public void Put([FromBody] Registration value)
        {
            objReg.UpdateUser(value);
        }

        // DELETE api/<RegisterationController>/5
        [HttpDelete("{regId}")]
        public void Delete(long regId)
        {
            objReg.DeleteUserRecord(regId);
        }
    }
}

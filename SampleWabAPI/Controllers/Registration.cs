﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SampleWebAPIkavi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Registration : ControllerBase
    {
        Registration reg = null;
        public Registration()
        {
            reg = new Registration();
        }
        // GET: api/<Registration>
        [HttpGet]
        public IEnumerable<Registration> Get()
        {
            return reg.SelectALLUser();
        }

        private IEnumerable<Registration> SelectALLUser()
        {
            throw new NotImplementedException();
        }

        // GET api/<Registration>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Registration>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Registration>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Registration>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

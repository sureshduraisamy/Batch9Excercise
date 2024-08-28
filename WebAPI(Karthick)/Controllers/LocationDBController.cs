using KarthickDataAccess;
using KarthickDataAccess.Entity;
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
    public class LocationDBController : ControllerBase
    {
        ILocationRepository locate = null;
        public LocationDBController(ILocationRepository location)
        {
            locate = location;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(locate.GetAllLocationInfo());
        }

        // GET api/<ValuesController>/5
        [HttpGet("{locationName}")]
        public IActionResult Get(string locationName)
        {
            return Ok(locate.GetLocationByName(locationName));
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Location value)
        {
            try {
                locate.InsertLocation(value);
            }catch(Exception e)
            {
                throw e;
            }
            
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

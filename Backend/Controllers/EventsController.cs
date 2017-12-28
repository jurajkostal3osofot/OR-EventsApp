using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Backend.Models;

namespace Backend.Controllers
{
    public class EventsController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        // POST api/values
        public IHttpActionResult Post([FromBody]Event result)
        {
            //var ret = JsonConvert.DeserializeObject <Event> (result);
            return Ok();
        }
    }
}
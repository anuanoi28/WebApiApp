using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiApp.Controllers
{
    public class ValuesController : ApiController
    {
        string str = "";
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "Anu", "Sona" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value - " + id;
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
            str = value;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/values/5
        public void Delete(int id)
        {

        }
    }
}


// web uri's : GET, POST, PUT, DELETE
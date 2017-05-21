using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CxModel;
using Microsoft.AspNetCore.Mvc;

namespace CxApi.Controllers
{
    [Route("api/[controller]")]
    public class HelloController : Controller
    {
        // GET api/hello
        [HttpGet]
        public string Get()
        {
            return "hello who?";
        }

        // GET api/hello/world
        [HttpGet("{name}")]
        public JsonResult Get(string name)
        {
            var response = new HelloJsonResponse
            { Prompt = String.Format("Hello {0}", name) };
            
            return Json(response);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

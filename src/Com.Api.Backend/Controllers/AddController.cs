using Microsoft.AspNetCore.Mvc;

namespace Com.Api.Backend.Controllers
{
    [Route("api/[controller]")]
    public class AddController : Controller
    {
        // GET api/values
        [HttpGet]
        public int Get(int value)
        {
            return value + 5;
        }

        // POST api/values
        [HttpPost]
        public int Post(int value)
        {
            return value + 5;
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

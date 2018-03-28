using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Com.Api.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        [HttpGet]
        [HttpPost("{value}")]
        public async Task<string> Get(int value)
        {
            var httpClient = new HttpClient();

            var uri = $"http://{Environment.GetEnvironmentVariable("backend")}/";

            var result = await httpClient.GetStringAsync($"{uri}api/add/{value}");

            return result;
        }
    }
}
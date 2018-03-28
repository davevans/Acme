using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Com.Api.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly string _backend;

        public ValuesController(Backend backend) => _backend = backend.DnsName;

        [HttpGet("{value}")]
        public async Task<string> Get(int value)
        {
            var httpClient = new HttpClient();

            var url = $"http://{_backend}/api/add/{value}";

            var result = await httpClient.GetAsync(url);

            return await result.Content.ReadAsStringAsync();
        }
    }
}
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Com.Api.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        [HttpGet]
        public async Task<string> Get(int value)
        {
            var httpClient = new HttpClient();

            var result = await httpClient.GetStringAsync($"api/add/{value}");

            return result;
        }
    }
}
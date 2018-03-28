using Microsoft.AspNetCore.Mvc;

namespace Com.Api.Backend.Controllers
{
    [Route("api/[controller]")]
    public class AddController : Controller
    {
        private static bool _isHealthy = true;

        [HttpGet("{value}")]
        public int Get(int value)
        {
            return value + 5;
        }
    }
} 
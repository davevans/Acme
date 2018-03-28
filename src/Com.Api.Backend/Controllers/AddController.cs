using Microsoft.AspNetCore.Mvc;

namespace Com.Api.Backend.Controllers
{
    [Route("api/[controller]")]
    public class AddController : Controller
    {
        [HttpPost("{value}")]
        public int Post(int value)
        {
            return value + 5;
        }
    }
} 
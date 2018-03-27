using Microsoft.AspNetCore.Mvc;

namespace Com.Api.Backend.Controllers
{
    [Route("api/[controller]")]
    public class AddController : Controller
    {
        [HttpGet]
        public int Get(int value)
        {
            return value + 5;
        }
    }
}
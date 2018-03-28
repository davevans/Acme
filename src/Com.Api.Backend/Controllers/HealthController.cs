using Microsoft.AspNetCore.Mvc;

namespace Com.Api.Backend.Controllers
{
    [Route("api/[controller]")]
    public class HealthController
    {
        private static bool _isHealthy;

        [HttpGet]
        public IActionResult IsHealthy()
        {
            if (_isHealthy)
                return new OkResult();

            return new StatusCodeResult(500);
        }

        [HttpGet("{value}")]
        public IActionResult Health(bool value)
        {
            _isHealthy = value;

            return new OkResult();
        }
    }
}

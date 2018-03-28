using Com.Lib;
using Microsoft.AspNetCore.Mvc;

namespace Com.Api.Backend.Controllers
{
    [Route("api/[controller]")]
    public class HealthController
    {
        private readonly HealthCheck _healthCheck;
        private static bool _isHealthy = true;

        public HealthController(HealthCheck healthCheck)
        {
            _healthCheck = healthCheck;
        }

        [HttpGet("ready")]
        public IActionResult IsHealthy() => GetResponse(_healthCheck.IsReady() && _isHealthy);

        [HttpGet("live")]
        public IActionResult IsReady() => GetResponse(_healthCheck.IsReady());

        [HttpGet("update/{value}")]
        public IActionResult Health(bool value)
        {
            _isHealthy = value;

            return new OkResult();
        }

        private static IActionResult GetResponse(bool status) => status ? new OkResult() : new StatusCodeResult(503);
    }
}


using Com.Lib;
using Microsoft.AspNetCore.Mvc;

namespace Com.Api.Controllers
{
    [Route("api/[controller]")]
    public class HealthController
    {
        private readonly HealthCheck _healthCheck;
        private static bool _isHealthy;

        public HealthController(HealthCheck healthCheck)
        {
            _healthCheck = healthCheck;
        }

        [HttpGet("ready")]
        public IActionResult IsHealthy()
        {
            return _healthCheck.IsReady() && _isHealthy ? new OkResult() : new StatusCodeResult(503);
        }

        [HttpGet("live")]
        public IActionResult IsReady()
        {
            return _healthCheck.IsReady() ? new OkResult() : new StatusCodeResult(503);
        }

        [HttpGet("{value}")]
        public IActionResult Health(bool value)
        {
            _isHealthy = value;

            return new OkResult();
        }
    }
}

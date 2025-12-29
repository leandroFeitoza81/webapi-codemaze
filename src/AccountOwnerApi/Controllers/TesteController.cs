using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace AccountOwnerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TesteController : ControllerBase
    {
        private readonly ILoggerManager _logger;

        public TesteController(ILoggerManager logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInfo("Testando log");
            return Ok("Testando log");
        }
    }
}

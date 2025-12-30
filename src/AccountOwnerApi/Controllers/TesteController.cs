using Contracts;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace AccountOwnerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TesteController(ILoggerManager logger, IDiagnosticContext diagnosticContext) : ControllerBase
    {
        private readonly ILoggerManager _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        private readonly IDiagnosticContext _diagnosticContext = diagnosticContext
            ?? throw new ArgumentNullException(nameof(diagnosticContext));
        
        [HttpGet]
        public IActionResult Get()
        {
           _logger.LogInfo("Testando log Serilog");
           _diagnosticContext.Set("Teste", "Testando log");
            return Ok("Testando log");
        }
    }
}

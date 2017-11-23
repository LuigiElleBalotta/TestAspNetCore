using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TestNetCore.Controllers
{
    public class StatusCodeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public StatusCodeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // GET: /<controller>/
        [HttpGet("/StatusCode/{statusCode}")]
        public IActionResult Index(int statusCode)
        {
            var reExecute = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
            _logger.LogInformation($"Unexpected Status Code: {statusCode}, OriginalPath: {reExecute.OriginalPath}");
    
            return View(statusCode);
        }
    }
}
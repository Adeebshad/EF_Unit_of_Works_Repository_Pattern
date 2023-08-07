using Basic.WebApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Basic.WebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ICourse _course;
        private readonly ILogger<HomeController> _logger;
        public HomeController(ICourse course, ILogger<HomeController> logger)
        {
            _course = course;
            _logger = logger;   
        }

        [HttpGet(Name = "GetData")]
        public IActionResult Get()
        {
            _logger.LogInformation("Course Controller Get");
            return Ok("Success");
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Basic.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        public CourseController(ILogger<HomeController> logger) {
            _logger = logger;
        }

        [HttpGet(Name = "GetCourse")]
        public IActionResult Get()
        {
            _logger.LogInformation("Course Controller Get");
            return Ok("Success");
        }
    }
}

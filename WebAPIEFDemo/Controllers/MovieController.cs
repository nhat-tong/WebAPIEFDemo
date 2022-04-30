using Microsoft.AspNetCore.Mvc;
using WebAPIEFDemo.Models;

namespace WebAPIEFDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly ILogger<MovieController> _logger;
        private readonly IConfiguration _configuration;

        public MovieController(ILogger<MovieController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet]
        public IEnumerable<Movie> Get() { 
            using (var context = new MovieDbContext(_configuration.GetConnectionString("Default")))
            {
                var result = context.Movies.ToList();
                return result;
            }
        }
    }
}
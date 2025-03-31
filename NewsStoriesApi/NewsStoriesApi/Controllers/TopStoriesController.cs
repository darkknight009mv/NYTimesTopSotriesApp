using Microsoft.AspNetCore.Mvc;
using NewsStoriesApi.Interfaces;

namespace NewsStoriesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopStoriesController : ControllerBase
    {
        private readonly INYTimesService _nyTimesService;
        private readonly ILogger<TopStoriesController> _logger;

        public TopStoriesController(INYTimesService nyTimesService, ILogger<TopStoriesController> logger)
        {
            _nyTimesService = nyTimesService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] string apiKey)
        {

            try
            {
                var stories = await _nyTimesService.FetchAndStoreTopStoriesAsync(apiKey);
                return Ok(stories);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching top stories in controller.");
                return StatusCode(500, "An error occurred while processing your request.");
            }
        }
    }

}

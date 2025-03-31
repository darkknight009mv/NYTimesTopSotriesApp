using System.Linq.Expressions;
using NewsStoriesApi.Data;
using NewsStoriesApi.Interfaces;
using NewsStoriesApi.Models;
using NewsStoriesApi.Services.DTO;
using Newtonsoft.Json;

namespace NewsStoriesApi.Services
{
    public class NYTimesService : INYTimesService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<NYTimesService> _logger;
        private readonly INYTimesRepository _repository;
        private readonly INYTimesMapper _mapper;
        private const string BaseUrl = "https://api.nytimes.com/svc/topstories/v2/home.json";

        public NYTimesService(HttpClient httpClient,ILogger<NYTimesService> logger,INYTimesRepository repository,INYTimesMapper mapper)
        {
            _httpClient = httpClient;
            _logger = logger;
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<NYtimesStoryModel>> FetchAndStoreTopStoriesAsync(string apiKey)
        {
            if (string.IsNullOrWhiteSpace(apiKey))
            {
                _logger.LogError("API key is missing.");
                throw new ArgumentException("API key is required.", nameof(apiKey));
            }

            var requestUrl = $"{BaseUrl}?api-key={apiKey}";
            _logger.LogInformation("Calling NYTimes API: {RequestUrl}", requestUrl);

            try
            {
                var response = await _httpClient.GetAsync(requestUrl);
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                _logger.LogInformation("NYTimes API call successful.");

                var apiResponse = JsonConvert.DeserializeObject<NYTimesApiResponseDto>(json);
                var stories = _mapper.MapApiResponse(apiResponse);

                await _repository.SaveStoriesAsync(stories);
                _logger.LogInformation("Stored {Count} stories in the database.", stories?.Count() ?? 0);

                return stories;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching or storing top stories.");
                throw;
            }
        }
    }

}

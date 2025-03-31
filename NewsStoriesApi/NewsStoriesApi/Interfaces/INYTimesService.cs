using System.Globalization;
using NewsStoriesApi.Models;

namespace NewsStoriesApi.Interfaces
{
    public interface INYTimesService
    {
        Task<IEnumerable<NYtimesStoryModel>> FetchAndStoreTopStoriesAsync(string apiKey);
    }
}

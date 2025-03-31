using NewsStoriesApi.Models;

namespace NewsStoriesApi.Interfaces
{
    public interface INYTimesRepository
    {
        Task SaveStoriesAsync(IEnumerable<NYtimesStoryModel> stories);

    }
}

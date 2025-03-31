using NewsStoriesApi.Models;
using NewsStoriesApi.Services.DTO;

namespace NewsStoriesApi.Interfaces
{
    public interface INYTimesMapper
    {
        IEnumerable<NYtimesStoryModel> MapApiResponse(NYTimesApiResponseDto resopnse);
    }
}

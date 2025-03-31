using Microsoft.EntityFrameworkCore;
using NewsStoriesApi.Data;
using NewsStoriesApi.Interfaces;
using NewsStoriesApi.Models;

namespace NewsStoriesApi.Repositories
{
    public class NYTimesRepository : INYTimesRepository
    {
        private readonly AppDbContext _appDbContext;
        public NYTimesRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task SaveStoriesAsync(IEnumerable<NYtimesStoryModel> stories)
        {
            foreach (var story in stories)
            {
                bool exists = await _appDbContext.NYTimesStories.AnyAsync(s => s.Url == story.Url);
                if (!exists)
                {
                    _appDbContext.NYTimesStories.Add(story);
                }
            }

            await _appDbContext.SaveChangesAsync();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using NewsStoriesApi.Models;

namespace NewsStoriesApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
           
        }

        public DbSet<NYtimesStoryModel> NYTimesStories { get; set; }
        public DbSet<MultimediaItemModel> MultimediaItems { get; set; }
    }
}

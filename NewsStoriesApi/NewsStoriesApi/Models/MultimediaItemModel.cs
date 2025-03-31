using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsStoriesApi.Models
{
    public class MultimediaItemModel
    {
        [Key]
        public int Id { get; set; }
        public string Url { get; set; }
        public string Format { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public string Type { get; set; }
        public string Subtype { get; set; }
        public string Caption { get; set; }
        public string Copyright { get; set; }

        [ForeignKey("NYTimesStoryId")]
        public int NYTimesStoryId { get; set; }
        public NYtimesStoryModel NYTimesStory { get; set; }
    }
}

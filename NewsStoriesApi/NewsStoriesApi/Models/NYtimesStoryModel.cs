using System.ComponentModel.DataAnnotations;

namespace NewsStoriesApi.Models
{
    public class NYtimesStoryModel
    {
        [Key]
        public int Id { get; set; }
        public string Section { get; set; }
        public string Subsection { get; set; }
        public string Title { get; set; }
        public string Abstract { get; set; }
        public string Url { get; set; }
        public string Uri { get; set; }
        public string Byline { get; set; }
        public string ItemType { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime PublishedDate { get; set; }
        public string MaterialTypeFacet { get; set; }
        public string Kicker { get; set; }
        public string DesFacet { get; set; }  // Stored as a comma-separated string
        public string OrgFacet { get; set; }
        public string PerFacet { get; set; }
        public string GeoFacet { get; set; }

        // Navigation property for related multimedia items.
        public List<MultimediaItemModel> MultimediaItems { get; set; } = new List<MultimediaItemModel>();
    
    }
}

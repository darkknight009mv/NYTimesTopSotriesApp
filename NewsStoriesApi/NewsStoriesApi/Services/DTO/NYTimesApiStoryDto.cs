using Newtonsoft.Json;
namespace NewsStoriesApi.Services.DTO
{
    public class NYTimesApiStoryDto
    {
        [JsonProperty("section")]
        public string Section { get; set; }
        [JsonProperty("subsection")]
        public string Subsection { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("abstract")]
        public string Abstract { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("uri")]
        public string Uri { get; set; }
        [JsonProperty("byline")]
        public string Byline { get; set; }
        [JsonProperty("item_type")]
        public string ItemType { get; set; }
        [JsonProperty("updated_date")]
        public DateTime UpdatedDate { get; set; }
        [JsonProperty("created_date")]
        public DateTime CreatedDate { get; set; }
        [JsonProperty("published_date")]
        public DateTime PublishedDate { get; set; }
        [JsonProperty("material_type_facet")]
        public string MaterialTypeFacet { get; set; }
        [JsonProperty("kicker")]
        public string Kicker { get; set; }
        [JsonProperty("des_facet")]
        public List<string> DesFacet { get; set; }
        [JsonProperty("org_facet")]
        public List<string> OrgFacet { get; set; }
        [JsonProperty("per_facet")]
        public List<string> PerFacet { get; set; }
        [JsonProperty("geo_facet")]
        public List<string> GeoFacet { get; set; }
        [JsonProperty("multimedia")]
        public List<MultimediaItemDto> Multimedia { get; set; }
    }
}

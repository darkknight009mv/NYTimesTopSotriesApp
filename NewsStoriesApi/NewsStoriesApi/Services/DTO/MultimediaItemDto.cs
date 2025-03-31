using Newtonsoft.Json;

namespace NewsStoriesApi.Services.DTO
{
    public class MultimediaItemDto
    {
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("format")]
        public string Format { get; set; }
        [JsonProperty("height")]
        public int Height { get; set; }
        [JsonProperty("width")]
        public int Width { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("subtype")]
        public string Subtype { get; set; }
        [JsonProperty("caption")]
        public string Caption { get; set; }
        [JsonProperty("copyright")]
        public string Copyright { get; set; }
    }
}

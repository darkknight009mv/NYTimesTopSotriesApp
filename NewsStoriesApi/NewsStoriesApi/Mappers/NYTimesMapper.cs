using NewsStoriesApi.Interfaces;
using NewsStoriesApi.Models;
using NewsStoriesApi.Services.DTO;

namespace NewsStoriesApi.Mappers
{
    public class NYTimesMapper : INYTimesMapper
    {
        public IEnumerable<NYtimesStoryModel> MapApiResponse(NYTimesApiResponseDto response)
        {
            if (response?.Results == null)
                return Enumerable.Empty<NYtimesStoryModel>();

            return response.Results.Select(s =>
            {
                var story = new NYtimesStoryModel
                {
                    Section = s.Section,
                    Subsection = s.Subsection,
                    Title = s.Title,
                    Abstract = s.Abstract,
                    Url = s.Url,
                    Uri = s.Uri,
                    Byline = s.Byline,
                    ItemType = s.ItemType,
                    UpdatedDate = s.UpdatedDate,
                    CreatedDate = s.CreatedDate,
                    PublishedDate = s.PublishedDate,
                    MaterialTypeFacet = s.MaterialTypeFacet,
                    Kicker = s.Kicker,
                    DesFacet = s.DesFacet != null ? string.Join(", ", s.DesFacet) : null,
                    OrgFacet = s.OrgFacet != null ? string.Join(", ", s.OrgFacet) : null,
                    PerFacet = s.PerFacet != null ? string.Join(", ", s.PerFacet) : null,
                    GeoFacet = s.GeoFacet != null ? string.Join(", ", s.GeoFacet) : null,
                    MultimediaItems = s.Multimedia?.Select(m => new MultimediaItemModel
                    {
                        Url = m.Url,
                        Format = m.Format,
                        Height = m.Height,
                        Width = m.Width,
                        Type = m.Type,
                        Subtype = m.Subtype,
                        Caption = m.Caption,
                        Copyright = m.Copyright
                    }).ToList() ?? new List<MultimediaItemModel>()
                };
                return story;
            });
        }
    }
}

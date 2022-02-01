using System.Text.Json.Serialization;

namespace BodyHtml
{
    public class PageSettingsSlice
    {
        [JsonPropertyName("isDefaultDescription")]
        public bool? IsDefaultDescription { get; set; }

        [JsonPropertyName("isDefaultThumbnail")]
        public bool? IsDefaultThumbnail { get; set; }
    }
}
using System.Text.Json.Serialization;

namespace BodyHtml
{
    public class SectionZoneGroupMetadata
    {
        [JsonPropertyName("type")]
        public int Type
        {
            get; set;
        }

        [JsonPropertyName("isExpanded")]
        public bool IsExpanded
        {
            get; set;
        }

        [JsonPropertyName("showDividerLine")]
        public bool ShowDividerLine
        {
            get; set;
        }

        [JsonPropertyName("iconAlignment")]
        [JsonConverter(typeof(IconAlignmentJsonConverter))]
        public string IconAlignment
        {
            get; set;
        }

        [JsonPropertyName("displayName")]
        public string DisplayName
        {
            get; set;
        }
    }
}
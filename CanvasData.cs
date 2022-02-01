using System.Text.Json.Serialization;

namespace BodyHtml
{
    /// <summary>
    /// Base class representing the json control data that will be included in each client side control (de-)serialization (data-sp-controldata attribute)
    /// </summary>
    public class CanvasData
    {
        /// <summary>
        /// Gets or sets JsonProperty "position"
        /// </summary>
        [JsonPropertyName("position")]
        public CanvasPosition Position { get; set; }

        [JsonPropertyName("emphasis")]
        public SectionEmphasis Emphasis { get; set; }

        [JsonPropertyName("pageSettingsSlice")]
        public PageSettingsSlice PageSettingsSlice { get; set; }

        [JsonPropertyName("zoneGroupMetadata")]
        public SectionZoneGroupMetadata ZoneGroupMetadata { get; set; }
    }
}

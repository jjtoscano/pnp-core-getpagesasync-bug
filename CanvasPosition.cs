using System.Text.Json.Serialization;

namespace BodyHtml
{ 
    public class CanvasPosition
    {

        /// <summary>
        /// Gets or sets JsonProperty "zoneIndex"
        /// </summary>
        [JsonPropertyName("zoneIndex")]
        public float ZoneIndex { get; set; }

        /// <summary>
        /// Gets or sets JsonProperty "sectionIndex"
        /// </summary>
        [JsonPropertyName("sectionIndex")]
        public int SectionIndex { get; set; }

        /// <summary>
        /// Gets or sets JsonProperty "sectionFactor"
        /// </summary>
        [JsonPropertyName("sectionFactor")]
        public int? SectionFactor { get; set; }

        /// <summary>
        /// Gets or sets JsonProperty "layoutIndex"
        /// </summary>
        [JsonPropertyName("layoutIndex")]
        public int? LayoutIndex { get; set; }
    }
}
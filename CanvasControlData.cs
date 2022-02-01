using System.Text.Json.Serialization;

namespace BodyHtml 
{ 
    class CanvasControlData
    {

        [JsonPropertyName("controlType")]
        public int ControlType { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("position")]
        public CanvasControlPosition Position { get; set; }

        [JsonPropertyName("emphasis")]
        public SectionEmphasis Emphasis { get; set; }

        [JsonPropertyName("zoneGroupMetadata")]
        public SectionZoneGroupMetadata ZoneGroupMetadata { get; set; }
    }
}

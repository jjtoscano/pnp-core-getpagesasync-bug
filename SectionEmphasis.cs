using System.Text.Json.Serialization;

namespace BodyHtml 
{ 
    public class SectionEmphasis
    {
        [JsonPropertyName("zoneEmphasis")]
        [JsonConverter(typeof(EmphasisJsonConverter))]
        public int ZoneEmphasis
        {
            get; set;
        }
    }
}
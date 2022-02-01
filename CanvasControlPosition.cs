using System.Text.Json.Serialization;

namespace BodyHtml 
{ 
    class CanvasControlPosition : CanvasPosition
    {
        /// <summary>
        /// Gets or sets JsonProperty "controlIndex"
        /// </summary>
        [JsonPropertyName("controlIndex")]
        public float ControlIndex { get; set; }
    }
}


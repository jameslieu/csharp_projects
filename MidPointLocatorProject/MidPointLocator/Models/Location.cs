using System.Text.Json.Serialization;

namespace MidPointLocator.Models
{
    public class Location
    {
        [JsonPropertyName("longitude")]
        public float Longitude { get; set; }

        [JsonPropertyName("latitude")]
        public float Latitude { get; set; }
    }
}
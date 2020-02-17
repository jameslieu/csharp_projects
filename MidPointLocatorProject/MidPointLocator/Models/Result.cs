using System.Text.Json.Serialization;

namespace MidPointLocator.Models
{
    public class Result
    {
        [JsonPropertyName("query")]
        public string Postcode { get; set; }

        [JsonPropertyName("result")]
        public Location Location { get; set; }
    }
}
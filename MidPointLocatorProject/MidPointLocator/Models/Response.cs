using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MidPointLocator.Models
{
    public class Response
    {
        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("result")]
        public List<Result> Result { get; set; }
    }
}

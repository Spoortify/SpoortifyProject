using System.Text.Json.Serialization;

namespace Sportify.Model
{
    public class Api_Key
    {
        [JsonPropertyName("api_key")]
        public List<string> APIKeyValues { get; set; } = new();
    }
}

using System.Text.Json.Serialization;

namespace Sportify.Model
{
    public class Api_Key
    {
        [JsonPropertyName("api_key")]
        public string APIKeyValue { get; set; } = string.Empty;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Sportify.Model
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class ConstructorParameters
    {
        [JsonPropertyName("season")]
        public string Season { get; set; }
    }

    public class ConstructorResponse
    {
        [JsonPropertyName("position")]
        public int Position { get; set; }

        [JsonPropertyName("team")]
        public ConstructorTeam Team { get; set; }

        [JsonPropertyName("points")]
        public int Points { get; set; }

        [JsonPropertyName("season")]
        public int Season { get; set; }
    }

    public class Constructors
    {
        [JsonPropertyName("get")]
        public string Get { get; set; }

        [JsonPropertyName("parameters")]
        public ConstructorParameters Parameters { get; set; }

        [JsonPropertyName("errors")]
        public List<object> Errors { get; set; }

        [JsonPropertyName("results")]
        public int Results { get; set; }

        [JsonPropertyName("response")]
        public List<ConstructorResponse> Response { get; set; }
    }

    public class ConstructorTeam
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("logo")]
        public string Logo { get; set; }
    }


}

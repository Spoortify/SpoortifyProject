using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Sportify.Model
{
    public class Driver
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("abbr")]
        public string Abbr { get; set; }

        [JsonPropertyName("number")]
        public int? Number { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }
    }
    public class Parameters
    {
        [JsonPropertyName("season")]
        public string Season { get; set; }
    }
    public class Response
    {
        [JsonPropertyName("position")]
        public int Position { get; set; }

        [JsonPropertyName("driver")]
        public Driver Driver { get; set; }

        [JsonPropertyName("team")]
        public Formula1Team Team { get; set; }

        [JsonPropertyName("points")]
        public int? Points { get; set; }

        [JsonPropertyName("wins")]
        public int Wins { get; set; }

        [JsonPropertyName("behind")]
        public int? Behind { get; set; }

        [JsonPropertyName("season")]
        public int Season { get; set; }
    }
    public class Formula1
    {
        [JsonPropertyName("get")]
        public string Get { get; set; }

        [JsonPropertyName("parameters")]
        public Parameters Parameters { get; set; }

        [JsonPropertyName("errors")]
        public List<object> Errors { get; set; }

        [JsonPropertyName("results")]
        public int Results { get; set; }

        [JsonPropertyName("response")]
        public List<Response> Response { get; set; }
    }
    public class Formula1Team
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("logo")]
        public string Logo { get; set; }
    }
}

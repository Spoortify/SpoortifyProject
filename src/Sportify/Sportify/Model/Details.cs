using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Sportify.Model
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class DetailDriver
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("abbr")]
        public string Abbr { get; set; }

        [JsonPropertyName("number")]
        public int Number { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }
    }
    public class DetailParameters
    {
        [JsonPropertyName("race")]
        public string Race { get; set; }
    }
    public class Race
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
    public class DetailResponse
    {
        [JsonPropertyName("race")]
        public Race Race { get; set; }

        [JsonPropertyName("driver")]
        public DetailDriver Driver { get; set; }

        [JsonPropertyName("team")]
        public DetailTeam Team { get; set; }

        [JsonPropertyName("position")]
        public int Position { get; set; }

        [JsonPropertyName("time")]
        public string Time { get; set; }

        [JsonPropertyName("laps")]
        public int Laps { get; set; }

        [JsonPropertyName("grid")]
        public string Grid { get; set; }

        [JsonPropertyName("pits")]
        public int Pits { get; set; }

        [JsonPropertyName("gap")]
        public object Gap { get; set; }
    }
    public class Details
    {
        [JsonPropertyName("get")]
        public string Get { get; set; }

        [JsonPropertyName("parameters")]
        public DetailParameters Parameters { get; set; }

        [JsonPropertyName("errors")]
        public List<object> Errors { get; set; }

        [JsonPropertyName("results")]
        public int Results { get; set; }

        [JsonPropertyName("response")]
        public List<DetailResponse> Response { get; set; }
    }
    public class DetailTeam
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("logo")]
        public string Logo { get; set; }
    }
}

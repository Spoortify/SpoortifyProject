using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Sportify.Model
{
    public class Competition
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("location")]
        public Location Location { get; set; }
    }
    public class LapRecord
    {
        [JsonPropertyName("time")]
        public string Time { get; set; }

        [JsonPropertyName("driver")]
        public string Driver { get; set; }

        [JsonPropertyName("year")]
        public string Year { get; set; }
    }
    public class Location
    {
        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }
    }
    public class TrackResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("competition")]
        public Competition Competition { get; set; }

        [JsonPropertyName("first_grand_prix")]
        public int FirstGrandPrix { get; set; }

        [JsonPropertyName("laps")]
        public int Laps { get; set; }

        [JsonPropertyName("length")]
        public string Length { get; set; }

        [JsonPropertyName("race_distance")]
        public string RaceDistance { get; set; }

        [JsonPropertyName("lap_record")]
        public LapRecord LapRecord { get; set; }

        [JsonPropertyName("capacity")]
        public int? Capacity { get; set; }

        [JsonPropertyName("opened")]
        public int? Opened { get; set; }

        [JsonPropertyName("owner")]
        public string Owner { get; set; }
    }
    public class Tracks
    {
        [JsonPropertyName("get")]
        public string Get { get; set; }

        [JsonPropertyName("parameters")]
        public List<object> Parameters { get; set; }

        [JsonPropertyName("errors")]
        public List<object> Errors { get; set; }

        [JsonPropertyName("results")]
        public int Results { get; set; }

        [JsonPropertyName("response")]
        public List<TrackResponse> Response { get; set; }
    }
}

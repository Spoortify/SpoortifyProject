using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Sportify.Model
{
    public class FootballListPaging
    {
        [JsonPropertyName("current")]
        public int Current { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }
    }

    public class FootballListParameters
    {
        [JsonPropertyName("league")]
        public string League { get; set; }

        [JsonPropertyName("season")]
        public string Season { get; set; }
    }

    public class FootballListResponse
    {
        [JsonPropertyName("team")]
        public FootballListTeam Team { get; set; }

        [JsonPropertyName("venue")]
        public FootballListVenue Venue { get; set; }
    }

    public class FootballList
    {
        [JsonPropertyName("get")]
        public string Get { get; set; }

        [JsonPropertyName("parameters")]
        public FootballListParameters Parameters { get; set; }

        [JsonPropertyName("errors")]
        public List<object> Errors { get; set; }

        [JsonPropertyName("results")]
        public int Results { get; set; }

        [JsonPropertyName("paging")]
        public FootballListPaging Paging { get; set; }

        [JsonPropertyName("response")]
        public List<FootballListResponse> Response { get; set; }
    }

    public class FootballListTeam
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("founded")]
        public int Founded { get; set; }

        [JsonPropertyName("national")]
        public bool National { get; set; }

        [JsonPropertyName("logo")]
        public string Logo { get; set; }
    }

    public class FootballListVenue
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("capacity")]
        public int Capacity { get; set; }

        [JsonPropertyName("surface")]
        public string Surface { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }
        public string FullName => $"{Name}, {City}";
    }
}

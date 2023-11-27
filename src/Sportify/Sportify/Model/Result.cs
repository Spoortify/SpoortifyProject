using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Sportify.Model
{
    public class Circuit
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }
    }
    public class ResultsCompetition
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("location")]
        public ResultsLocation Location { get; set; }
    }
    public class ResultsDriver
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }
    }
    public class FastestLap
    {
        [JsonPropertyName("driver")]
        public ResultsDriver Driver { get; set; }

        [JsonPropertyName("time")]
        public string Time { get; set; }
    }

    public class Laps
    {
        [JsonPropertyName("current")]
        public object Current { get; set; }

        [JsonPropertyName("total")]
        public int? Total { get; set; }
    }

    public class ResultsLocation
    {
        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }
    }

    public class ResultsParameters
    {
        [JsonPropertyName("season")]
        public string Season { get; set; }
    }

    public class ResultsResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("competition")]
        public ResultsCompetition Competition { get; set; }

        [JsonPropertyName("circuit")]
        public Circuit Circuit { get; set; }

        [JsonPropertyName("season")]
        public int Season { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("laps")]
        public Laps Laps { get; set; }

        [JsonPropertyName("fastest_lap")]
        public FastestLap FastestLap { get; set; }

        [JsonPropertyName("distance")]
        public string Distance { get; set; }

        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }

        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        [JsonPropertyName("weather")]
        public object Weather { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    }

    public class Result
    {
        [JsonPropertyName("get")]
        public string Get { get; set; }

        [JsonPropertyName("parameters")]
        public ResultsParameters Parameters { get; set; }

        [JsonPropertyName("errors")]
        public List<object> Errors { get; set; }

        [JsonPropertyName("results")]
        public int Results { get; set; }

        [JsonPropertyName("response")]
        public List<ResultsResponse> Response { get; set; }
    }


}

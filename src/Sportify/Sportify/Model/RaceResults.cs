using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Sportify.Model
{
    public class RaceCircuit
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }
    }
    public class RaceCompetition
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("location")]
        public RaceLocation Location { get; set; }
    }
    public class RaceDriver
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }
    }
    public class RaceFastestLap
    {
        [JsonPropertyName("driver")]
        public RaceDriver Driver { get; set; }

        [JsonPropertyName("time")]
        public string Time { get; set; }
    }
    public class RaceLaps
    {
        [JsonPropertyName("current")]
        public object Current { get; set; }

        [JsonPropertyName("total")]
        public int? Total { get; set; }
    }
    public class RaceLocation
    {
        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }
    }
    public class RaceParameters
    {
        [JsonPropertyName("season")]
        public string Season { get; set; }
    }
    public class RaceResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("competition")]
        public RaceCompetition Competition { get; set; }

        [JsonPropertyName("circuit")]
        public RaceCircuit Circuit { get; set; }

        [JsonPropertyName("season")]
        public int Season { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("laps")]
        public RaceLaps Laps { get; set; }

        [JsonPropertyName("fastest_lap")]
        public RaceFastestLap FastestLap { get; set; }

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

    public class RaceResult
    {
        [JsonPropertyName("get")]
        public string Get { get; set; }

        [JsonPropertyName("parameters")]
        public RaceParameters Parameters { get; set; }

        [JsonPropertyName("errors")]
        public List<object> Errors { get; set; }

        [JsonPropertyName("results")]
        public int Results { get; set; }

        [JsonPropertyName("response")]
        public List<RaceResponse> Response { get; set; }
    }


}

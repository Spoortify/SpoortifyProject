using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Sportify.Model
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);

    public class Away
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        [JsonPropertyName("hits")]
        public object Hits { get; set; }

        [JsonPropertyName("errors")]
        public object Errors { get; set; }

        [JsonPropertyName("innings")]
        public Innings Innings { get; set; }

        [JsonPropertyName("total")]
        public object Total { get; set; }
    }

    public class Country
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("flag")]
        public string Flag { get; set; }
    }

    public class Home
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        [JsonPropertyName("hits")]
        public object Hits { get; set; }

        [JsonPropertyName("errors")]
        public object Errors { get; set; }

        [JsonPropertyName("innings")]
        public Innings Innings { get; set; }

        [JsonPropertyName("total")]
        public object Total { get; set; }
    }

    public class Innings
    {
        [JsonPropertyName("1")]
        public object _1 { get; set; }

        [JsonPropertyName("2")]
        public object _2 { get; set; }

        [JsonPropertyName("3")]
        public object _3 { get; set; }

        [JsonPropertyName("4")]
        public object _4 { get; set; }

        [JsonPropertyName("5")]
        public object _5 { get; set; }

        [JsonPropertyName("6")]
        public object _6 { get; set; }

        [JsonPropertyName("7")]
        public object _7 { get; set; }

        [JsonPropertyName("8")]
        public object _8 { get; set; }

        [JsonPropertyName("9")]
        public object _9 { get; set; }

        [JsonPropertyName("extra")]
        public object Extra { get; set; }
    }

    public class League
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        [JsonPropertyName("season")]
        public int Season { get; set; }
    }

    public class Parameters
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }
    }

    public class Response
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        [JsonPropertyName("time")]
        public string Time { get; set; }

        [JsonPropertyName("timestamp")]
        public int Timestamp { get; set; }

        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }

        [JsonPropertyName("week")]
        public object Week { get; set; }

        [JsonPropertyName("status")]
        public Status Status { get; set; }

        [JsonPropertyName("country")]
        public Country Country { get; set; }

        [JsonPropertyName("league")]
        public League League { get; set; }

        [JsonPropertyName("teams")]
        public Teams Teams { get; set; }

        [JsonPropertyName("scores")]
        public Scores Scores { get; set; }
    }

    public class BaseballGame
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

    public class Scores
    {
        [JsonPropertyName("home")]
        public Home Home { get; set; }

        [JsonPropertyName("away")]
        public Away Away { get; set; }
    }

    public class Status
    {
        [JsonPropertyName("long")]
        public string Long { get; set; }

        [JsonPropertyName("short")]
        public string Short { get; set; }
    }

    public class Teams
    {
        [JsonPropertyName("home")]
        public Home Home { get; set; }

        [JsonPropertyName("away")]
        public Away Away { get; set; }
    }


}

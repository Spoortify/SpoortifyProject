using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Sportify.Model
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);

    public class BaseballGameAway
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
        public BaseballGameInnings Innings { get; set; }

        [JsonPropertyName("total")]
        public object Total { get; set; }
    }

    public class BaseballGameCountry
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

    public class BaseballGameHome
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
        public BaseballGameInnings Innings { get; set; }

        [JsonPropertyName("total")]
        public object Total { get; set; }
    }

    public class BaseballGameInnings
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

    public class BaseballGameLeague
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

    public class BaseballGameParameters
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }
    }

    public class BaseballGameResponse
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
        public BaseballGameStatus Status { get; set; }

        [JsonPropertyName("country")]
        public BaseballGameCountry Country { get; set; }

        [JsonPropertyName("league")]
        public BaseballGameLeague League { get; set; }

        [JsonPropertyName("teams")]
        public BaseballGameTeams Teams { get; set; }

        [JsonPropertyName("scores")]
        public BaseballGameScores Scores { get; set; }
    }

    public class BaseballGame
    {
        [JsonPropertyName("get")]
        public string Get { get; set; }

        [JsonPropertyName("parameters")]
        public BaseballGameParameters Parameters { get; set; }

        [JsonPropertyName("errors")]
        public List<object> Errors { get; set; }

        [JsonPropertyName("results")]
        public int Results { get; set; }

        [JsonPropertyName("response")]
        public List<BaseballGameResponse> Response { get; set; }
    }

    public class BaseballGameScores
    {
        [JsonPropertyName("home")]
        public BaseballGameHome Home { get; set; }

        [JsonPropertyName("away")]
        public BaseballGameAway Away { get; set; }
    }

    public class BaseballGameStatus
    {
        [JsonPropertyName("long")]
        public string Long { get; set; }

        [JsonPropertyName("short")]
        public string Short { get; set; }
    }

    public class BaseballGameTeams
    {
        [JsonPropertyName("home")]
        public BaseballGameHome Home { get; set; }

        [JsonPropertyName("away")]
        public BaseballGameAway Away { get; set; }
    }


}

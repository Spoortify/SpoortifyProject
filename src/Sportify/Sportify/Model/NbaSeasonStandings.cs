using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Sportify.Model
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Conference
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("rank")]
        public int Rank { get; set; }

        [JsonPropertyName("win")]
        public int Win { get; set; }

        [JsonPropertyName("loss")]
        public int Loss { get; set; }
    }

    public class Division
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("rank")]
        public int Rank { get; set; }

        [JsonPropertyName("win")]
        public int Win { get; set; }

        [JsonPropertyName("loss")]
        public int Loss { get; set; }

        [JsonPropertyName("gamesBehind")]
        public string GamesBehind { get; set; }
    }

    public class Loss
    {
        [JsonPropertyName("home")]
        public int Home { get; set; }

        [JsonPropertyName("away")]
        public int Away { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("percentage")]
        public string Percentage { get; set; }

        [JsonPropertyName("lastTen")]
        public int LastTen { get; set; }
    }

    public class Parameters
    {
        [JsonPropertyName("league")]
        public string League { get; set; }

        [JsonPropertyName("season")]
        public string Season { get; set; }
    }

    public class NBAResponse
    {
        [JsonPropertyName("league")]
        public string League { get; set; }

        [JsonPropertyName("season")]
        public int Season { get; set; }

        [JsonPropertyName("team")]
        public Team Team { get; set; }

        [JsonPropertyName("conference")]
        public Conference Conference { get; set; }

        [JsonPropertyName("division")]
        public Division Division { get; set; }

        [JsonPropertyName("win")]
        public Win Win { get; set; }

        [JsonPropertyName("loss")]
        public Loss Loss { get; set; }

        [JsonPropertyName("gamesBehind")]
        public string GamesBehind { get; set; }

        [JsonPropertyName("streak")]
        public int Streak { get; set; }

        [JsonPropertyName("winStreak")]
        public bool WinStreak { get; set; }

        [JsonPropertyName("tieBreakerPoints")]
        public object TieBreakerPoints { get; set; }
    }

    public class NbaSeasonStandings
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
        public List<NBAResponse> Response { get; set; }
    }

    public class Team
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("nickname")]
        public string Nickname { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("logo")]
        public string Logo { get; set; }
    }

    public class Win
    {
        [JsonPropertyName("home")]
        public int Home { get; set; }

        [JsonPropertyName("away")]
        public int Away { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("percentage")]
        public string Percentage { get; set; }

        [JsonPropertyName("lastTen")]
        public int LastTen { get; set; }
    }


}

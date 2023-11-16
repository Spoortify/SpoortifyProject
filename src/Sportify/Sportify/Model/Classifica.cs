using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Sportify.Model
{
    public class ClassificaParameters
    {
        [JsonPropertyName("league")]
        public string League { get; set; }

        [JsonPropertyName("season")]
        public string Season { get; set; }
    }

    public class BaseballStandings
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
        public List<List<BaseballStandingsResponse>> Response { get; set; }
    }

    public class BaseballStandingsResponse
    {
        [JsonPropertyName("position")]
        public int Position { get; set; }

        [JsonPropertyName("stage")]
        public string Stage { get; set; }

        [JsonPropertyName("group")]
        public Group Group { get; set; }

        [JsonPropertyName("team")]
        public ClassificaTeam Team { get; set; }

        [JsonPropertyName("league")]
        public ClassificaLeague League { get; set; }

        [JsonPropertyName("country")]
        public ClassificaCountry Country { get; set; }

        [JsonPropertyName("games")]
        public Games Games { get; set; }

        [JsonPropertyName("points")]
        public Points Points { get; set; }

        [JsonPropertyName("form")]
        public string Form { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }

    public class Group
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class ClassificaTeam
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("logo")]
        public string Logo { get; set; }
    }

    public class ClassificaLeague
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

    public class ClassificaCountry
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

    public class Games
    {
        [JsonPropertyName("played")]
        public int Played { get; set; }

        [JsonPropertyName("win")]
        public Win Win { get; set; }

        [JsonPropertyName("lose")]
        public Lose Lose { get; set; }
    }

    public class Win
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("percentage")]
        public string Percentage { get; set; }
    }

    public class Lose
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("percentage")]
        public string Percentage { get; set; }
    }

    public class Points
    {
        [JsonPropertyName("for")]
        public int For { get; set; }

        [JsonPropertyName("against")]
        public int Against { get; set; }
    }
}
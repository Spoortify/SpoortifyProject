using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Sportify.Model
{
    public class BaseballStandingsParameters
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
        public BaseballStandingsParameters Parameters { get; set; }

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
        public BaseballStandingsGroup Group { get; set; }

        [JsonPropertyName("team")]
        public BaseballStandingsTeam Team { get; set; }

        [JsonPropertyName("league")]
        public BaseballStandingsLeague League { get; set; }

        [JsonPropertyName("country")]
        public BaseballStandingsCountry Country { get; set; }

        [JsonPropertyName("games")]
        public BaseballStandingsGames Games { get; set; }

        [JsonPropertyName("points")]
        public BaseballStandingsPoints Points { get; set; }

        [JsonPropertyName("form")]
        public string Form { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }

    public class BaseballStandingsGroup
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class BaseballStandingsTeam
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("logo")]
        public string Logo { get; set; }
    }

    public class BaseballStandingsLeague
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

    public class BaseballStandingsCountry
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

    public class BaseballStandingsGames
    {
        [JsonPropertyName("played")]
        public int Played { get; set; }

        [JsonPropertyName("win")]
        public BaseballStandingsWin Win { get; set; }

        [JsonPropertyName("lose")]
        public BaseballStandingsLose Lose { get; set; }
    }

    public class BaseballStandingsWin
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("percentage")]
        public string Percentage { get; set; }
    }

    public class BaseballStandingsLose
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("percentage")]
        public string Percentage { get; set; }
    }

    public class BaseballStandingsPoints
    {
        [JsonPropertyName("for")]
        public int For { get; set; }

        [JsonPropertyName("against")]
        public int Against { get; set; }
    }
}
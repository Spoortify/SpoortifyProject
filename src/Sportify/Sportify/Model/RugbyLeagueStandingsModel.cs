using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sportify.Model
{
    public class RugbyLeagueStandingsModelParameters
    {
        [JsonPropertyName("league")]
        public string League { get; set; }

        [JsonPropertyName("season")]
        public string Season { get; set; }
    }

    public class RugbyLeagueStandingsModel
    {
        [JsonPropertyName("get")]
        public string Get { get; set; }

        [JsonPropertyName("parameters")]
        public RugbyLeagueStandingsModelParameters Parameters { get; set; }

        [JsonPropertyName("errors")]
        public List<object> Errors { get; set; }

        [JsonPropertyName("results")]
        public int Results { get; set; }

        [JsonPropertyName("response")]
        public List<List<RugbyLeagueStandingsResponse>> Response { get; set; }
    }

    public class RugbyLeagueStandingsResponse
    {
        [JsonPropertyName("position")]
        public int Position { get; set; }

        [JsonPropertyName("stage")]
        public string Stage { get; set; }

        [JsonPropertyName("group")]
        public RugbyLeagueStandingsGroup Group { get; set; }

        [JsonPropertyName("team")]
        public RugbyLeagueStandingsModelTeam Team { get; set; }

        [JsonPropertyName("league")]
        public RugbyLeagueStandingsLeague League { get; set; }

        [JsonPropertyName("country")]
        public RugbyLeagueStandingsCountry Country { get; set; }

        [JsonPropertyName("games")]
        public RugbyLeagueStandingsGames Games { get; set; }

        [JsonPropertyName("goals")]
        public RugbyLeagueStandingsGoals Goals { get; set; }

        [JsonPropertyName("points")]
        public int Points { get; set; }

        [JsonPropertyName("form")]
        public string Form { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }

    public class RugbyLeagueStandingsGroup
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class RugbyLeagueStandingsModelTeam
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("logo")]
        public string Logo { get; set; }
    }

    public class RugbyLeagueStandingsLeague
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

    public class RugbyLeagueStandingsCountry
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

    public class RugbyLeagueStandingsGames
    {
        [JsonPropertyName("played")]
        public int Played { get; set; }

        [JsonPropertyName("win")]
        public RugbyLeagueStandingsWin Win { get; set; }

        [JsonPropertyName("draw")]
        public RugbyLeagueStandingsDraw Draw { get; set; }

        [JsonPropertyName("lose")]
        public RugbyLeagueStandingsLose Lose { get; set; }
    }

    public class RugbyLeagueStandingsWin
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("percentage")]
        public string Percentage { get; set; }
    }

    public class RugbyLeagueStandingsDraw
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("percentage")]
        public string Percentage { get; set; }
    }

    public class RugbyLeagueStandingsLose
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("percentage")]
        public string Percentage { get; set; }
    }

    public class RugbyLeagueStandingsGoals
    {
        [JsonPropertyName("for")]
        public int For { get; set; }

        [JsonPropertyName("against")]
        public int Against { get; set; }
    }
}
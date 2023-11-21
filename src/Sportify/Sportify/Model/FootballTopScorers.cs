using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Sportify.Model
{
    public class FootballTopScorersBirth
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("place")]
        public string Place { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }
    }

    public class FootballTopScorersCards
    {
        [JsonPropertyName("yellow")]
        public int Yellow { get; set; }

        [JsonPropertyName("yellowred")]
        public int Yellowred { get; set; }

        [JsonPropertyName("red")]
        public int Red { get; set; }
    }

    public class FootballTopScorersDribbles
    {
        [JsonPropertyName("attempts")]
        public int Attempts { get; set; }

        [JsonPropertyName("success")]
        public int Success { get; set; }

        [JsonPropertyName("past")]
        public object Past { get; set; }
    }

    public class FootballTopScorersDuels
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("won")]
        public int Won { get; set; }
    }

    public class FootballTopScorersFouls
    {
        [JsonPropertyName("drawn")]
        public int Drawn { get; set; }

        [JsonPropertyName("committed")]
        public int Committed { get; set; }
    }

    public class FootballTopScorersGames
    {
        [JsonPropertyName("appearences")]
        public int Appearences { get; set; }

        [JsonPropertyName("lineups")]
        public int Lineups { get; set; }

        [JsonPropertyName("minutes")]
        public int Minutes { get; set; }

        [JsonPropertyName("number")]
        public object Number { get; set; }

        [JsonPropertyName("position")]
        public string Position { get; set; }

        [JsonPropertyName("rating")]
        public string Rating { get; set; }

        [JsonPropertyName("captain")]
        public bool Captain { get; set; }
    }

    public class FootballTopScorersGoals
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("conceded")]
        public int Conceded { get; set; }

        [JsonPropertyName("assists")]
        public int? Assists { get; set; }

        [JsonPropertyName("saves")]
        public object Saves { get; set; }
    }

    public class FootballTopScorersLeague
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        [JsonPropertyName("flag")]
        public string Flag { get; set; }

        [JsonPropertyName("season")]
        public int Season { get; set; }
    }

    public class FootballTopScorersPaging
    {
        [JsonPropertyName("current")]
        public int Current { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }
    }

    public class FootballTopScorersParameters
    {
        [JsonPropertyName("league")]
        public string League { get; set; }

        [JsonPropertyName("season")]
        public string Season { get; set; }
    }

    public class FootballTopScorersPasses
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("key")]
        public int Key { get; set; }

        [JsonPropertyName("accuracy")]
        public int Accuracy { get; set; }
    }

    public class FootballTopScorersPenalty
    {
        [JsonPropertyName("won")]
        public object Won { get; set; }

        [JsonPropertyName("commited")]
        public object Commited { get; set; }

        [JsonPropertyName("scored")]
        public int Scored { get; set; }

        [JsonPropertyName("missed")]
        public int Missed { get; set; }

        [JsonPropertyName("saved")]
        public object Saved { get; set; }
    }

    public class FootballTopScorersPlayer
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("firstname")]
        public string Firstname { get; set; }

        [JsonPropertyName("lastname")]
        public string Lastname { get; set; }

        [JsonPropertyName("age")]
        public int Age { get; set; }

        [JsonPropertyName("birth")]
        public FootballTopScorersBirth Birth { get; set; }

        [JsonPropertyName("nationality")]
        public string Nationality { get; set; }

        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("weight")]
        public string Weight { get; set; }

        [JsonPropertyName("injured")]
        public bool Injured { get; set; }

        [JsonPropertyName("photo")]
        public string Photo { get; set; }
    }

    public class FootballTopScorersResponse
    {
        [JsonPropertyName("player")]
        public FootballTopScorersPlayer Player { get; set; }

        [JsonPropertyName("statistics")]
        public List<FootballTopScorersStatistic> Statistics { get; set; }
    }

    public class FootballTopScorers
    {
        [JsonPropertyName("get")]
        public string Get { get; set; }

        [JsonPropertyName("parameters")]
        public FootballTopScorersParameters Parameters { get; set; }

        [JsonPropertyName("errors")]
        public List<object> Errors { get; set; }

        [JsonPropertyName("results")]
        public int Results { get; set; }

        [JsonPropertyName("paging")]
        public FootballTopScorersPaging Paging { get; set; }

        [JsonPropertyName("response")]
        public List<FootballTopScorersResponse> Response { get; set; }
    }

    public class FootballTopScorersShots
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("on")]
        public int On { get; set; }
    }

    public class FootballTopScorersStatistic
    {
        [JsonPropertyName("team")]
        public FootballTopScorersTeam Team { get; set; }

        [JsonPropertyName("league")]
        public FootballTopScorersLeague League { get; set; }

        [JsonPropertyName("games")]
        public FootballTopScorersGames Games { get; set; }

        [JsonPropertyName("substitutes")]
        public FootballTopScorersSubstitutes Substitutes { get; set; }

        [JsonPropertyName("shots")]
        public FootballTopScorersShots Shots { get; set; }

        [JsonPropertyName("goals")]
        public FootballTopScorersGoals Goals { get; set; }

        [JsonPropertyName("passes")]
        public FootballTopScorersPasses Passes { get; set; }

        [JsonPropertyName("tackles")]
        public FootballTopScorersTackles Tackles { get; set; }

        [JsonPropertyName("duels")]
        public FootballTopScorersDuels Duels { get; set; }

        [JsonPropertyName("dribbles")]
        public FootballTopScorersDribbles Dribbles { get; set; }

        [JsonPropertyName("fouls")]
        public FootballTopScorersFouls Fouls { get; set; }

        [JsonPropertyName("cards")]
        public FootballTopScorersCards Cards { get; set; }

        [JsonPropertyName("penalty")]
        public FootballTopScorersPenalty Penalty { get; set; }
    }

    public class FootballTopScorersSubstitutes
    {
        [JsonPropertyName("in")]
        public int In { get; set; }

        [JsonPropertyName("out")]
        public int Out { get; set; }

        [JsonPropertyName("bench")]
        public int Bench { get; set; }
    }

    public class FootballTopScorersTackles
    {
        [JsonPropertyName("total")]
        public int? Total { get; set; }

        [JsonPropertyName("blocks")]
        public int? Blocks { get; set; }

        [JsonPropertyName("interceptions")]
        public int? Interceptions { get; set; }
    }

    public class FootballTopScorersTeam
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("logo")]
        public string Logo { get; set; }
    }
}
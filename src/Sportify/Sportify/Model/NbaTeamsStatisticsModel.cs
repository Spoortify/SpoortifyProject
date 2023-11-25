using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Sportify.Model
{
    public class TeamsParameters
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("season")]
        public string Season { get; set; }
    }

    public class NBATeamsResponse
    {
        [JsonPropertyName("games")]
        public int Games { get; set; }

        [JsonPropertyName("fastBreakPoints")]
        public int FastBreakPoints { get; set; }

        [JsonPropertyName("pointsInPaint")]
        public int PointsInPaint { get; set; }

        [JsonPropertyName("biggestLead")]
        public int BiggestLead { get; set; }

        [JsonPropertyName("secondChancePoints")]
        public int SecondChancePoints { get; set; }

        [JsonPropertyName("pointsOffTurnovers")]
        public int PointsOffTurnovers { get; set; }

        [JsonPropertyName("longestRun")]
        public int LongestRun { get; set; }

        [JsonPropertyName("points")]
        public int Points { get; set; }

        [JsonPropertyName("fgm")]
        public int Fgm { get; set; }

        [JsonPropertyName("fga")]
        public int Fga { get; set; }

        [JsonPropertyName("fgp")]
        public string Fgp { get; set; }

        [JsonPropertyName("ftm")]
        public int Ftm { get; set; }

        [JsonPropertyName("fta")]
        public int Fta { get; set; }

        [JsonPropertyName("ftp")]
        public string Ftp { get; set; }

        [JsonPropertyName("tpm")]
        public int Tpm { get; set; }

        [JsonPropertyName("tpa")]
        public int Tpa { get; set; }

        [JsonPropertyName("tpp")]
        public string Tpp { get; set; }

        [JsonPropertyName("offReb")]
        public int OffReb { get; set; }

        [JsonPropertyName("defReb")]
        public int DefReb { get; set; }

        [JsonPropertyName("totReb")]
        public int TotReb { get; set; }

        [JsonPropertyName("assists")]
        public int Assists { get; set; }

        [JsonPropertyName("pFouls")]
        public int PFouls { get; set; }

        [JsonPropertyName("steals")]
        public int Steals { get; set; }

        [JsonPropertyName("turnovers")]
        public int Turnovers { get; set; }

        [JsonPropertyName("blocks")]
        public int Blocks { get; set; }

        [JsonPropertyName("plusMinus")]
        public int PlusMinus { get; set; }
    }

    public class NbaTeamsStatisticsModel
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
        public List<NBATeamsResponse> Response { get; set; }
    }


}

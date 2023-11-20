using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Sportify.Model
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Game
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }

    public class NbaPStatsParameters
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("season")]
        public string Season { get; set; }
    }

    public class Player
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("firstname")]
        public string Firstname { get; set; }

        [JsonPropertyName("lastname")]
        public string Lastname { get; set; }
    }

    public class NbaPStatsResponse
    {
        [JsonPropertyName("player")]
        public Player Player { get; set; }

        [JsonPropertyName("team")]
        public Team Team { get; set; }

        [JsonPropertyName("game")]
        public Game Game { get; set; }

        [JsonPropertyName("points")]
        public int Points { get; set; }

        [JsonPropertyName("pos")]
        public string Pos { get; set; }

        [JsonPropertyName("min")]
        public string Min { get; set; }

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
        public string PlusMinus { get; set; }

        [JsonPropertyName("comment")]
        public object Comment { get; set; }
    }

    public class NbaPlayerStatisticsModel
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
        public List<NbaPStatsResponse> Response { get; set; }
    }

    public class NBaPStatsTeam
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


}

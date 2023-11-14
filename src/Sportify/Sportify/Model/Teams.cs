using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Sportify.Model
{
    public class HighestRaceFinish
    {
        [JsonPropertyName("position")]
        public int? Position { get; set; }

        [JsonPropertyName("number")]
        public int? Number { get; set; }
    }
    public class TeamResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        [JsonPropertyName("base")]
        public string Base { get; set; }

        [JsonPropertyName("first_team_entry")]
        public int? FirstTeamEntry { get; set; }

        [JsonPropertyName("world_championships")]
        public int? WorldChampionships { get; set; }

        [JsonPropertyName("highest_race_finish")]
        public HighestRaceFinish HighestRaceFinish { get; set; }

        [JsonPropertyName("pole_positions")]
        public int? PolePositions { get; set; }

        [JsonPropertyName("fastest_laps")]
        public int? FastestLaps { get; set; }

        [JsonPropertyName("president")]
        public string President { get; set; }

        [JsonPropertyName("director")]
        public string Director { get; set; }

        [JsonPropertyName("technical_manager")]
        public string TechnicalManager { get; set; }

        [JsonPropertyName("chassis")]
        public string Chassis { get; set; }

        [JsonPropertyName("engine")]
        public string Engine { get; set; }

        [JsonPropertyName("tyres")]
        public string Tyres { get; set; }
    }
    public class Teams
    {
        [JsonPropertyName("get")]
        public string Get { get; set; }

        [JsonPropertyName("parameters")]
        public List<object> Parameters { get; set; }

        [JsonPropertyName("errors")]
        public List<object> Errors { get; set; }

        [JsonPropertyName("results")]
        public int Results { get; set; }

        [JsonPropertyName("response")]
        public List<TeamResponse> Response { get; set; }
    }


}

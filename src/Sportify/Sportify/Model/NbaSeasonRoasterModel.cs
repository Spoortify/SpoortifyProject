using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Sportify.Model
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Birth
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }
    }

    public class Height
    {
        [JsonPropertyName("feets")]
        public string Feets { get; set; }

        [JsonPropertyName("inches")]
        public string Inches { get; set; }

        [JsonPropertyName("meters")]
        public string Meters { get; set; }
    }

    public class Leagues
    {
        [JsonPropertyName("standard")]
        public Standard Standard { get; set; }

        [JsonPropertyName("vegas")]
        public Vegas Vegas { get; set; }

        [JsonPropertyName("sacramento")]
        public Sacramento Sacramento { get; set; }
    }

    public class Nba
    {
        [JsonPropertyName("start")]
        public int Start { get; set; }

        [JsonPropertyName("pro")]
        public int Pro { get; set; }
    }

    public class RoasterParameters
    {
        [JsonPropertyName("season")]
        public string Season { get; set; }

        [JsonPropertyName("team")]
        public string Team { get; set; }
    }

    public class NBARoasterResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("firstname")]
        public string Firstname { get; set; }

        [JsonPropertyName("lastname")]
        public string Lastname { get; set; }

        [JsonPropertyName("birth")]
        public Birth Birth { get; set; }

        [JsonPropertyName("nba")]
        public Nba Nba { get; set; }

        [JsonPropertyName("height")]
        public Height Height { get; set; }

        [JsonPropertyName("weight")]
        public Weight Weight { get; set; }

        [JsonPropertyName("college")]
        public string College { get; set; }

        [JsonPropertyName("affiliation")]
        public string Affiliation { get; set; }

        [JsonPropertyName("leagues")]
        public Leagues Leagues { get; set; }
    }

    public class NbaSeasonRoasterModel
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
        public List<NBARoasterResponse> Response { get; set; }
    }

    public class Sacramento
    {
        [JsonPropertyName("jersey")]
        public int Jersey { get; set; }

        [JsonPropertyName("active")]
        public bool Active { get; set; }

        [JsonPropertyName("pos")]
        public string Pos { get; set; }
    }

    public class Standard
    {
        [JsonPropertyName("jersey")]
        public int? Jersey { get; set; }

        [JsonPropertyName("active")]
        public bool Active { get; set; }

        [JsonPropertyName("pos")]
        public string Pos { get; set; }
    }

    public class Vegas
    {
        [JsonPropertyName("jersey")]
        public int Jersey { get; set; }

        [JsonPropertyName("active")]
        public bool Active { get; set; }

        [JsonPropertyName("pos")]
        public string Pos { get; set; }
    }

    public class Weight
    {
        [JsonPropertyName("pounds")]
        public string Pounds { get; set; }

        [JsonPropertyName("kilograms")]
        public string Kilograms { get; set; }
    }


}

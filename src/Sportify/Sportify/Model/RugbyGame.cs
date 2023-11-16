using System.Text.Json.Serialization;

namespace Sportify.Model
{
    public class Away
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("logo")]
        public string Logo { get; set; }
    }

    public class Home
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("logo")]
        public string Logo { get; set; }
    }

    public class RugbyGameLeague
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

    public class RugbyGameParameters
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }
    }

    public class RugbyGameResponse
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

        //[JsonPropertyName("week")]
        //public int week { get; set; }

        [JsonPropertyName("status")]
        public Status Status { get; set; }

        [JsonPropertyName("Country")]
        public RugbyGameCountry Country { get; set; }

        [JsonPropertyName("league")]
        public RugbyGameLeague League { get; set; }

        [JsonPropertyName("teams")]
        public Teams Teams { get; set; }

        [JsonPropertyName("scores")]
        public Score Score { get; set; }

        [JsonPropertyName("periods")]
        public Periods Periods { get; set; }
    }

    public class RugbyGame
    {
        [JsonPropertyName("get")]
        public string Get { get; set; }

        [JsonPropertyName("parameters")]
        public RugbyGameParameters Parameters { get; set; }

        [JsonPropertyName("errors")]
        public List<object> Errors { get; set; }

        [JsonPropertyName("results")]
        public int Results { get; set; }

        [JsonPropertyName("response")]
        public List<RugbyGameResponse> Responses { get; set; }
    }

    public class Score
    {
        [JsonPropertyName("home")]
        public int? Home { get; set; }

        [JsonPropertyName("away")]
        public int? Away { get; set; }
    }

    public class Status
    {
        [JsonPropertyName("long")]
        public string @long { get; set; }

        [JsonPropertyName("short")]
        public string @short { get; set; }

        [JsonPropertyName("elapsed")]
        public int? elapsed { get; set; }
    }

    public class Teams
    {
        [JsonPropertyName("home")]
        public Home Home { get; set; }

        [JsonPropertyName("away")]
        public Away Away { get; set; }
    }

    public class RugbyGameCountry
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("code")]
        public string? Code { get; set; }
        [JsonPropertyName("flag")]
        public string? Flag { get; set; }
    }

    public class Periods
    {
        [JsonPropertyName("first")]
        public First? First { get; set; }

        [JsonPropertyName("second")]
        public Second? Second { get; set; }

        [JsonPropertyName("overtime")]
        public Overtime? Overtime { get; set; }

        [JsonPropertyName("second_overtime")]
        public Second_Overtime? Second_overtime { get; set; }
    }

    public class First
    {
        [JsonPropertyName("home")]
        public int? HomePoints { get; set; }

        [JsonPropertyName("away")]
        public int? AwayPoints { get; set; }
    }

    public class Second
    {
        [JsonPropertyName("home")]
        public int? HomePoints { get; set; }

        [JsonPropertyName("away")]
        public int? AwayPoints { get; set; }
    }

    public class Overtime
    {
        [JsonPropertyName("home")]
        public int? HomePoints { get; set; }

        [JsonPropertyName("away")]
        public int? AwayPoints { get; set; }
    }

    public class Second_Overtime
    {
        [JsonPropertyName("home")]
        public int? HomePoints { get; set; }

        [JsonPropertyName("away")]
        public int? AwayPoints { get; set; }
    }
}
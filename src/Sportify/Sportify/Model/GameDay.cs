using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Sportify.Model
{
    public class GameDayAway
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        [JsonPropertyName("winner")]
        public bool? Winner { get; set; }
    }
    public class Extratime
    {
        [JsonPropertyName("home")]
        public object Home { get; set; }

        [JsonPropertyName("away")]
        public object Away { get; set; }
    }
    public class Fixture
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("referee")]
        public string Referee { get; set; }

        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }

        [JsonPropertyName("date")]
        public DateTime? Date { get; set; }

        [JsonPropertyName("timestamp")]
        public int? Timestamp { get; set; }

        [JsonPropertyName("periods")]
        public Periods Periods { get; set; }

        [JsonPropertyName("venue")]
        public Venue Venue { get; set; }

        [JsonPropertyName("status")]
        public Status Status { get; set; }
    }
    public class Fulltime
    {
        [JsonPropertyName("home")]
        public int? Home { get; set; }

        [JsonPropertyName("away")]
        public int? Away { get; set; }
    }
    public class GameDayGoals
    {
        [JsonPropertyName("home")]
        public int? Home { get; set; }

        [JsonPropertyName("away")]
        public int? Away { get; set; }
    }
    public class Halftime
    {
        [JsonPropertyName("home")]
        public int? Home { get; set; }

        [JsonPropertyName("away")]
        public int? Away { get; set; }
    }
    public class GameDayHome
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        [JsonPropertyName("winner")]
        public bool? Winner { get; set; }
    }
    public class League
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        [JsonPropertyName("flag")]
        public string Flag { get; set; }

        [JsonPropertyName("season")]
        public int? Season { get; set; }

        [JsonPropertyName("round")]
        public string Round { get; set; }
    }
    public class GameDayPaging
    {
        [JsonPropertyName("current")]
        public int? Current { get; set; }

        [JsonPropertyName("total")]
        public int? Total { get; set; }
    }
    public class Parameters
    {
        [JsonPropertyName("league")]
        public string League { get; set; }

        [JsonPropertyName("season")]
        public string Season { get; set; }
    }
    public class Penalty
    {
        [JsonPropertyName("home")]
        public object Home { get; set; }

        [JsonPropertyName("away")]
        public object Away { get; set; }
    }
    public class Periods
    {
        [JsonPropertyName("first")]
        public int? First { get; set; }

        [JsonPropertyName("second")]
        public int? Second { get; set; }
    }
    public class GameDayResponse
    {
        [JsonPropertyName("fixture")]
        public Fixture Fixture { get; set; }

        [JsonPropertyName("league")]
        public League League { get; set; }

        [JsonPropertyName("teams")]
        public Teams Teams { get; set; }

        [JsonPropertyName("goals")]
        public GameDayGoals Goals { get; set; }

        [JsonPropertyName("score")]
        public Score Score { get; set; }
    }
    public class GameDay
    {
        [JsonPropertyName("get")]
        public string Get { get; set; }

        [JsonPropertyName("parameters")]
        public Parameters Parameters { get; set; }

        [JsonPropertyName("errors")]
        public List<object> Errors { get; set; }

        [JsonPropertyName("results")]
        public int? Results { get; set; }

        [JsonPropertyName("paging")]
        public GameDayPaging Paging { get; set; }

        [JsonPropertyName("response")]
        public List<GameDayResponse> Response { get; set; }
    }
    public class Score
    {
        [JsonPropertyName("halftime")]
        public Halftime Halftime { get; set; }

        [JsonPropertyName("fulltime")]
        public Fulltime Fulltime { get; set; }

        [JsonPropertyName("extratime")]
        public Extratime Extratime { get; set; }

        [JsonPropertyName("penalty")]
        public Penalty Penalty { get; set; }
    }
    public class Status
    {
        [JsonPropertyName("long")]
        public string Long { get; set; }

        [JsonPropertyName("short")]
        public string Short { get; set; }

        [JsonPropertyName("elapsed")]
        public int? Elapsed { get; set; }
    }
    public class Teams
    {
        [JsonPropertyName("home")]
        public GameDayHome Home { get; set; }

        [JsonPropertyName("away")]
        public GameDayAway Away { get; set; }
    }
    public class Venue
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }
    }
}

using System.Text.Json.Serialization;

namespace Sportify.Model;
// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
public class HockeyGameAway
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("logo")]
    public string Logo { get; set; }
}

public class HockeyGameCountry
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

public class HockeyGameHome
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("logo")]
    public string Logo { get; set; }
}

public class HockeyGameLeague
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

public class HockeyGameParameters
{
    [JsonPropertyName("date")]
    public string Date { get; set; }
}

public class HockeyGamePeriods
{
    [JsonPropertyName("first")]
    public string First { get; set; }

    [JsonPropertyName("second")]
    public string Second { get; set; }

    [JsonPropertyName("third")]
    public string Third { get; set; }

    [JsonPropertyName("overtime")]
    public string Overtime { get; set; }

    [JsonPropertyName("penalties")]
    public string Penalties { get; set; }
}

public class HockeyGameResponse
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

    [JsonPropertyName("week")]
    public string Week { get; set; }

    [JsonPropertyName("timer")]
    public string Timer { get; set; }

    [JsonPropertyName("status")]
    public HockeyGameStatus Status { get; set; }

    [JsonPropertyName("country")]
    public HockeyGameCountry Country { get; set; }

    [JsonPropertyName("league")]
    public HockeyGameLeague League { get; set; }

    [JsonPropertyName("teams")]
    public HockeyGameTeams Teams { get; set; }

    [JsonPropertyName("scores")]
    public HockeyGameScores Scores { get; set; }

    [JsonPropertyName("periods")]
    public HockeyGamePeriods Periods { get; set; }

    [JsonPropertyName("events")]
    public bool Events { get; set; }
}

public class HockeyGame
{
    [JsonPropertyName("get")]
    public string Get { get; set; }

    [JsonPropertyName("parameters")]
    public HockeyGameParameters Parameters { get; set; }

    [JsonPropertyName("errors")]
    public List<object> Errors { get; set; }

    [JsonPropertyName("results")]
    public int Results { get; set; }

    [JsonPropertyName("response")]
    public List<HockeyGameResponse> Response { get; set; }
}

public class HockeyGameScores
{
    [JsonPropertyName("home")]
    public int? Home { get; set; }

    [JsonPropertyName("away")]
    public int? Away { get; set; }
}

public class HockeyGameStatus
{
    [JsonPropertyName("long")]
    public string Long { get; set; }

    [JsonPropertyName("short")]
    public string Short { get; set; }
}

public class HockeyGameTeams
{
    [JsonPropertyName("home")]
    public HockeyGameHome Home { get; set; }

    [JsonPropertyName("away")]
    public HockeyGameAway Away { get; set; }
}


using System.Text.Json.Serialization;

namespace test_api_football;

public class Away
{
    [JsonPropertyName("id")]
    public int id { get; set; }

    [JsonPropertyName("name")]
    public string name { get; set; }

    [JsonPropertyName("logo")]
    public string logo { get; set; }
}

public class Home
{
    [JsonPropertyName("id")]
    public int id { get; set; }

    [JsonPropertyName("name")]
    public string name { get; set; }

    [JsonPropertyName("logo")]
    public string logo { get; set; }
}

public class League
{
    [JsonPropertyName("id")]
    public int id { get; set; }

    [JsonPropertyName("name")]
    public string name { get; set; }

    [JsonPropertyName("type")]
    public string type { get; set; }

    [JsonPropertyName("logo")]
    public string logo { get; set; }

    [JsonPropertyName("season")]
    public int season { get; set; }
}

public class Parameters
{
    [JsonPropertyName("date")]
    public string date { get; set; }
}

public class Response
{
    [JsonPropertyName("id")]
    public int id { get; set; }

    [JsonPropertyName("date")]
    public DateTime date { get; set; }

    [JsonPropertyName("time")]
    public string time { get; set; }

    [JsonPropertyName("timestamp")]
    public int timestamp { get; set; }

    [JsonPropertyName("timezone")]
    public string timezone { get; set; }

    //[JsonPropertyName("week")]
    //public int week { get; set; }

    [JsonPropertyName("status")]
    public Status status { get; set; }

    [JsonPropertyName("Country")]
    public Country Country { get; set; }

    [JsonPropertyName("league")]
    public League league { get; set; }

    [JsonPropertyName("teams")]
    public Teams teams { get; set; }

    [JsonPropertyName("score")]
    public Score score { get; set; }

    [JsonPropertyName("periods")]
    public Periods periods { get; set; }
}

public class Rugby
{
    [JsonPropertyName("get")]
    public string get { get; set; }

    [JsonPropertyName("parameters")]
    public Parameters parameters { get; set; }

    [JsonPropertyName("errors")]
    public List<object> errors { get; set; }

    [JsonPropertyName("results")]
    public int results { get; set; }

    [JsonPropertyName("response")]
    public List<Response> responses { get; set; }
}

public class Score
{
    [JsonPropertyName("home")]
    public int home { get; set; }

    [JsonPropertyName("away")]
    public int away { get; set; }
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
    public Home home { get; set; }

    [JsonPropertyName("away")]
    public Away away { get; set; }
}

public class Country
{
    [JsonPropertyName("id")]
    public int? id { get; set; }

    [JsonPropertyName("name")]
    public string name { get; set; }

    [JsonPropertyName("code")]
    public string? code { get; set; }
    [JsonPropertyName("flag")]
    public string? flag { get; set; }
}

public class Periods
{
    [JsonPropertyName("first")]
    public First? first { get; set; }

    [JsonPropertyName("second")]
    public Second? second { get; set; }

    [JsonPropertyName("overtime")]
    public Overtime? overtime { get; set; }

    [JsonPropertyName("second_overtime")]
    public Second_Overtime? second_overtime { get; set; }
}

public class First
{
    [JsonPropertyName("home")]
    public int? homePoints { get; set; }

    [JsonPropertyName("away")]
    public int? awayPoints { get; set; }
}

public class Second
{
    [JsonPropertyName("home")]
    public int? homePoints { get; set; }

    [JsonPropertyName("away")]
    public int? awayPoints { get; set; }
}

public class Overtime
{
    [JsonPropertyName("home")]
    public int? homePoints { get; set; }

    [JsonPropertyName("away")]
    public int? awayPoints { get; set; }
}

public class Second_Overtime
{
    [JsonPropertyName("home")]
    public int? homePoints { get; set; }

    [JsonPropertyName("away")]
    public int? awayPoints { get; set; }
}
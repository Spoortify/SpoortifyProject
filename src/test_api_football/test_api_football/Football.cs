// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
using System.Text.Json.Serialization;

public class Away
{
    [JsonPropertyName("id")]
    public int id { get; set; }

    [JsonPropertyName("name")]
    public string name { get; set; }

    [JsonPropertyName("logo")]
    public string logo { get; set; }

    [JsonPropertyName("winner")]
    public bool? winner { get; set; }
}

public class Extratime
{
    [JsonPropertyName("home")]
    public object home { get; set; }

    [JsonPropertyName("away")]
    public object away { get; set; }
}

public class Fixture
{
    [JsonPropertyName("id")]
    public int id { get; set; }

    [JsonPropertyName("referee")]
    public string referee { get; set; }

    [JsonPropertyName("timezone")]
    public string timezone { get; set; }

    [JsonPropertyName("date")]
    public DateTime date { get; set; }

    [JsonPropertyName("timestamp")]
    public int timestamp { get; set; }

    [JsonPropertyName("periods")]
    public Periods periods { get; set; }

    [JsonPropertyName("venue")]
    public Venue venue { get; set; }

    [JsonPropertyName("status")]
    public Status status { get; set; }
}

public class Fulltime
{
    [JsonPropertyName("home")]
    public int? home { get; set; }

    [JsonPropertyName("away")]
    public int? away { get; set; }
}

public class Goals
{
    [JsonPropertyName("home")]
    public int? home { get; set; }

    [JsonPropertyName("away")]
    public int? away { get; set; }
}

public class Halftime
{
    [JsonPropertyName("home")]
    public int? home { get; set; }

    [JsonPropertyName("away")]
    public int? away { get; set; }
}

public class Home
{
    [JsonPropertyName("id")]
    public int id { get; set; }

    [JsonPropertyName("name")]
    public string name { get; set; }

    [JsonPropertyName("logo")]
    public string logo { get; set; }

    [JsonPropertyName("winner")]
    public bool? winner { get; set; }
}

public class League
{
    [JsonPropertyName("id")]
    public int id { get; set; }

    [JsonPropertyName("name")]
    public string name { get; set; }

    [JsonPropertyName("country")]
    public string country { get; set; }

    [JsonPropertyName("logo")]
    public string logo { get; set; }

    [JsonPropertyName("flag")]
    public string flag { get; set; }

    [JsonPropertyName("season")]
    public int season { get; set; }

    [JsonPropertyName("round")]
    public string round { get; set; }
}

public class Paging
{
    [JsonPropertyName("current")]
    public int current { get; set; }

    [JsonPropertyName("total")]
    public int total { get; set; }
}

public class Parameters
{
    [JsonPropertyName("date")]
    public string date { get; set; }
}

public class Penalty
{
    [JsonPropertyName("home")]
    public object home { get; set; }

    [JsonPropertyName("away")]
    public object away { get; set; }
}

public class Periods
{
    [JsonPropertyName("first")]
    public int? first { get; set; }

    [JsonPropertyName("second")]
    public int? second { get; set; }
}

public class Response
{
    [JsonPropertyName("fixture")]
    public Fixture fixture { get; set; }

    [JsonPropertyName("league")]
    public League league { get; set; }

    [JsonPropertyName("teams")]
    public Teams teams { get; set; }

    [JsonPropertyName("goals")]
    public Goals goals { get; set; }

    [JsonPropertyName("score")]
    public Score score { get; set; }
}

public class Football
{
    [JsonPropertyName("get")]
    public string get { get; set; }

    [JsonPropertyName("parameters")]
    public Parameters parameters { get; set; }

    [JsonPropertyName("errors")]
    public List<object> errors { get; set; }

    [JsonPropertyName("results")]
    public int results { get; set; }

    [JsonPropertyName("paging")]
    public Paging paging { get; set; }

    [JsonPropertyName("response")]
    public List<Response> response { get; set; }
}

public class Score
{
    [JsonPropertyName("halftime")]
    public Halftime halftime { get; set; }

    [JsonPropertyName("fulltime")]
    public Fulltime fulltime { get; set; }

    [JsonPropertyName("extratime")]
    public Extratime extratime { get; set; }

    [JsonPropertyName("penalty")]
    public Penalty penalty { get; set; }
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

public class Venue
{
    [JsonPropertyName("id")]
    public int? id { get; set; }

    [JsonPropertyName("name")]
    public string name { get; set; }

    [JsonPropertyName("city")]
    public string city { get; set; }
}
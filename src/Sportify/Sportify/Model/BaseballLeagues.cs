﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Sportify.Model
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class BaseballLeaguesCountry
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

    public class BaseballLeaguesParameters
    {
        [JsonPropertyName("season")]
        public string Season { get; set; }
    }

    public class BaseballLeaguesResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        [JsonPropertyName("country")]
        public BaseballLeaguesCountry Country { get; set; }

        [JsonPropertyName("seasons")]
        public List<BaseballSeason> Seasons { get; set; }
    }

    public class BaseballLeagues
    {
        [JsonPropertyName("get")]
        public string Get { get; set; }

        [JsonPropertyName("parameters")]
        public BaseballLeaguesParameters Parameters { get; set; }

        [JsonPropertyName("errors")]
        public List<object> Errors { get; set; }

        [JsonPropertyName("results")]
        public int Results { get; set; }

        [JsonPropertyName("response")]
        public List<BaseballLeaguesResponse> Response { get; set; }
    }

    public class BaseballSeason
    {
        [JsonPropertyName("season")]
        public int season { get; set; }

        [JsonPropertyName("current")]
        public bool Current { get; set; }

        [JsonPropertyName("start")]
        public string Start { get; set; }

        [JsonPropertyName("end")]
        public string End { get; set; }
    }
}

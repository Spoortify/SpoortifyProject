﻿using Sportify.View;
using Sportify.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;

namespace Sportify
{
    public partial class App : Application
    {
        public static HttpClient ClientF1 = new();
        public static HttpClient rugbyClient = new();
        public static HttpClient baseballClient = new();
        public static HttpClient FootballClient = new();
        private static readonly List<string> apiKeys = GetApi_Keys();
        //private static readonly string x_rapidapi_key = GetRandomApiKey();
        private static readonly string x_rapidapi_host_rugby = "v3.football.api-sports.io";
        private static readonly string x_rapidapi_host_formula1 = "v1.formula-1.api-sports.io";
        private static readonly string x_rapidapi_host_baseball = "v3.football.api-sports.io";
        private static readonly string x_rapidapi_host_football = "v3.football.api-sports.io";

        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
            ClientF1.BaseAddress = new Uri("https://v1.formula-1.api-sports.io");
            ClientF1.DefaultRequestHeaders.Add("x-rapidapi-key", GetRandomApiKey());
            ClientF1.DefaultRequestHeaders.Add("x-rapidapi-host", x_rapidapi_host_formula1);

            rugbyClient.BaseAddress = new Uri("https://v1.rugby.api-sports.io/");
            rugbyClient.DefaultRequestHeaders.Add("x-rapidapi-key", GetRandomApiKey());
            rugbyClient.DefaultRequestHeaders.Add("x-rapidapi-host", x_rapidapi_host_rugby);

            baseballClient.BaseAddress = new Uri("https://v1.baseball.api-sports.io");
            baseballClient.DefaultRequestHeaders.Add("x-rapidapi-key", GetRandomApiKey());
            baseballClient.DefaultRequestHeaders.Add("x-rapidapi-host", x_rapidapi_host_baseball);

            FootballClient.BaseAddress = new Uri("https://v3.football.api-sports.io");
            FootballClient.DefaultRequestHeaders.Add("x-rapidapi-key", GetRandomApiKey());
            FootballClient.DefaultRequestHeaders.Add("x-rapidapi-host", x_rapidapi_host_football);
        }

        private static List<string> GetApi_Keys()
        {
            var path = Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\..\\..\\..\\keys.json");
            string store = File.ReadAllText(path);
            Api_Key apiKeys = JsonSerializer.Deserialize<Api_Key>(store);
            return apiKeys?.APIKeyValues ?? new List<string>();
        }

        private static string GetRandomApiKey()
        {
            Random random = new Random();
            List<string> shuffledKeys = apiKeys.OrderBy(x => random.Next()).ToList();
            return shuffledKeys.FirstOrDefault();
        }

        public static string GetFootballLeagueId(string league)
        {
            int id = league switch
            {
                "SERIE A" => 135,
                "PREMIER LEAGUE" => 39,
                "LALIGA" => 140,
                "BUNDESLIGA" => 78,
                "LIGUE 1" => 61,
                "EREDIVISIE" => 88,
                "SUPER LIG" => 203,
                "LIGA PORTUGAL" => 94,
                "CHAMPIONS LEAGUE" => 2,
                "EUROPA LEAGUE" => 3,
                "CONFERENCE LEAGUE" => 848,
                "EURO2024 QUALIFICATION" => 960,
                _ => 39
            };
            return id.ToString();
        }
    }
}
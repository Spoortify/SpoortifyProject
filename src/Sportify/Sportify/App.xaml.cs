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
        public static HttpClient rugbyClient = new();
        private static readonly List<string> apiKeys = GetApi_Keys();
        private static readonly string x_rapidapi_key = GetRandomApiKey();
        private static readonly string x_rapidapi_host = "v3.football.api-sports.io";

        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
            rugbyClient.BaseAddress = new Uri("https://v1.rugby.api-sports.io/");
            rugbyClient.DefaultRequestHeaders.Add("x-rapidapi-key", x_rapidapi_key);
            rugbyClient.DefaultRequestHeaders.Add("x-rapidapi-host", x_rapidapi_host);
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
    }
}
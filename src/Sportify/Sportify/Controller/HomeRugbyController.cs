﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls;
using Sportify.Model;
using Sportify.View;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sportify.Controller
{
    public partial class HomeRugbyController : ObservableObject
    {
        private static HttpClient client = new();
        private static readonly Api_Key api_key = GetApi_Key();
        private static readonly string x_rapidapi_key = api_key.APIKeyValue;
        private static readonly string x_rapid_host = "v3.football.api-sports.io";
        private static bool isFirstRequest = true;

        [ObservableProperty]
        public static bool isBusy = false;

        [ObservableProperty]
        public static ObservableCollection<Response> rugbyGame = new();

        private static DateTime selectedDate = DateTime.Now;
        public DateTime SelectedDate
        {
            get => selectedDate;
            set => SetProperty(ref selectedDate, value);
        }

        public static async Task ShowGames()
        {
            if (isBusy) return;
            isBusy = true;
            rugbyGame.Clear();
            string formattedDate = selectedDate.ToString("yyyy-MM-dd");
            if (isFirstRequest)
            {
                client.BaseAddress = new Uri("https://v1.rugby.api-sports.io/");
                client.DefaultRequestHeaders.Add("x-rapidapi-key", x_rapidapi_key);
                client.DefaultRequestHeaders.Add("x-rapidapi-host", x_rapid_host);
            }
            var response = await client.GetAsync($"/games/?date={formattedDate}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var games = JsonSerializer.Deserialize<RugbyGame>(content);
                await Task.Run(() =>
                {
                    Parallel.ForEach(games.Responses, async game =>
                    {
                        await MainThread.InvokeOnMainThreadAsync(() =>
                        {
                            rugbyGame.Add(game);
                        });
                    });
                });
                isFirstRequest = false;
            }
            else
            {
                Console.WriteLine("Error: {0}", response.StatusCode);
            }
            isBusy = false;
        }

        static Api_Key GetApi_Key()
        {
            var path = Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\..\\..\\..\\keys.json");
            string store = File.ReadAllText(path);
            Api_Key? api_Key = JsonSerializer.Deserialize<Api_Key>(store);
            return api_Key ?? new Api_Key();
        }
    }
}

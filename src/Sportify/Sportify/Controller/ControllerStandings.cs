﻿using Sportify.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Sportify.Controller
{
    public partial class ControllerStandings
    {
        public static BaseballStandings myDeserializedClass;
        public ObservableCollection<BaseballStandingsResponse> Game { get; set; } = new ObservableCollection<BaseballStandingsResponse>();
        public int season;
        public int league;

        public ControllerStandings(int s, int l)
        {
            season = s;
            league = l;
        }

        public async void CreateList()
        {
            foreach (var item in myDeserializedClass.Response[0])
            {
                Game.Add(item);
            }
        }

        public async Task Start()
        {
            await GetBaseballApi();
            CreateList();
        }

        public string LinkQuery()
        {
            return $"/standings?league={league}&season={season}";
        }

        public async Task GetBaseballApi()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://v1.baseball.api-sports.io");
            client.DefaultRequestHeaders.Add("x-rapidapi-key", "50033e93a2d49d985f3daa64adae1a80");
            client.DefaultRequestHeaders.Add("x-rapidapi-host", "v3.football.api-sports.io");
            var response = await client.GetAsync(LinkQuery());
            var stringa = await response.Content.ReadAsStringAsync();
            myDeserializedClass = JsonSerializer.Deserialize<BaseballStandings>(stringa);
        }
    }
}

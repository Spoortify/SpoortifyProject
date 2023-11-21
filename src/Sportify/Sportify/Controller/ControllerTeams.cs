using CommunityToolkit.Mvvm.ComponentModel;
using Sportify.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Sportify.Controller
{
    public partial class ControllerTeams : ObservableObject
    {
        public static Team myDeserializedClass;
        public ObservableCollection<TeamsResponse> Game { get; set; } = new ObservableCollection<TeamsResponse>();
        public int season;
        public int league;

        [ObservableProperty]
        public bool isLoading = false;

        public ControllerTeams(int s, int l)
        {
            season = s;
            league = l;
        }

        public async void CreateList()
        {
            foreach (var item in myDeserializedClass.Response)
            {
                Game.Add(item);
            }
        }

        public async Task Start()
        {
            IsLoading = true;
            await GetBaseballApi();
            CreateList();
            IsLoading = false;
        }

        public string LinkQuery()
        {
            return $"/teams?league={league}&season={season}";
        }

        public async Task GetBaseballApi()
        {
            var response = await App.baseballClient.GetAsync(LinkQuery());
            var stringa = await response.Content.ReadAsStringAsync();
            myDeserializedClass = JsonSerializer.Deserialize<Team>(stringa);
            Thread.Sleep(1000);
        }
    }
}

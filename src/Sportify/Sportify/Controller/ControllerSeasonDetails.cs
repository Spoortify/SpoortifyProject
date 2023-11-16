using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Sportify.Model;
using Sportify.View;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Sportify.Controller
{
    public partial class ControllerSeasonDetails : ObservableObject
    {
        public static Leagues myDeserializedClass;
        public ObservableCollection<LeaguesResponse> Game { get; set; } = new ObservableCollection<LeaguesResponse>();
        public int season;

        public ControllerSeasonDetails(int s)
        {
            season = s;
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
            await GetBaseballApi();
            CreateList();
        }

        [RelayCommand]
        public async void TeamsDetails(LeaguesResponse r)
        {
            await App.Current.MainPage.Navigation.PushAsync(new ChooseModeStandings(season, r.Id));
        }

        public string LinkQuery()
        {
            return "/leagues?season=" + season;
        }

        public async Task GetBaseballApi()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://v1.baseball.api-sports.io");
            client.DefaultRequestHeaders.Add("x-rapidapi-key", "50033e93a2d49d985f3daa64adae1a80");
            client.DefaultRequestHeaders.Add("x-rapidapi-host", "v3.football.api-sports.io");
            var response = await client.GetAsync(LinkQuery());
            var stringa = await response.Content.ReadAsStringAsync();
            myDeserializedClass = JsonSerializer.Deserialize<Leagues>(stringa);
        }
    }
}

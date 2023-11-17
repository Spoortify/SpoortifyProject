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
        public static BaseballLeagues myDeserializedClass;
        public ObservableCollection<BaseballLeaguesResponse> Game { get; set; } = new();
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
        public async void TeamsDetails(BaseballLeaguesResponse r)
        {
            await App.Current.MainPage.Navigation.PushAsync(new ChooseModeStandings(season, r.Id));
        }

        public string LinkQuery()
        {
            return "/leagues?season=" + season;
        }

        public async Task GetBaseballApi()
        {
            var response = await App.baseballClient.GetAsync(LinkQuery());
            var stringa = await response.Content.ReadAsStringAsync();
            myDeserializedClass = JsonSerializer.Deserialize<BaseballLeagues>(stringa);
        }
    }
}

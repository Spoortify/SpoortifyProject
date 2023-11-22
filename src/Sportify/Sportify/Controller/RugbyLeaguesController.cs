using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Sportify.Model;
using Sportify.Services;
using Sportify.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Sportify.Controller
{
    public partial class RugbyLeaguesController : ObservableObject
    {
        [ObservableProperty]
        List<string> seasons = new() { "2008", "2009", "2010", "2011", "2012", "2013", "2014", 
            "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023" };

        [ObservableProperty]
        private string _selectedSeason = DateTime.Now.Year.ToString();

        [ObservableProperty]
        public bool isBusy = false;

        [ObservableProperty]
        public List<RugbyLeagueResponse> rugbyLeagues;

        public string SelectedSeasonLeagues
        {
            get => _selectedSeason;
            set
            {
                if (SetProperty(ref _selectedSeason, value))
                {
                    _ = GetLeagues();
                }
            }
        }

        public RugbyLeaguesController(RugbyLeague rugbyLeague)
        {
            rugbyLeagues = new(rugbyLeague.Response);
        }

        public async Task GetLeagues()
        {
            if (IsBusy) return;
            IsBusy = true;
            RugbyLeagues = new();
            var rugbyLeagues = await CacheRugbyService.GetAsync<RugbyLeague>($"/leagues/?season={_selectedSeason}", $"getRugbyLeagues-{_selectedSeason}");
            RugbyLeagues = rugbyLeagues.Response;
            IsBusy = false;

            //request without cache
            //var response = await App.rugbyClient.GetAsync($"/leagues/?season={_selectedSeason}");
            //if (!response.IsSuccessStatusCode)
            //    return;
            //var content = await response.Content.ReadAsStreamAsync();
            //var rugbyLeague = await JsonSerializer.DeserializeAsync<RugbyLeague>(content);
        }

        [RelayCommand]
        private async Task GoToRugbyLeagueStandings(RugbyLeagueResponse rugbyLeague)
        {
            if (rugbyLeague == null) return;
            if (IsBusy) return;
            IsBusy = true;
            var rugbyLeagueStandings = await CacheRugbyService.GetAsync<RugbyLeagueStandingsModel>($"/standings/?league={rugbyLeague.Id}&season={_selectedSeason}", 
                $"getRugbyLeague-{rugbyLeague.Id}-Standings-{_selectedSeason}", 1);
           
            try
            {
                IsBusy = false;
                await App.Current.MainPage.Navigation.PushAsync(new RugbyLeagueStandings(rugbyLeagueStandings));
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Error", ex.Source + ": " + ex.Message, "OK");
            }

            //request without cache
            //var response = await App.rugbyClient.GetAsync($"/standings/?league={rugbyLeague.Id}&season={_selectedSeason}");
            //if (!response.IsSuccessStatusCode)
            //    return;
            //var content = await response.Content.ReadAsStreamAsync();
            //rugbyLeagueStandings = await JsonSerializer.DeserializeAsync<RugbyLeagueStandingsModel>(content);
        }
    }
}

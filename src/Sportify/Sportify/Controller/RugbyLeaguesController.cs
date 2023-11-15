using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Sportify.Model;
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
        private static string _selectedSeason = DateTime.Now.Year.ToString();

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

        [ObservableProperty]
        private static bool isBusy = false;

        [ObservableProperty]
        public static ObservableCollection<RugbyLeagueResponse> rugbyLeagues;

        public RugbyLeaguesController(RugbyLeague rugbyLeague)
        {
            rugbyLeagues = new(rugbyLeague.Response);
        }

        public static async Task GetLeagues()
        {
            if (isBusy) return;
            isBusy = true;
            rugbyLeagues.Clear();
            var response = await App.rugbyClient.GetAsync($"/leagues/?season={_selectedSeason}");
            if (!response.IsSuccessStatusCode)
                return;

            var content = await response.Content.ReadAsStreamAsync();
            var rugbyLeague = await JsonSerializer.DeserializeAsync<RugbyLeague>(content);
            await Task.Run(() =>
            {
                Parallel.ForEach(rugbyLeague.Response, async league =>
                {
                    await MainThread.InvokeOnMainThreadAsync(() =>
                    {
                        rugbyLeagues.Add(league);
                    });
                });
            });
            isBusy = false;
        }

        [RelayCommand]
        private async Task GoToRugbyLeagueStandings(RugbyLeagueResponse rugbyLeague)
        {
            if (rugbyLeague == null)
                return;
            if (isBusy) return;
            isBusy = true;
            var response = await App.rugbyClient.GetAsync($"/standings/?league={rugbyLeague.Id}&season={_selectedSeason}");
            if (!response.IsSuccessStatusCode)
                return;
            var content = await response.Content.ReadAsStreamAsync();
            var rugbyLeagueStandings = await JsonSerializer.DeserializeAsync<RugbyLeagueStandingsModel>(content);
            isBusy = false;
            await App.Current.MainPage.Navigation.PushAsync(new RugbyLeagueStandings(rugbyLeagueStandings));
        }
    }
}

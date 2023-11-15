using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Sportify.Model;
using Sportify.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Sportify.Controller
{
    public partial class RugbyLeaguesController : ObservableObject
    {
        private static DateTime _selectedDate = DateTime.Now;
        public DateTime SelectedDate
        {
            get => _selectedDate;
            set => SetProperty(ref _selectedDate, value);
        }

        [ObservableProperty]
        private static bool isBusy = false;

        [ObservableProperty]
        public static List<RugbyLeagueResponse> rugbyLeagues = new();

        public RugbyLeaguesController(RugbyLeague rugbyLeague)
        {
            rugbyLeagues = rugbyLeague.Response;
        }

        public static async Task GetLeagues()
        {
            if (isBusy) return;
            isBusy = true;
            rugbyLeagues.Clear();
            var response = await App.rugbyClient.GetAsync($"/leagues/?season={_selectedDate.Year}");
            if (!response.IsSuccessStatusCode)
                return;

            var content = await response.Content.ReadAsStreamAsync();
            var rugbyLeague = await JsonSerializer.DeserializeAsync<RugbyLeague>(content);
            rugbyLeagues = rugbyLeague.Response;
            isBusy = false;
        }

        [RelayCommand]
        private async Task GoToRugbyLeagueStandings(RugbyLeagueResponse rugbyLeague)
        {
            if (rugbyLeague == null)
                return;
            if (isBusy) return;
            isBusy = true;
            var response = await App.rugbyClient.GetAsync($"/standings/?league={rugbyLeague.Id}&season={SelectedDate.Year}");
            if (!response.IsSuccessStatusCode)
                return;
            var content = await response.Content.ReadAsStreamAsync();
            var rugbyLeagueStandings = await JsonSerializer.DeserializeAsync<RugbyLeagueStandingsModel>(content);
            isBusy = false;
            await App.Current.MainPage.Navigation.PushAsync(new RugbyLeagueStandings(rugbyLeagueStandings));
        }
    }
}

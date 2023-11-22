using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls;
using Sportify.Model;
using Sportify.View;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using Sportify.Services;

namespace Sportify.Controller
{
    public partial class HomeRugbyController : ObservableObject
    {
        [ObservableProperty]
        public bool isBusy = false;

        [ObservableProperty]
        public List<RugbyGameResponse> rugbyGame;

        private static DateTime _selectedDate;
        public DateTime SelectedDate
        {
            get => _selectedDate;
            set => SetProperty(ref _selectedDate, value);
        }

        public HomeRugbyController()
        {
            RugbyGame = new();
            _selectedDate = DateTime.Now;
            new Action(async () =>
            {
                await ShowGames();
            })();
        }

        public async Task ShowGames()
        {
            if (IsBusy) return;
            IsBusy = true;
            try
            {
                RugbyGame = new();
                string formattedDate = _selectedDate.ToString("yyyy-MM-dd");
                var rugbyGames = await CacheRugbyService.GetAsync<RugbyGame>($"/games/?date={formattedDate}", $"getRugbyGames-{formattedDate}");
                RugbyGame = rugbyGames.Responses;

                //request without cache
                //var response = await App.rugbyClient.GetAsync($"/games/?date={formattedDate}");
                //if (!response.IsSuccessStatusCode) return;
                //var content = await response.Content.ReadAsStreamAsync();
                //var games = await JsonSerializer.DeserializeAsync<RugbyGame>(content);
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Error", ex.Source + ": " + ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }

        [RelayCommand]
        private static async Task GoToRugbyGameDetails(RugbyGameResponse rugbyGame)
        {
            if (rugbyGame == null) return;
            await App.Current.MainPage.Navigation.PushAsync(new RugbyGameDetails(rugbyGame));
        }

        [RelayCommand]
        private async Task GoToLeagues()
        {
            if (IsBusy) return;
            IsBusy = true;
            var rugbyLeagues = await CacheRugbyService.GetAsync<RugbyLeague>($"/leagues/?season={SelectedDate.Year}", $"getRugbyLeagues-{SelectedDate.Year}");
            IsBusy = false;
            await App.Current.MainPage.Navigation.PushAsync(new RugbyLeaguesView(rugbyLeagues));

            //request without cache
            //var response = await App.rugbyClient.GetAsync($"/leagues/?season={SelectedDate.Year}");
            //if (!response.IsSuccessStatusCode)
            //    return;
            //var content = await response.Content.ReadAsStreamAsync();
            //rugbyLeague = await JsonSerializer.DeserializeAsync<RugbyLeague>(content);
        }

        [RelayCommand]
        private async Task GoToHome()
        {
            await App.Current.MainPage.Navigation.PopToRootAsync();
        }
    }
}

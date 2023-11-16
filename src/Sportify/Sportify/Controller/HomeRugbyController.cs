using CommunityToolkit.Mvvm.ComponentModel;
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
        [ObservableProperty]
        private static bool isBusy = false;

        [ObservableProperty]
        public static ObservableCollection<RugbyGameResponse> rugbyGame = new();

        private static RugbyLeague rugbyLeague = new();
        private static DateTime _selectedDate = DateTime.Now;
        public DateTime SelectedDate
        {
            get => _selectedDate;
            set => SetProperty(ref _selectedDate, value);
        }

        public static async Task ShowGames()
        {
            if (isBusy) return;
            isBusy = true;
            try
            {
                rugbyGame.Clear();
                string formattedDate = _selectedDate.ToString("yyyy-MM-dd");
                var response = await App.rugbyClient.GetAsync($"/games/?date={formattedDate}");

                if (!response.IsSuccessStatusCode) return;

                var content = await response.Content.ReadAsStreamAsync();
                var games = await JsonSerializer.DeserializeAsync<RugbyGame>(content);

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
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Error", ex.Source + ": " + ex.Message, "OK");
            }
            finally
            {
                isBusy = false;
            }
        }

        [RelayCommand]
        private static async Task GoToRugbyGameDetails(RugbyGameResponse rugbyGame)
        {
            if (rugbyGame == null)
                return;
            await App.Current.MainPage.Navigation.PushAsync(new RugbyGameDetails(rugbyGame));
        }

        [RelayCommand]
        private async Task GoToLeagues()
        {
            if (isBusy) return;
            isBusy = true;
            var response = await App.rugbyClient.GetAsync($"/leagues/?season={SelectedDate.Year}");
            if (!response.IsSuccessStatusCode)
                return;

            var content = await response.Content.ReadAsStreamAsync();
            rugbyLeague = await JsonSerializer.DeserializeAsync<RugbyLeague>(content);
            isBusy = false;
            await App.Current.MainPage.Navigation.PushAsync(new RugbyLeagues(rugbyLeague));
        }

        [RelayCommand]
        private async Task GoToHome()
        {
            await App.Current.MainPage.Navigation.PopToRootAsync();
        }
    }
}

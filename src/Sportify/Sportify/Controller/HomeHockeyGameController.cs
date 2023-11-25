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
    public partial class HomeHockeyGameController : ObservableObject
    {
        [ObservableProperty]
        private static bool isBusy = false;

        [ObservableProperty]
        public static ObservableCollection<HockeyGameResponse> hockeyGame = new();

        private static HockeyGameLeague hockeyLeague = new();
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
                hockeyGame.Clear();
                string formattedDate = _selectedDate.ToString("yyyy-MM-dd");
                var response = await App.hockeyClient.GetAsync($"/games/?date={formattedDate}");

                if (!response.IsSuccessStatusCode) return;

                var content = await response.Content.ReadAsStreamAsync();
                var games = await JsonSerializer.DeserializeAsync<HockeyGame>(content);

                await Task.Run(() =>
                {
                    Parallel.ForEach(games.Response, async game =>
                    {
                        await MainThread.InvokeOnMainThreadAsync(() =>
                        {
                            hockeyGame.Add(game);
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
        public async Task GoToHockeyDetailsGame(HockeyGameResponse hockeyGame)
        {
            if (hockeyGame == null)
                return;
            await App.Current.MainPage.Navigation.PushAsync(new HockeyDetailsGame(hockeyGame));
        }
    }
}
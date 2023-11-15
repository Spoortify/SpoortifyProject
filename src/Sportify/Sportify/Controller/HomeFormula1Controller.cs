using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Sportify.Model;
using Sportify.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Sportify.Controller
{
    public partial class HomeFormula1Controller : ObservableObject
    {
        [RelayCommand]
        public async Task Standings()
        {
            await Shell.Current.GoToAsync(nameof(Standings), true);
        }

        [RelayCommand]
        public async Task TrackList()
        {
            var response = await App.ClientF1.GetAsync("/circuits");
            var trackList = await response.Content.ReadFromJsonAsync<Tracks>();
            await Shell.Current.GoToAsync(nameof(TrackList), true, new Dictionary<string, object>
            {
                {"TrackList", trackList}
            });
        }

        [RelayCommand]
        public async Task Constructor()
        {
            await Shell.Current.GoToAsync(nameof(ConstructorStandings), true);
        }

        [RelayCommand]
        public async Task TeamList()
        {
            var response = await App.ClientF1.GetAsync("/teams");
            var teamList = await response.Content.ReadFromJsonAsync<Teams>();
            await Shell.Current.GoToAsync(nameof(TeamList), true, new Dictionary<string, object>
            {
                {"TeamList", teamList }
            });
        }

        [RelayCommand]
        public async Task CurrentSeason()
        {
            await Shell.Current.GoToAsync(nameof(CurrentSeason), true);
        }

        [RelayCommand]
        public async Task RaceDetails()
        {
            await Shell.Current.GoToAsync(nameof(RaceDetails), true);
        }
    }
}

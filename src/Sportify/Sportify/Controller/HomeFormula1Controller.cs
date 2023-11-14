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
    }
}

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
    public partial class RaceResultsController : ObservableObject
    {
        RaceResult r;
        [ObservableProperty]
        List<string> seasons = new List<string> { "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023" };
        [ObservableProperty]
        string season;
        [ObservableProperty]
        List<RaceResponse> races;

        [RelayCommand]
        public async Task GetRaces()
        {
            var response = await App.ClientF1.GetAsync($"/races?season={Season}");
            r = await response.Content.ReadFromJsonAsync<RaceResult>();
            Races = r.Response.Where(r => r.Type == "Race").ToList();
        }
    }
}

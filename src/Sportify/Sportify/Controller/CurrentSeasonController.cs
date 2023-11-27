using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Graphics;
using Sportify.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Sportify.Controller
{
    public partial class CurrentSeasonController : ObservableObject
    {
        [ObservableProperty]
        bool driverVisible = false;
        [ObservableProperty]
        bool constructorVisible = false;
        [ObservableProperty]
        bool resultsVisible = false;
        [ObservableProperty]
        Formula1 formula1;
        [ObservableProperty]
        Constructors constructor;
        [ObservableProperty]
        Result raceResult;
        [ObservableProperty]
        List<ResultsResponse> results;
        [ObservableProperty]
        Color driverColor = Colors.Red;
        [ObservableProperty]
        Color constructorsColor = Colors.Red;
        [ObservableProperty]
        Color raceColor = Colors.Red;

        [RelayCommand]
        public async Task DriverStandings()
        {
            DriverVisible= true;
            ConstructorVisible = false;
            ResultsVisible = false;
            DriverColor = Colors.Black;
            ConstructorsColor = Colors.Red;
            RaceColor = Colors.Red;
            var response = await App.ClientF1.GetAsync("/rankings/drivers?season=2023");
            Formula1 = await response.Content.ReadFromJsonAsync<Formula1>();
        }
        [RelayCommand]
        public async Task ConstructorStandings()
        {
            DriverColor = Colors.Red;
            ConstructorsColor = Colors.Black;
            RaceColor = Colors.Red;
            DriverVisible = false;
            ConstructorVisible = true;
            ResultsVisible = false;
            var response = await App.ClientF1.GetAsync($"/rankings/teams?season={DateTime.Now.Year}");
            Constructor = await response.Content.ReadFromJsonAsync<Constructors>();
        }
        [RelayCommand]
        public async Task RaceResults()
        {
            DriverColor = Colors.Red;
            ConstructorsColor = Colors.Red;
            RaceColor = Colors.Black;
            DriverVisible = false;
            ConstructorVisible = false;
            ResultsVisible = true;
            var response = await App.ClientF1.GetAsync($"/races?season={DateTime.Now.Year}");
            RaceResult = await response.Content.ReadFromJsonAsync<Result>();
            Results = RaceResult.Response.Where(r => r.Type == "Race").ToList();
        }
        [RelayCommand]
        public async Task RaceDetails(ResultsResponse detail)
        {
            Details race = new Details();
            var response = await App.ClientF1.GetAsync($"/rankings/races?race={detail.Id}");
            race = await response.Content.ReadFromJsonAsync<Details>();
            await Shell.Current.GoToAsync(nameof(View.RaceDetails), true, new Dictionary<string, object>
            {
                {"Race",  race}
            });
        }
    }

}

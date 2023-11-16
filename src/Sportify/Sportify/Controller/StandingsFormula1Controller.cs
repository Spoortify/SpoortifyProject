using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Sportify.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Sportify.Controller
{
    public partial class StandingsFormula1Controller : ObservableObject
    {
        [ObservableProperty]
        List<string> seasons = new List<string> { "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022" };
        [ObservableProperty]
        string season;
        [ObservableProperty]
        Formula1 formula1;
        [ObservableProperty]
        bool richiesta = false;

        [RelayCommand]
        public async Task GetStandings()
        {
            Richiesta = true;
            var response = await App.ClientF1.GetAsync($"/rankings/drivers?season={Season}");
            Formula1 = await response.Content.ReadFromJsonAsync<Formula1>();
            Richiesta = false;
        }
    }
}

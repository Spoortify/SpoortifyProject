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
    public partial class FootballTeamListController : ObservableObject
    {
        //await App.Current.MainPage.Navigation.PushAsync(new Pagina(parametri));
        [ObservableProperty]
        string season = "2023";
        [ObservableProperty]
        string league = "PREMIER LEAGUE";
        [ObservableProperty]
        List<string> leagues = new List<string> { "PREMIER LEAGUE", "LALIGA", "SERIE A", "BUNDESLIGA", "LIGUE 1", "EREDIVISIE"};
        [ObservableProperty]
        FootballList teams;
        public FootballTeamListController()
        {
            new Action(async () =>
            {
                await Init();
            })();
        }

        async Task Init()
        {
            string id = App.GetFootballLeagueId(League);
            var response = await App.FootballClient.GetAsync($"/teams?season={Season}&league={id}");
            Teams = await response.Content.ReadFromJsonAsync<FootballList>();
        }

        [RelayCommand]
        public async Task ShowTeams()
        {
            string id = App.GetFootballLeagueId(League);
            var response = await App.FootballClient.GetAsync($"/teams?season={Season}&league={id}");
            Teams = await response.Content.ReadFromJsonAsync<FootballList>();
        }
    }
}

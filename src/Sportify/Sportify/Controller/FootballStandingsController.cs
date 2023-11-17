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
    public partial class FootballStandingsController : ObservableObject
    {
        [ObservableProperty]
        List<string> leagues = new List<string> { "PREMIER LEAGUE", "LALIGA", "SERIE A", "BUNDESLIGA", "LIGUE 1", "EREDIVISIE",
        "SUPER LIG", "LIGA PORTUGAL", "CHAMPIONS LEAGUE", "EUROPA LEAGUE", "CONFERENCE LEAGUE", "EURO2024 QUALIFICATION"};

        [ObservableProperty]
        string league;
        [ObservableProperty]
        Football football = new();
        [RelayCommand]
        public async Task ShowLeagues()
        {
            string id = App.GetFootballLeagueId(League);
            var response = await App.FootballClient.GetAsync($"/standings?league={id}&season=2023");
            Football = await response.Content.ReadFromJsonAsync<Football>();
        }
    }
}

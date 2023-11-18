using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Sportify.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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

        public ObservableCollection<string> Groups { get; set; } = new();
        string previousGroup = null;

        [RelayCommand]
        public async Task ShowLeagues()
        {
            string id = App.GetFootballLeagueId(League);
            var response = await App.FootballClient.GetAsync($"/standings?league={id}&season={DateTime.Now.Year}");
            Football = await response.Content.ReadFromJsonAsync<Football>();

            foreach (var standings in Football.Response[0].League.Standings)
            {
                foreach (var standing in standings)
                {
                    if (standing.Group != previousGroup)
                    {
                        Groups.Add(standing.Group);
                    }
                    previousGroup = standing.Group;
                }
            }
        }
    }
}

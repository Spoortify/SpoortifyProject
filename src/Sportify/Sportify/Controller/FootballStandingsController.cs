using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Sportify.Model;
using Sportify.View;
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
        List<string> seasons = new() { "2008", "2009", "2010", "2011", "2012", "2013", "2014",
            "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026" };

        [ObservableProperty]
        List<string> leagues = new List<string> { "PREMIER LEAGUE", "LALIGA", "SERIE A", "BUNDESLIGA", "LIGUE 1", "EREDIVISIE",
        "SUPER LIG", "LIGA PORTUGAL", "CHAMPIONS LEAGUE", "EUROPA LEAGUE", "CONFERENCE LEAGUE", "EURO2024 QUALIFICATION"};

        [ObservableProperty]
        private static string _selectedLeague = "SERIE A";

        public string SelectedLeagueFootball
        {
            get => _selectedLeague;
            set
            {
                if (SetProperty(ref _selectedLeague, value))
                {
                    _ = ShowLeagues();
                }
            }
        }

        [ObservableProperty]
        Football football = new();

        public ObservableCollection<string> Groups { get; set; } = new();
        private string previousGroup = null;

        [ObservableProperty]
        private static string _selectedSeason = DateTime.Now.Year.ToString();

        public string SelectedSeasonFootball
        {
            get => _selectedSeason;
            set
            {
                if (SetProperty(ref _selectedSeason, value))
                {
                    _ = ShowLeagues();
                }
            }
        }

        public FootballStandingsController()
        {
            ShowLeagues();
        }

        [RelayCommand]
        public async Task ShowLeagues()
        {
            Groups.Clear();
            Football = new();
            previousGroup = null;

            string id = GetFootballLeagueId(_selectedLeague);
            var response = await App.FootballClient.GetAsync($"/standings?league={id}&season={_selectedSeason}");
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

        [RelayCommand]
        public async Task GoToSeasonTeamDetails(FootballStandingsModel team)
        {
            if (team is null) return;
            await App.Current.MainPage.Navigation.PushAsync(new SeasonTeamDetails(team));
        }

        public static string GetFootballLeagueId(string league)
        {
            int id = league switch
            {
                "SERIE A" => 135,
                "PREMIER LEAGUE" => 39,
                "LALIGA" => 140,
                "BUNDESLIGA" => 78,
                "LIGUE 1" => 61,
                "EREDIVISIE" => 88,
                "SUPER LIG" => 203,
                "LIGA PORTUGAL" => 94,
                "CHAMPIONS LEAGUE" => 2,
                "EUROPA LEAGUE" => 3,
                "CONFERENCE LEAGUE" => 848,
                "EURO2024 QUALIFICATION" => 960,
                _ => 135
            };
            return id.ToString();
        }
    }
}

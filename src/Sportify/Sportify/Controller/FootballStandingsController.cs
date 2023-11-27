using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Graphics;
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
    [QueryProperty(nameof(Id), "Id")]
    [QueryProperty(nameof(League), "League")]
    public partial class FootballStandingsController : ObservableObject
    {
        [ObservableProperty]
        Color standingColor = Colors.Blue;
        [ObservableProperty]
        Color scorerColor = Colors.Blue;
        [ObservableProperty]
        Color fixtureColor = Colors.Blue;

        [ObservableProperty]
        LeagueModel league;
        [ObservableProperty]
        bool rankingsVisible = false;
        [ObservableProperty]
        bool topScorerVisible = false;
        [ObservableProperty]
        bool fixturesVisible = false;

        [ObservableProperty]
        List<string> seasons = new() { "2008", "2009", "2010", "2011", "2012", "2013", "2014",
            "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026" };

        [ObservableProperty]
        string id;


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

        [RelayCommand]
        public async Task ShowLeagues()
        {
            try
            {
                StandingColor = Colors.Black;
                ScorerColor = Colors.Blue;
                FixtureColor = Colors.Blue;
                RankingsVisible = true;
                TopScorerVisible = false;
                FixturesVisible = false;
                Groups.Clear();
                Football = new();
                previousGroup = null;

                var response = await App.FootballClient.GetAsync($"/standings?league={Id}&season={_selectedSeason}");
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
            }catch(Exception ex)
            {
                await Shell.Current.DisplayAlert("ERROR", ex.Message, "CLOSE");
            }
        }

        [ObservableProperty]
        FootballTopScorers topScorers;
        [RelayCommand]
        async Task ShowTopScorers()
        {
            try
            {
                StandingColor = Colors.Blue;
                ScorerColor = Colors.Black;
                FixtureColor = Colors.Blue;
                RankingsVisible = false;
                TopScorerVisible = true;
                FixturesVisible = false;
                var response = await App.FootballClient.GetAsync($"/players/topscorers?league={Id}&season={_selectedSeason}");
                TopScorers = await response.Content.ReadFromJsonAsync<FootballTopScorers>();
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("ERROR", ex.Message, "CLOSE");
            }
            
        }
        [ObservableProperty]
        GameDay gameDay;
        [RelayCommand]
        async Task ShowFixtures()
        {
            try
            {
                StandingColor = Colors.Blue;
                ScorerColor = Colors.Blue;
                FixtureColor = Colors.Black;
                RankingsVisible = false;
                TopScorerVisible = false;
                FixturesVisible = true;
                var response = await App.FootballClient.GetAsync($"/fixtures?league={Id}&season={_selectedSeason}");
                GameDay = await response.Content.ReadFromJsonAsync<GameDay>();
            }catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("ERROR", ex.Message, "CLOSE");
            }
        }
    }
}

﻿using CommunityToolkit.Mvvm.ComponentModel;
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
        [ObservableProperty]
        bool running = false;

        [RelayCommand]
        public async Task Standings()
        {
            Running = true;
            await Shell.Current.GoToAsync(nameof(View.Standings), true);
            Running = false;
        }

        [RelayCommand]
        public async Task TrackList()
        {
            Running = true;
            var response = await App.ClientF1.GetAsync("/circuits");
            var trackList = await response.Content.ReadFromJsonAsync<Tracks>();
            await Shell.Current.GoToAsync(nameof(View.TrackList), true, new Dictionary<string, object>
            {
                {"TrackList", trackList}
            });
            Running = false;
        }

        [RelayCommand]
        public async Task Constructor()
        {
            Running = true;
            await Shell.Current.GoToAsync(nameof(ConstructorStandings), true);
            Running = false;
        }

        [RelayCommand]
        public async Task TeamList()
        {
            Running = true;
            var response = await App.ClientF1.GetAsync("/teams");
            var teamList = await response.Content.ReadFromJsonAsync<Formula1Teams>();
            await Shell.Current.GoToAsync(nameof(View.TeamList), true, new Dictionary<string, object>
            {
                {"TeamList", teamList }
            });
            Running = false;
        }

        [RelayCommand]
        public async Task CurrentSeason()
        {
            Running = true;
            await Shell.Current.GoToAsync(nameof(View.CurrentSeason), true);
            Running = false;
        }

        [RelayCommand]
        public async Task RaceResults()
        {
            Running = true;
            await Shell.Current.GoToAsync(nameof(View.RaceResults), true);
            Running = false;
        }
    }
}

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
    public partial class NbaTeamsStatisticsController : ObservableObject
    {
        [ObservableProperty]
        List<NBAResponse> teamSeasonStandings = new();

        [ObservableProperty]
        string bgiImage;

        NbaTeamsStatisticsModel teamSeasonStatistics;

        int season;
        int teamId;

        [ObservableProperty]
        List<NBATeamsResponse> teamSeasonStatisticsResponse;


        public NbaTeamsStatisticsController(NBAResponse response)
        {
            this.teamSeasonStandings.Add(response);
            season = teamSeasonStandings[0].Season;
            teamId = teamSeasonStandings[0].Team.Id;
            BgiImage = BindingBgi(teamId);
            new Action(async () =>
            {
                await RiempiListaTeams();
            })();
        }

        [RelayCommand]
        async Task RiempiListaTeams()
        {
            var response = await App.nbaClient.GetAsync($"/teams/statistics?id={teamId}&season={season}");
            teamSeasonStatistics = await response.Content.ReadFromJsonAsync<NbaTeamsStatisticsModel>();
            TeamSeasonStatisticsResponse = teamSeasonStatistics.Response;
        }

        [RelayCommand]
        public async Task GoToRoaster(List<NBAResponse> response)
        {
            if (response is null)
            {
                return;
            }
            await App.Current.MainPage.Navigation.PushAsync(new NbaSeasonRoasterView(response));
        }

        public static string BindingBgi(int teamIdBgi)
        {
            string bgiName;
            bgiName = teamIdBgi switch
            {
                1 => "atlbgi.jpg",
                2 => "bosbgi.png",
                4 => "brobgi.png",
                5 => "chabgi.png",
                6 => "chibgi.jpg",
                7 => "clebgi.jpg",
                8 => "dalbgi.jpg",
                9 => "denbgi.png",
                10 => "detbgi.jpg",
                11 => "golbgi.jpg",
                14 => "houbgi.png",
                15 => "indbgi.jpg",
                16 => "lacbgi.jpg",
                17 => "lalbgi.jpg",
                19 => "membgi.jpg",
                20 => "miabgi.jpg",
                21 => "milbgi.png",
                22 => "minbgi.jpg",
                23 => "norbgi.jpg",
                24 => "newbgi.jpg",
                25 => "okcbgi.png",
                26 => "orlbgi.jpg",
                27 => "phibgi.jpg",
                28 => "phobgi.jgp",
                29 => "porbgi.jpg",
                30 => "sacbgi.png",
                31 => "sanbgi.jpg",
                38 => "torbgi.png",
                40 => "utabgi.png",
                41 => "wasbgi.png",
                _ => "nbabgidue.jpg"
            };

            return bgiName;
        }
    }
}

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
    public partial class NbaSeasonRoasterController : ObservableObject
    {
        [ObservableProperty]
        List<NBAResponse> seasonStandings = new();

        [ObservableProperty]
        List<NBARoasterResponse> guardsList = new();

        [ObservableProperty]
        List<NBARoasterResponse> forwardsList = new();

        [ObservableProperty]
        List<NBARoasterResponse> centersLists = new();

        NbaSeasonRoasterModel model;

        int season;
        int teamId;

        [ObservableProperty]
        string bgiImage;

        [ObservableProperty]
        List<NBARoasterResponse> seasonRoasterList = new();

        public NbaSeasonRoasterController(List<NBAResponse> response)
        {
            this.seasonStandings = response;
            season = SeasonStandings[0].Season;
            teamId = SeasonStandings[0].Team.Id;
            new Action(async () =>
            {
                await RiempiListaRoaster();
            })();
        }


        [RelayCommand]
        async Task RiempiListaRoaster()
        {
            var response = await App.nbaClient.GetAsync($"/players?season={season}&team={teamId}");
            model = await response.Content.ReadFromJsonAsync<NbaSeasonRoasterModel>();
            SeasonRoasterList = model.Response;
            BgiImage = BindingBgi(teamId);
            RiempiListePositions();
        }

        public void RiempiListePositions()
        {
            GuardsList = RiempiListaGuards(SeasonRoasterList);
            ForwardsList = RiempiListaForwards(SeasonRoasterList);
            CentersLists = RiempiListaCenters(SeasonRoasterList);
        }

        [RelayCommand]
        public async Task GoToPlayerStatistic(NBARoasterResponse response)
        {
            if (response is null)
            {
                return;
            }
            await App.Current.MainPage.Navigation.PushAsync(new NbaPlayerSeasonStatisticsView(response, season));
        }

        public static List<NBARoasterResponse> RiempiListaGuards(List<NBARoasterResponse> list)
        {
            List<NBARoasterResponse> guards = new();
            guards = list.Where(g => g.Leagues.Standard.Pos.Equals("G") || g.Leagues.Standard.Pos.Equals("G-F")).ToList();
            return guards;
        }

        public static List<NBARoasterResponse> RiempiListaForwards(List<NBARoasterResponse> list)
        {
            List<NBARoasterResponse> forwards = new();
            forwards = list.Where(f => f.Leagues.Standard.Pos.Equals("F") || f.Leagues.Standard.Pos.Equals("F-G") || f.Leagues.Standard.Pos.Equals("F-C")).ToList();
            return forwards;
        }

        public static List<NBARoasterResponse> RiempiListaCenters(List<NBARoasterResponse> list)
        {
            List<NBARoasterResponse> centers = new();
            centers = list.Where(c => c.Leagues.Standard.Pos.Equals("C") || c.Leagues.Standard.Pos.Equals("C-F") || c.Leagues.Standard.Pos.Equals("C-G")).ToList();
            return centers;
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

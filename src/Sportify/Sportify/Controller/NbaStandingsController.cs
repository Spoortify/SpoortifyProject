
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Sportify.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Sportify.Controller
{
    public partial class NbaStandingsController : ObservableObject
    {
        static HttpClient client;

        [ObservableProperty]
        bool leagueVisible = false;

        [ObservableProperty]
        bool conferenceVisible = false;

        [ObservableProperty]
        bool divisionVisible = false;

        [ObservableProperty]
        List<string> seasons = new List<string> { "2023-2024", "2022-2023", "2021-2022", "2020-2021", "2019-2020", "2018-2019" };

        [ObservableProperty]
        string seasonString;

        [ObservableProperty]
        int seasonInt;

        [ObservableProperty]
        NbaSeasonStandings seasonStatsList;

        [ObservableProperty]
        List<NBAResponse> leaguesStandingsList;
        public NbaStandingsController()
        {
            client = new HttpClient();
            new Action(async () =>
            {
                await RiempiLista();
            })();
        }

        [RelayCommand]
        async Task RiempiLista()
        {
            client.BaseAddress = new Uri("https://v2.nba.api-sports.io");
            client.DefaultRequestHeaders.Add("x-rapidapi-key", "4eb54507877398a66e1f0828f61ae689");
            client.DefaultRequestHeaders.Add("x-rapidapi-host", "api-nba-v1.p.rapidapi.com");
            var response = await client.GetAsync($"/standings?league=standard&season={SeasonInt}");
            SeasonStatsList = await response.Content.ReadFromJsonAsync<NbaSeasonStandings>();            
        }

        [RelayCommand]
        public async Task LeagueStandings()
        {
            LeagueVisible = true;
            ConferenceVisible = false;
            DivisionVisible = false;
            LeaguesStandingsList = RiordinaClassificaTotale(SeasonStatsList);
        }

        public static List<NBAResponse> RiordinaClassificaTotale(NbaSeasonStandings classifica)
        {
            List<NBAResponse> list = new List<NBAResponse>();
            list = classifica.Response.OrderByDescending(t => t.Win.Total).ToList();
            return list;
        }

        public static List<NBAResponse> RiordinaClassificaConference(NbaSeasonStandings classifica)
        {
            List<NBAResponse> list1 = new List<NBAResponse>();
            list1 = classifica.Response.OrderByDescending(t => t.Win.Total).ToList();
            return list1;
        }

        public static List<NBAResponse> RiordinaClassificaDivision(NbaSeasonStandings classifica)
        {
            List<NBAResponse> list = new List<NBAResponse>();
            list = classifica.Response.OrderByDescending(t => t.Win.Total).ToList();
            return list;
        }

        public static void ConvertSeason()
        {

        }
    }
}

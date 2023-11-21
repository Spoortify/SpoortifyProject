
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Sportify.Model;
using Sportify.View;
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

        #region Observableproperty

        [ObservableProperty]
        bool leagueVisible = false;

        [ObservableProperty]
        bool conferenceVisible = false;

        [ObservableProperty]
        bool divisionVisible = false;

        [ObservableProperty]
        List<string> seasons = new List<string> { "2023-2024", "2022-2023", "2021-2022", "2020-2021", "2019-2020", "2018-2019" };

        [ObservableProperty]
        string seasonString = "2023-2024";

        [ObservableProperty]
        int seasonInt = 2023;

        [ObservableProperty]
        NbaSeasonStandings seasonStatsList;

        [ObservableProperty]
        List<NBAResponse> leaguesStandingsList;

        [ObservableProperty]
        List<NBAResponse> easternConferenceStandingsList;

        [ObservableProperty]
        List<NBAResponse> westernConferenceStandingsList;

        [ObservableProperty]
        List<NBAResponse> atlanticDivStandingsList = new();

        [ObservableProperty]
        List<NBAResponse> centralDivStandingsList;

        [ObservableProperty]
        List<NBAResponse> southeastDivStandingsList;

        [ObservableProperty]
        List<NBAResponse> northwestDivStandingsList;

        [ObservableProperty]
        List<NBAResponse> pacificDivStandingsList;

        [ObservableProperty]
        List<NBAResponse> southwestDivStandingsList;

        #endregion

        private static bool isBusy = false;

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
            ConvertSeason();
            var response = await App.nbaClient.GetAsync($"/standings?league=standard&season={SeasonInt}");
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


        [RelayCommand]
        public async Task ConferenceStandings()
        {
            LeagueVisible = false;
            ConferenceVisible = true;
            DivisionVisible = false;
            RiordinaClassificaConference(SeasonStatsList);
        }
        public void RiordinaClassificaConference(NbaSeasonStandings classifica)
        {
            EasternConferenceStandingsList = classifica.Response.
                Where(e => e.Conference.Name.Equals("east")).OrderByDescending(t => t.Win.Total).ToList();
            WesternConferenceStandingsList = classifica.Response.
                Where(w => w.Conference.Name.Equals("west")).OrderByDescending(t => t.Win.Total).ToList();
        }


        [RelayCommand]
        public async Task DivisionStandings()
        {
            LeagueVisible = false;
            ConferenceVisible = false;
            DivisionVisible = true;
            RiordinaClassificaDivision(SeasonStatsList);
        }
        public void RiordinaClassificaDivision(NbaSeasonStandings classifica)
        {
            AtlanticDivStandingsList = classifica.Response.
                Where(a => a.Division.Name.Equals("atlantic")).OrderByDescending(t => t.Win.Total).ToList();
            CentralDivStandingsList = classifica.Response.
                Where(c => c.Division.Name.Equals("central")).OrderByDescending(t => t.Win.Total).ToList();
            SoutheastDivStandingsList = classifica.Response.
                Where(s => s.Division.Name.Equals("southeast")).OrderByDescending(t => t.Win.Total).ToList();
            NorthwestDivStandingsList = classifica.Response.
                Where(n => n.Division.Name.Equals("northwest")).OrderByDescending(t => t.Win.Total).ToList();
            PacificDivStandingsList = classifica.Response.
                Where(p => p.Division.Name.Equals("pacific")).OrderByDescending(t => t.Win.Total).ToList();
            SouthwestDivStandingsList = classifica.Response.
                Where(s => s.Division.Name.Equals("southwest")).OrderByDescending(t => t.Win.Total).ToList();
        }

        public string ConvertSeason()
        {
            //{ "2023-2024", "2022-2023", "2021-2022", "2020-2021", "2019-2020", "2018-2019" }

            SeasonInt = seasonString switch
            {
                "2023-2024" => 2023,
                "2022-2023" => 2022,
                "2021-2022" => 2021,
                "2020-2021" => 2020,
                "2019-2020" => 2019,
                "2018-2019" => 2018,
                _ => 2023
            };

            return SeasonInt.ToString();
        }

        [RelayCommand]
        public async Task GoToTeamsStatistics(NBAResponse response)
        {
            if (response is null)
            {
                return;
            }
            await App.Current.MainPage.Navigation.PushAsync(new NbaTeamsStatisticsView(response));
        }

        public string SelectedSeason
        {
            get => seasonString;
            set
            {
                if (SetProperty(ref seasonString, value))
                {
                    _ = RiempiLista();
                }
            }
        }
    }
}

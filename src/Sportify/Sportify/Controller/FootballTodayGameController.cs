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
    public partial class FootballTodayGameController : ObservableObject
    {
        [ObservableProperty]
        GameDay gameDay;
        [ObservableProperty]
        List<bool> lists = new List<bool>();
        [ObservableProperty]
        DateTime selectedDate;

        #region declaring list of leagues
        [ObservableProperty]
        List<GameDayResponse> premierLeague;
        [ObservableProperty]
        List<GameDayResponse> serieA;
        [ObservableProperty]
        List<GameDayResponse> ligue1;
        [ObservableProperty]
        List<GameDayResponse> laliga;
        [ObservableProperty]
        List<GameDayResponse> bundesliga;
        [ObservableProperty]
        List<GameDayResponse> eredivisie;
        [ObservableProperty]
        List<GameDayResponse> superLig;
        [ObservableProperty]
        List<GameDayResponse> liganos;
        [ObservableProperty]
        List<GameDayResponse> champions;
        [ObservableProperty]
        List<GameDayResponse> europa;
        [ObservableProperty]
        List<GameDayResponse> conference;
        [ObservableProperty]
        List<GameDayResponse> euroQuali;
        #endregion

        public FootballTodayGameController()
        {
            new Action(async () =>
            {
                SelectedDate = DateTime.Now;
                await Init();
            })();
        }

        [RelayCommand]
        async Task Init()
        {
            Lists.Clear();
            var response = await App.FootballClient.GetAsync($"/fixtures?date={SelectedDate.Year}-{SelectedDate.Month}-" +
                $"{SelectedDate.Day}&season={SelectedDate.Year}");
            GameDay = await response.Content.ReadFromJsonAsync<GameDay>();
            PremierLeague = GameDay.Response.Where(r => r.League.Name.Equals("Premier League") &&
            r.League.Country.Equals("England")).ToList();
            SerieA = GameDay.Response.Where(r => r.League.Name.Equals("Serie A") &&
            r.League.Country.Equals("Italy")).ToList();
            Bundesliga = GameDay.Response.Where(r => r.League.Name.Equals("Bundesliga") &&
            r.League.Country.Equals("Germany")).ToList();
            Laliga = GameDay.Response.Where(r => r.League.Name.Equals("La Liga") &&
            r.League.Country.Equals("Spain")).ToList();
            Ligue1 = GameDay.Response.Where(r => r.League.Name.Equals("Ligue 1") &&
            r.League.Country.Equals("France")).ToList();
            Eredivisie = GameDay.Response.Where(r => r.League.Name.Equals("Eredivisie") &&
            r.League.Country.Equals("Netherlands")).ToList();
            SuperLig = GameDay.Response.Where(r => r.League.Name.Equals("Süper Lig") &&
            r.League.Country.Equals("Turkey")).ToList();
            Liganos = GameDay.Response.Where(r => r.League.Name.Equals("Primeira Liga") &&
            r.League.Country.Equals("Portugal")).ToList();
            Champions = GameDay.Response.Where(r => r.League.Name.Equals("UEFA Champions League") &&
            r.League.Country.Equals("World")).ToList();
            Europa = GameDay.Response.Where(r => r.League.Name.Equals("UEFA Europa League") &&
            r.League.Country.Equals("World")).ToList();
            Conference = GameDay.Response.Where(r => r.League.Name.Equals("UEFA Conference League") &&
            r.League.Country.Equals("World")).ToList();
            EuroQuali = GameDay.Response.Where(r => r.League.Name.Equals("Euro Championship - Qualification") &&
            r.League.Country.Equals("World")).ToList();

            Lists.Add(PremierLeague.Count != 0);
            Lists.Add(SerieA.Count != 0);
            Lists.Add(Bundesliga.Count != 0);
            Lists.Add(Laliga.Count != 0);
            Lists.Add(Ligue1.Count != 0);
            Lists.Add(Eredivisie.Count != 0);
            Lists.Add(SuperLig.Count != 0);
            Lists.Add(Liganos.Count != 0);
            Lists.Add(Champions.Count != 0);
            Lists.Add(Europa.Count != 0);
            Lists.Add(Conference.Count != 0);
            Lists.Add(EuroQuali.Count != 0);
        }
    }
}

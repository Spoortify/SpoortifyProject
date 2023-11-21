using CommunityToolkit.Mvvm.ComponentModel;
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
    public partial class FootballTopScorersController : ObservableObject
    {
        [ObservableProperty]
        public List<FootballTopScorersResponse> topScores;

        private string _season;
        private int _leagueId;
        public FootballTopScorersController(string season, int leagueId)
        {
            this._season = season;
            this._leagueId = leagueId;
            TopScores = new();
            new Action(async () =>
            {
                await GetTopScorers();
            })();
        }

        private async Task GetTopScorers()
        {
            var response = await App.FootballClient.GetAsync($"/players/topscorers?league={_leagueId}&season={_season}");
            FootballTopScorers footballTopScorers = await response.Content.ReadFromJsonAsync<FootballTopScorers>();
            TopScores = footballTopScorers.Response;
        }

        [RelayCommand]
        private async Task GoToTopScorerDetailsCommand(FootballTopScorersResponse topScorer)
        {
            if (topScorer is null) return;
            await App.Current.MainPage.Navigation.PushAsync(new FootballTopScorerDetails(topScorer));
        }
    }
}

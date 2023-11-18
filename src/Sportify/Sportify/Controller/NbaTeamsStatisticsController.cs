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
    public partial class NbaTeamsStatisticsController : ObservableObject
    {
        [ObservableProperty]
        List<NBAResponse> teamSeasonStandings = new();

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
    }
}

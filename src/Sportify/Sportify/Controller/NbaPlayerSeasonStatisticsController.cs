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
    public partial class NbaPlayerSeasonStatisticsController : ObservableObject
    {
        [ObservableProperty]
        List<NBARoasterResponse> players = new();

        NbaPlayerStatisticsModel model;

        int seasonSearch;
        int playerId;

        [ObservableProperty]
        List<NbaPStatsResponse> playerStatsList = new();

        public NbaPlayerSeasonStatisticsController(NBARoasterResponse response, int season)
        {
            this.players.Add(response);
            seasonSearch = season;
            playerId = players[0].Id;
            new Action(async () =>
            {
                await RiempiListaPlayerStats();
            })();
        }

        [RelayCommand]
        async Task RiempiListaPlayerStats()
        {
            var response = await App.nbaClient.GetAsync($"/players/statistics?id={playerId}&season={seasonSearch}");
            model = await response.Content.ReadFromJsonAsync<NbaPlayerStatisticsModel>();
            PlayerStatsList = model.Response;
        }
    }
}

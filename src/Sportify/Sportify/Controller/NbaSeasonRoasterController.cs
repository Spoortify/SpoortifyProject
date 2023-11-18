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
    public partial class NbaSeasonRoasterController : ObservableObject
    {
        [ObservableProperty]
        List<NBAResponse> seasonStandings = new();

        NbaSeasonRoasterModel model;

        int season;
        int teamId;

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
        }

        [RelayCommand]
        public async Task GoToPlayerStatistic(List<NBAResponse> response)
        {
            if (response is null)
            {
                return;
            }
            await App.Current.MainPage.Navigation.PushAsync(new NbaPlayerSeasonStatisticsView(response));
        }
    }
}

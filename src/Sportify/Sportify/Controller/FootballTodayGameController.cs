using CommunityToolkit.Mvvm.ComponentModel;
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
        IGrouping<string,GameDayResponse> serieA;
        public FootballTodayGameController()
        {
            //TODO: da sistemare non funziona ancora del tutto
            //new Action(async () =>
            //{
            //    await Init();
            //})();
        }

        private async Task Init()
        {
            var response = await App.FootballClient.GetAsync("/fixtures?date=2023-11-17");
            GameDay = await response.Content.ReadFromJsonAsync<GameDay>();
            var gerieA = GameDay.Response.GroupBy(r => r.League.Name);
        }
    }
}

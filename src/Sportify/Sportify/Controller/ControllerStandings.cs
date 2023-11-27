using Sportify.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Sportify.Controller
{
    public partial class ControllerStandings
    {
        public static BaseballStandings myDeserializedClass;
        public ObservableCollection<BaseballStandingsResponse> Game { get; set; } = new ObservableCollection<BaseballStandingsResponse>();
        public int season;
        public int league;

        public ControllerStandings(int s, int l)
        {
            season = s;
            league = l;
        }

        public async void CreateList()
        {
            if (myDeserializedClass.Response == null || myDeserializedClass.Response.Count <= 0)
            {
                return;
            }

            foreach (var item in myDeserializedClass.Response)
            {
                Game.Add(item[0]);
            }
        }

        public async Task Start()
        {
            await GetBaseballApi();
            CreateList();
        }

        public string LinkQuery()
        {
            return $"/standings?league={league}&season={season}";
        }

        public async Task GetBaseballApi()
        {
            var response = await App.baseballClient.GetAsync(LinkQuery());
            var stringa = await response.Content.ReadAsStringAsync();
            myDeserializedClass = JsonSerializer.Deserialize<BaseballStandings>(stringa);
        }
    }
}

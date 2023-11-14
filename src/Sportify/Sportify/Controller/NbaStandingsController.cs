using CommunityToolkit.Mvvm.ComponentModel;
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
        ObservableCollection<NbaSeasonStandings> seasonStatsList;
        public NbaStandingsController()
        {
            seasonStatsList = new ObservableCollection<NbaSeasonStandings>();
            client = new HttpClient();
            RiempiLista();
        }

         async Task RiempiLista()
         {
            client.BaseAddress = new Uri("https://api-nba-v1.p.rapidapi.com%22/");
            client.DefaultRequestHeaders.Add("x-rapidapi-key", "f39a8500f04772c155c1c3b51384c1f3");
            client.DefaultRequestHeaders.Add("x-rapidapi-host", "api-nba-v1.p.rapidapi.com");
            var response = await client.GetAsync("/standings?league=standard&season=2018");
            {
                if (response.IsSuccessStatusCode)
                {
                    seasonStatsList.Clear();
                    NbaSeasonStandings stats = await response.Content.ReadFromJsonAsync<NbaSeasonStandings>();
                    seasonStatsList.Add(stats);
                }
            }
            
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using Sportify.Model;

namespace Sportify.Controller
{
    internal class BaseballController
    {
        public static BaseballGame myDeserializedClass;
        public ObservableCollection<Response> Game { get; set; } = new ObservableCollection<Response>();

        public BaseballController()
        {
            
        }

        public async void CreateList()
        {
            #region old
            //Game.Add(new Response
            //{
            //    Country = list.Country,
            //    Id = list.Id,
            //    Date = list.Date,
            //    League = list.League,
            //    Scores = list.Scores,
            //    Status = list.Status,
            //    Teams = list.Teams,
            //    Time = list.Time,
            //    Timestamp = list.Timestamp,
            //    Timezone = list.Timezone,
            //    Week = list.Week,
            //});
            #endregion
            await Task.Run(() =>
            {
                Parallel.ForEach(myDeserializedClass.Response, async game =>
                {
                    await MainThread.InvokeOnMainThreadAsync(() =>
                    {
                        Game.Add(game);
                    });
                });
            });
        }

        public async Task Start()
        {
            await GetBaseballApi();
            CreateList();
        }

        public static async Task GetBaseballApi()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://v1.baseball.api-sports.io");
            client.DefaultRequestHeaders.Add("x-rapidapi-key", "50033e93a2d49d985f3daa64adae1a80");
            client.DefaultRequestHeaders.Add("x-rapidapi-host", "v3.football.api-sports.io");
            var response = await client.GetAsync("/games?date=2023-11-14");
            var stringa = await response.Content.ReadAsStringAsync();
            //Console.WriteLine(stringa);
            myDeserializedClass = JsonSerializer.Deserialize<BaseballGame>(stringa);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Sportify.Model;
using Sportify.View;

namespace Sportify.Controller
{
    public partial class BaseballController
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

        [RelayCommand]
        public async void OpenDetails(Response response)
        {
            var nuovaPagina = new ViewTypes();
            var diz = new Dictionary<string, object> { { "Game", response } };
            await Shell.Current.GoToAsync("ViewTypes", true, diz);
        }

        public static async Task GetBaseballApi()
        {
            DateTime dataCorrente = DateTime.Now;
            string dataFormattata = dataCorrente.ToString("yyyy-MM-dd");
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://v1.baseball.api-sports.io");
            client.DefaultRequestHeaders.Add("x-rapidapi-key", "7169e21806353dcad1a1592a2b7043bd");
            client.DefaultRequestHeaders.Add("x-rapidapi-host", "v3.football.api-sports.io");
            var response = await client.GetAsync($"/games?date={dataFormattata}");
            var stringa = await response.Content.ReadAsStringAsync();
            //Console.WriteLine(stringa);
            myDeserializedClass = JsonSerializer.Deserialize<BaseballGame>(stringa);
        }
    }
}

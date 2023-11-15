using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using Sportify.Model;
using Sportify.View;
using System.Collections.ObjectModel;
using System.Text.Json;

namespace Sportify.Controller
{
    public partial class ControllerSeasons
    {
        public static BaseballGame myDeserializedClass;
        public ObservableCollection<Response> Game { get; set; } = new ObservableCollection<Response>();

        public ControllerSeasons()
        {

        }

        public async void CreateList()
        {
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

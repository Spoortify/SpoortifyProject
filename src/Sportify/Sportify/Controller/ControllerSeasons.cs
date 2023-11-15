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
//using static Android.Provider.DocumentsContract;

namespace Sportify.Controller
{
    public partial class ControllerSeasons
    {
        public static Seasons myDeserializedClass;
        public ObservableCollection<int> Game { get; set; } = new ObservableCollection<int>();

        public ControllerSeasons()
        {}

        public async void CreateList()
        {
            foreach (var item in myDeserializedClass.Response)
            {
                Game.Add(item);
            }
        }

        public async Task Start()
        {
            await GetBaseballApi();
            CreateList();
        }

        [RelayCommand]
        public async void SeasonDetails(Response response)
        {
            await App.Current.MainPage.Navigation.PushAsync(new SeasonsDetails(response));
        }

        public static async Task GetBaseballApi()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://v1.baseball.api-sports.io");
            client.DefaultRequestHeaders.Add("x-rapidapi-key", "50033e93a2d49d985f3daa64adae1a80");
            client.DefaultRequestHeaders.Add("x-rapidapi-host", "v3.football.api-sports.io");
            var response = await client.GetAsync("/seasons");
            var stringa = await response.Content.ReadAsStringAsync();
            myDeserializedClass = JsonSerializer.Deserialize<Seasons>(stringa);
        }
    }
}
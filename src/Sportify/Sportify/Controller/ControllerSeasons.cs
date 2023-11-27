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
        public static BaseballSeasons myDeserializedClass;
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
        public async void SeasonDetails(int response)
        {
            await App.Current.MainPage.Navigation.PushAsync(new SeasonsDetails(response));
        }

        public static async Task GetBaseballApi()
        {
            var response = await App.baseballClient.GetAsync("/seasons");
            var stringa = await response.Content.ReadAsStringAsync();
            myDeserializedClass = JsonSerializer.Deserialize<BaseballSeasons>(stringa);
        }
    }
}
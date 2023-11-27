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
using CommunityToolkit.Mvvm.ComponentModel;
//using static Android.Provider.DocumentsContract;

namespace Sportify.Controller
{
    public partial class ControllerSeasons : ObservableObject
    {
        public static BaseballSeasons myDeserializedClass;
        public ObservableCollection<int> Game { get; set; } = new ObservableCollection<int>();

        [ObservableProperty]
        public bool isLoading = false;

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
            IsLoading = true; 
            await GetBaseballApi();
            CreateList();
            IsLoading = false;
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
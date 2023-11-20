using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Sportify.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportify.Controller
{
    public partial class HomePageController : ObservableObject
    {
        [ObservableProperty]
        int rotation = 90;
        [ObservableProperty]
        bool isVisible = false;

        private static bool isBusy = false;

        [RelayCommand]
        public void ViewMenu()
        {
            Rotation = Rotation == 90 ? 270 : 90;
            IsVisible = !IsVisible;
        }

        [RelayCommand]
        public async Task SportClicked(string sport)
        {
            if (isBusy) return;
            isBusy = true;
            switch (sport)
            {
                case "Formula 1":
                    await Shell.Current.GoToAsync(nameof(HomeFormula1), true);
                    isBusy = false;
                    break;
                case "Rugby":
                    await Shell.Current.GoToAsync(nameof(HomeRugby), true);
                    isBusy = false;
                    break;
                case "Baseball":
                    await Shell.Current.GoToAsync(nameof(ChooseCall), true);
                    isBusy = false;
                    break;

            }
        }
    }
}

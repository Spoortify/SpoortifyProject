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

        [RelayCommand]
        public void ViewMenu()
        {
            Rotation = Rotation == 90 ? 270 : 90;
            IsVisible = !IsVisible;
        }

        [RelayCommand]
        public async Task SportClicked(string sport)
        {
            switch (sport)
            {
                case "Formula 1":
                    await Shell.Current.GoToAsync(nameof(HomeFormula1), true);
                    break;
                case "Rugby":
                    await Shell.Current.GoToAsync(nameof(HomeRugby), true);
                    break;
                case "Baseball":
                    await Shell.Current.GoToAsync(nameof(ChooseCall), true);
                    break;
            }
        }
    }
}

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
    }
}

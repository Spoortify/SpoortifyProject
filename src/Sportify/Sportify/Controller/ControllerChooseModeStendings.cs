using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Sportify.Model;
using Sportify.View;
namespace Sportify.Controller
{
    public partial class ControllerChooseModeStendings : ObservableObject
    {
        public int season, leaugue;

        public ControllerChooseModeStendings(int s, int l)
        {
            season = s;
            leaugue = l;
        }

        public async Task Start()
        {

        }

        [RelayCommand]
        public void ButtonTeams()
        {
            App.Current.MainPage.Navigation.PushAsync(new ViewTeams(season, leaugue));
        }

        [RelayCommand]
        public void ButtonClassifica()
        {
            App.Current.MainPage.Navigation.PushAsync(new ViewStandings(season, leaugue));
        }
    }
}

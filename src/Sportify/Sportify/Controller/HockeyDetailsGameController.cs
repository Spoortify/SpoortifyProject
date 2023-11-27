using CommunityToolkit.Mvvm.ComponentModel;
using Sportify.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportify.Controller
{
    public partial class HockeyDetailsGameController : ObservableObject
    {
        [ObservableProperty]
        public HockeyGameResponse hockeyGame;
        public HockeyDetailsGameController(HockeyGameResponse hockeyGame)
        {
            this.hockeyGame = hockeyGame;
        }
    }
}

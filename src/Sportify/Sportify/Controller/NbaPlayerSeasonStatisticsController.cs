using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Sportify.Model;
using Sportify.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportify.Controller
{
    public partial class NbaPlayerSeasonStatisticsController : ObservableObject
    {
        [ObservableProperty]
        List<NBAResponse> teamSeasonStandings = new();

        public NbaPlayerSeasonStatisticsController(List<NBAResponse> response)
        {

        }

        
    }
}
